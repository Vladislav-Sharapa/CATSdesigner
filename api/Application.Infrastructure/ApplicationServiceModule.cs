﻿using Application.Core;
using Application.Infrastructure.AccountManagement;
using Application.Infrastructure.BugManagement;
using Application.Infrastructure.ConceptManagement;
using Application.Infrastructure.CPManagement;
using Application.Infrastructure.DPManagement;
using Application.Infrastructure.FilesManagement;
using Application.Infrastructure.FoldersManagement;
using Application.Infrastructure.GroupManagement;
using Application.Infrastructure.KnowledgeTestsManagement;
using Application.Infrastructure.LecturerManagement;
using Application.Infrastructure.MaterialsManagement;
using Application.Infrastructure.MessageManagement;
using Application.Infrastructure.ProjectManagement;
using Application.Infrastructure.StudentManagement;
using Application.Infrastructure.SubjectManagement;
using Application.Infrastructure.TestQuestionPassingManagement;
using Application.Infrastructure.UserManagement;
using Application.Infrastructure.WatchingTimeManagement;
using Application.Infrastructure.BTS;
using Application.Infrastructure.TinCanManagement;
using Application.Infrastructure.DocumentsManagement;
using Application.Infrastructure.AdaptiveLearning;
using Application.Infrastructure.ScheduleManagement;
using Application.Infrastructure.NoteManagement;
using Application.Infrastructure.LabsManagement;
using Application.Infrastructure.PracticalManagement;
using Application.Infrastructure.ElasticManagement;
using Application.Infrastructure.NewsManagement;
using Application.Infrastructure.SubjectLecturersManagement;

namespace Application.Infrastructure
{
    public class ApplicationServiceModule
    {
        public static IUnityContainerWrapper Initialize(IUnityContainerWrapper containerWrapper)
        {
            containerWrapper.Register<IAccountManagementService, AccountManagementService>();
            containerWrapper.Register<IUsersManagementService, UsersManagementService>();
            containerWrapper.Register<IBugManagementService, BugManagementService>();
            containerWrapper.Register<IGroupManagementService, GroupManagementService>();
            containerWrapper.Register<ITestsManagementService, TestsManagementService>();
            containerWrapper.Register<ITestPassingService, TestPassingService>();
            containerWrapper.Register<IQuestionsManagementService, QuestionsManagementService>();
            containerWrapper.Register<IProjectManagementService, ProjectManagementService>();
            containerWrapper.Register<IStudentManagementService, StudentManagementService>();
            containerWrapper.Register<ISubjectManagementService, SubjectManagementService>();
            containerWrapper.Register<IModulesManagementService, ModulesManagementService>();
            containerWrapper.Register<ILecturerManagementService, LecturerManagementService>();
            containerWrapper.Register<IMessageManagementService, MessageManagementService>();
            containerWrapper.Register<IFilesManagementService, FilesManagementService>();
            containerWrapper.Register<IDpManagementService, DpManagementService>();
            containerWrapper.Register<ICorrelationService, CorrelationService>();
            containerWrapper.Register<ICpCorrelationService, CpCorrelationService>();
            containerWrapper.Register<IDpPercentageGraphService, DpPercentageGraphService>();
            containerWrapper.Register<ICpPercentageGraphService, CpPercentageGraphService>();
            containerWrapper.Register<IUserService, UserService>();
            containerWrapper.Register<ICPUserService, CPUserService>();
            containerWrapper.Register<IFoldersManagementService, FoldersManagementService>();
            containerWrapper.Register<IMaterialsManagementService, MaterialsManagementService>();
            containerWrapper.Register<IConceptManagementService, ConceptManagementService>();
            containerWrapper.Register<ICPManagementService, CPManagementService>();
            containerWrapper.Register<ICPManagementService, CPManagementService>();
            containerWrapper.Register<IWatchingTimeService, WatchingTimeService>();
            containerWrapper.Register<ITestQuestionPassingService, TestQuestionPassingService>();
            containerWrapper.Register<IMatrixManagmentService, MatrixManagmentService>();
            containerWrapper.Register<ITinCanManagementService, TinCanManagementService>();
            containerWrapper.Register<IDocumentManagementService, DocumentManagementService>();
            containerWrapper.Register<IAdaptiveLearningService, AdaptiveLearningService>();
            containerWrapper.Register<IScheduleManagementService, ScheduleManagementService>();
            containerWrapper.Register<INoteManagementService, NoteManagementService>();
            containerWrapper.Register<ILabsManagementService, LabsManagementService>();
            containerWrapper.Register<IPracticalManagementService, PracticalManagementService>();
            containerWrapper.Register<IElasticManagementService, ElasticManagementService>();
            containerWrapper.Register<INewsManagementService, NewsManagementService>();
            containerWrapper.Register<ISubjectLecturersManagementService, SubjectLecturersManagementService>();
            return containerWrapper;
        }
    }
}
