using System;
using System.Collections.Generic;

namespace SchoolManagement.Api.Models
{
    public partial class CourseName
    {
        public CourseName()
        {
            Allowances = new HashSet<Allowance>();
            Attendances = new HashSet<Attendance>();
            BnaExamAttendances = new HashSet<BnaExamAttendance>();
            BnaExamInstructorAssigns = new HashSet<BnaExamInstructorAssign>();
            BnaExamMarks = new HashSet<BnaExamMark>();
            BnaSubjectNames = new HashSet<BnaSubjectName>();
            Bulletins = new HashSet<Bulletin>();
            ClassPeriods = new HashSet<ClassPeriod>();
            ClassRoutines = new HashSet<ClassRoutine>();
            CourseBudgetAllocations = new HashSet<CourseBudgetAllocation>();
            CourseDurations = new HashSet<CourseDuration>();
            CourseGradingEntries = new HashSet<CourseGradingEntry>();
            CourseInstructors = new HashSet<CourseInstructor>();
            CourseModules = new HashSet<CourseModule>();
            CoursePlanCreates = new HashSet<CoursePlanCreate>();
            CourseSections = new HashSet<CourseSection>();
            CourseTasks = new HashSet<CourseTask>();
            CourseWeeks = new HashSet<CourseWeek>();
            Documents = new HashSet<Document>();
            Events = new HashSet<Event>();
            ForeignCourseGoinfos = new HashSet<ForeignCourseGoinfo>();
            ForeignCourseOtherDocs = new HashSet<ForeignCourseOtherDoc>();
            ForeignCourseOthersDocuments = new HashSet<ForeignCourseOthersDocument>();
            GuestSpeakerQuationGroups = new HashSet<GuestSpeakerQuationGroup>();
            IndividualBulletins = new HashSet<IndividualBulletin>();
            IndividualNotices = new HashSet<IndividualNotice>();
            InstructorAssignments = new HashSet<InstructorAssignment>();
            InterServiceCourseReports = new HashSet<InterServiceCourseReport>();
            InterServiceMarks = new HashSet<InterServiceMark>();
            InterServiceOthersDocs = new HashSet<InterServiceOthersDoc>();
            NewEntryEvaluations = new HashSet<NewEntryEvaluation>();
            Notices = new HashSet<Notice>();
            ReadingMaterials = new HashSet<ReadingMaterial>();
            RoutineNotes = new HashSet<RoutineNote>();
            SubjectMarks = new HashSet<SubjectMark>();
            TdecQuationGroups = new HashSet<TdecQuationGroup>();
            TraineeAssignmentSubmits = new HashSet<TraineeAssignmentSubmit>();
            TraineeBioDataOthers = new HashSet<TraineeBioDataOther>();
            TraineeNominations = new HashSet<TraineeNomination>();
            TrainingObjectives = new HashSet<TrainingObjective>();
            TrainingSyllabi = new HashSet<TrainingSyllabus>();
        }

        public int CourseNameId { get; set; }
        public int? CourseTypeId { get; set; }
        public string Course { get; set; }
        public string ShortName { get; set; }
        public string CourseSyllabus { get; set; }
        public int? MenuPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual CourseType CourseType { get; set; }
        public virtual ICollection<Allowance> Allowances { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<BnaExamAttendance> BnaExamAttendances { get; set; }
        public virtual ICollection<BnaExamInstructorAssign> BnaExamInstructorAssigns { get; set; }
        public virtual ICollection<BnaExamMark> BnaExamMarks { get; set; }
        public virtual ICollection<BnaSubjectName> BnaSubjectNames { get; set; }
        public virtual ICollection<Bulletin> Bulletins { get; set; }
        public virtual ICollection<ClassPeriod> ClassPeriods { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
        public virtual ICollection<CourseBudgetAllocation> CourseBudgetAllocations { get; set; }
        public virtual ICollection<CourseDuration> CourseDurations { get; set; }
        public virtual ICollection<CourseGradingEntry> CourseGradingEntries { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<CourseModule> CourseModules { get; set; }
        public virtual ICollection<CoursePlanCreate> CoursePlanCreates { get; set; }
        public virtual ICollection<CourseSection> CourseSections { get; set; }
        public virtual ICollection<CourseTask> CourseTasks { get; set; }
        public virtual ICollection<CourseWeek> CourseWeeks { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ForeignCourseGoinfo> ForeignCourseGoinfos { get; set; }
        public virtual ICollection<ForeignCourseOtherDoc> ForeignCourseOtherDocs { get; set; }
        public virtual ICollection<ForeignCourseOthersDocument> ForeignCourseOthersDocuments { get; set; }
        public virtual ICollection<GuestSpeakerQuationGroup> GuestSpeakerQuationGroups { get; set; }
        public virtual ICollection<IndividualBulletin> IndividualBulletins { get; set; }
        public virtual ICollection<IndividualNotice> IndividualNotices { get; set; }
        public virtual ICollection<InstructorAssignment> InstructorAssignments { get; set; }
        public virtual ICollection<InterServiceCourseReport> InterServiceCourseReports { get; set; }
        public virtual ICollection<InterServiceMark> InterServiceMarks { get; set; }
        public virtual ICollection<InterServiceOthersDoc> InterServiceOthersDocs { get; set; }
        public virtual ICollection<NewEntryEvaluation> NewEntryEvaluations { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
        public virtual ICollection<ReadingMaterial> ReadingMaterials { get; set; }
        public virtual ICollection<RoutineNote> RoutineNotes { get; set; }
        public virtual ICollection<SubjectMark> SubjectMarks { get; set; }
        public virtual ICollection<TdecQuationGroup> TdecQuationGroups { get; set; }
        public virtual ICollection<TraineeAssignmentSubmit> TraineeAssignmentSubmits { get; set; }
        public virtual ICollection<TraineeBioDataOther> TraineeBioDataOthers { get; set; }
        public virtual ICollection<TraineeNomination> TraineeNominations { get; set; }
        public virtual ICollection<TrainingObjective> TrainingObjectives { get; set; }
        public virtual ICollection<TrainingSyllabus> TrainingSyllabi { get; set; }
    }
}
