using System;
using System.Collections.Generic;

namespace SchoolManagement.Api.Models
{
    public partial class CourseDuration
    {
        public CourseDuration()
        {
            Attendances = new HashSet<Attendance>();
            BnaExamAttendances = new HashSet<BnaExamAttendance>();
            BnaExamInstructorAssigns = new HashSet<BnaExamInstructorAssign>();
            BnaExamMarks = new HashSet<BnaExamMark>();
            Bulletins = new HashSet<Bulletin>();
            ClassRoutines = new HashSet<ClassRoutine>();
            CourseBudgetAllocations = new HashSet<CourseBudgetAllocation>();
            CourseInstructors = new HashSet<CourseInstructor>();
            CoursePlanCreates = new HashSet<CoursePlanCreate>();
            CourseTasks = new HashSet<CourseTask>();
            CourseWeeks = new HashSet<CourseWeek>();
            Documents = new HashSet<Document>();
            Events = new HashSet<Event>();
            FamilyNominations = new HashSet<FamilyNomination>();
            ForeignCourseGoinfos = new HashSet<ForeignCourseGoinfo>();
            ForeignCourseOtherDocs = new HashSet<ForeignCourseOtherDoc>();
            ForeignCourseOthersDocuments = new HashSet<ForeignCourseOthersDocument>();
            GuestSpeakerQuationGroups = new HashSet<GuestSpeakerQuationGroup>();
            IndividualBulletins = new HashSet<IndividualBulletin>();
            IndividualNotices = new HashSet<IndividualNotice>();
            InstallmentPaidDetails = new HashSet<InstallmentPaidDetail>();
            InstructorAssignments = new HashSet<InstructorAssignment>();
            InterServiceCourseReports = new HashSet<InterServiceCourseReport>();
            InterServiceMarks = new HashSet<InterServiceMark>();
            InterServiceOthersDocs = new HashSet<InterServiceOthersDoc>();
            MigrationDocuments = new HashSet<MigrationDocument>();
            NewEntryEvaluations = new HashSet<NewEntryEvaluation>();
            Notices = new HashSet<Notice>();
            RoutineNotes = new HashSet<RoutineNote>();
            RoutineSoftCopyUploads = new HashSet<RoutineSoftCopyUpload>();
            TdecQuationGroups = new HashSet<TdecQuationGroup>();
            TraineeAssessmentCreates = new HashSet<TraineeAssessmentCreate>();
            TraineeAssessmentMarks = new HashSet<TraineeAssessmentMark>();
            TraineeAssignmentSubmits = new HashSet<TraineeAssignmentSubmit>();
            TraineeAssissmentGroups = new HashSet<TraineeAssissmentGroup>();
            TraineeNominations = new HashSet<TraineeNomination>();
            TrainingObjectives = new HashSet<TrainingObjective>();
            TrainingSyllabi = new HashSet<TrainingSyllabus>();
        }

        public int CourseDurationId { get; set; }
        public int? CourseNameId { get; set; }
        public int? BaseNameId { get; set; }
        public int? BaseSchoolNameId { get; set; }
        public int? CourseTypeId { get; set; }
        public int? CountryId { get; set; }
        public int? OrganizationNameId { get; set; }
        public int? FiscalYearId { get; set; }
        public string CourseTitle { get; set; }
        public string NoOfCandidates { get; set; }
        public DateTime? DurationFrom { get; set; }
        public DateTime? DurationTo { get; set; }
        public string Professional { get; set; }
        public string Nbcd { get; set; }
        public string Remark { get; set; }
        public int? IsCompletedStatus { get; set; }
        public int? IsApproved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? Status { get; set; }
        public int? MenuPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public int? NbcdSchoolId { get; set; }
        public DateTime? NbcdDurationFrom { get; set; }
        public DateTime? NbcdDurationTo { get; set; }
        public int? NbcdStatus { get; set; }
        public int? ComeFromNbcdDurationId { get; set; }

        public virtual BaseSchoolName BaseSchoolName { get; set; }
        public virtual Country Country { get; set; }
        public virtual CourseName CourseName { get; set; }
        public virtual CourseType CourseType { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }
        public virtual OrganizationName OrganizationName { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<BnaExamAttendance> BnaExamAttendances { get; set; }
        public virtual ICollection<BnaExamInstructorAssign> BnaExamInstructorAssigns { get; set; }
        public virtual ICollection<BnaExamMark> BnaExamMarks { get; set; }
        public virtual ICollection<Bulletin> Bulletins { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
        public virtual ICollection<CourseBudgetAllocation> CourseBudgetAllocations { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<CoursePlanCreate> CoursePlanCreates { get; set; }
        public virtual ICollection<CourseTask> CourseTasks { get; set; }
        public virtual ICollection<CourseWeek> CourseWeeks { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<FamilyNomination> FamilyNominations { get; set; }
        public virtual ICollection<ForeignCourseGoinfo> ForeignCourseGoinfos { get; set; }
        public virtual ICollection<ForeignCourseOtherDoc> ForeignCourseOtherDocs { get; set; }
        public virtual ICollection<ForeignCourseOthersDocument> ForeignCourseOthersDocuments { get; set; }
        public virtual ICollection<GuestSpeakerQuationGroup> GuestSpeakerQuationGroups { get; set; }
        public virtual ICollection<IndividualBulletin> IndividualBulletins { get; set; }
        public virtual ICollection<IndividualNotice> IndividualNotices { get; set; }
        public virtual ICollection<InstallmentPaidDetail> InstallmentPaidDetails { get; set; }
        public virtual ICollection<InstructorAssignment> InstructorAssignments { get; set; }
        public virtual ICollection<InterServiceCourseReport> InterServiceCourseReports { get; set; }
        public virtual ICollection<InterServiceMark> InterServiceMarks { get; set; }
        public virtual ICollection<InterServiceOthersDoc> InterServiceOthersDocs { get; set; }
        public virtual ICollection<MigrationDocument> MigrationDocuments { get; set; }
        public virtual ICollection<NewEntryEvaluation> NewEntryEvaluations { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
        public virtual ICollection<RoutineNote> RoutineNotes { get; set; }
        public virtual ICollection<RoutineSoftCopyUpload> RoutineSoftCopyUploads { get; set; }
        public virtual ICollection<TdecQuationGroup> TdecQuationGroups { get; set; }
        public virtual ICollection<TraineeAssessmentCreate> TraineeAssessmentCreates { get; set; }
        public virtual ICollection<TraineeAssessmentMark> TraineeAssessmentMarks { get; set; }
        public virtual ICollection<TraineeAssignmentSubmit> TraineeAssignmentSubmits { get; set; }
        public virtual ICollection<TraineeAssissmentGroup> TraineeAssissmentGroups { get; set; }
        public virtual ICollection<TraineeNomination> TraineeNominations { get; set; }
        public virtual ICollection<TrainingObjective> TrainingObjectives { get; set; }
        public virtual ICollection<TrainingSyllabus> TrainingSyllabi { get; set; }
    }
}
