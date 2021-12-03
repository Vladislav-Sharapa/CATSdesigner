﻿using JWT.Algorithms;
using JWT.Builder;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Claims;
using System.Web;
using WebMatrix.WebData;

namespace Application.Core.Helpers
{
    public static class UserContext
    {
        public static string Name { get; set; }

        public static string Id { get; set; }

        private static string _role;
        public static string Role
        {
            get => GetRole();
            set => _role = value;
        }

        public static int CurrentUserId => UserId();

        public static string CurrentUserName =>
            string.IsNullOrEmpty(WebSecurity.CurrentUserName) ? Name : WebSecurity.CurrentUserName;

        static int UserId()
        {
            var authCookie = HttpContext.Current.Request.Cookies["Authorization"];

            var autHeader = HttpContext.Current.Request.Headers["Authorization"];
            if (authCookie != null || autHeader != null)
            {
                var token = authCookie != null ? authCookie.Value : autHeader.Replace("Bearer", "");
                try
                {
                    var tokenSecret = ConfigurationManager.AppSettings["jwt:secret"];
                    var json = new JwtBuilder()
                        .WithSecret(tokenSecret)
                        .WithAlgorithm(new HMACSHA256Algorithm())
                        .MustVerifySignature()
                        .Decode<IDictionary<string, string>>(token);

                    return int.TryParse(json["id"], out var id) ? id : WebSecurity.CurrentUserId <= 0 ? int.Parse(Id) : WebSecurity.CurrentUserId; ;
                }
                catch
                {
                    return WebSecurity.CurrentUserId <= 0 ? int.Parse(Id) : WebSecurity.CurrentUserId;
                }
            }
            return WebSecurity.CurrentUserId <= 0 ? int.Parse(Id) : WebSecurity.CurrentUserId; ;
        }

        static string GetRole()
        {
            var authCookie = HttpContext.Current.Request.Cookies["Authorization"];

            var autHeader = HttpContext.Current.Request.Headers["Authorization"];
            if (authCookie != null || autHeader != null)
            {
                var token = authCookie != null ? authCookie.Value : autHeader.Replace("Bearer", "");
                try
                {
                    var tokenSecret = ConfigurationManager.AppSettings["jwt:secret"];
                    var json = new JwtBuilder()
                        .WithSecret(tokenSecret)
                        .WithAlgorithm(new HMACSHA256Algorithm())
                        .MustVerifySignature()
                        .Decode<IDictionary<string, string>>(token);
                    var role = json[ClaimsIdentity.DefaultRoleClaimType];
                    return !string.IsNullOrWhiteSpace(role) ? role : _role;
                }
                catch
                {
                    return _role;
                }
            }
            return _role;
        }
    }
}