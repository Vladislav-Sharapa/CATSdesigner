﻿using Application.Core.Data;

namespace LMPlatform.Models
{
    using System;

    public class UserLabFiles : ModelBase
    {
         public string Comments { get; set; }

        public string Attachments { get; set; }

		public int UserId { get; set; }

        public User User { get; set; }

		public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int? LabId { get; set; }

        public Labs Lab { get; set; }
        public int? PracticalId { get; set; }

        public Practical Practical { get; set; }
        public DateTime? Date { get; set; }

		public bool IsReceived { get; set; }
        public bool IsReturned { get; set; }
        public bool IsCoursProject { get; set; }
    }
}