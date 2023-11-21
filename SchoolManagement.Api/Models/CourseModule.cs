using System;
using System.Collections.Generic;

namespace SchoolManagement.Api.Models
{
    public partial class CourseModule
    {
        public CourseModule()
        {
            BnaExamInstructorAssigns = new HashSet<BnaExamInstructorAssign>();
            BnaSubjectNames = new HashSet<BnaSubjectName>();
            ClassRoutines = new HashSet<ClassRoutine>();
            CourseInstructors = new HashSet<CourseInstructor>();
            NewEntryEvaluations = new HashSet<NewEntryEvaluation>();
            SubjectMarks = new HashSet<SubjectMark>();
        }

        public int CourseModuleId { get; set; }
        public int? BaseSchoolNameId { get; set; }
        public int? CourseNameId { get; set; }
        public string ModuleName { get; set; }
        public string NameOfModule { get; set; }
        public int? MenuPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual BaseSchoolName BaseSchoolName { get; set; }
        public virtual CourseName CourseName { get; set; }
        public virtual ICollection<BnaExamInstructorAssign> BnaExamInstructorAssigns { get; set; }
        public virtual ICollection<BnaSubjectName> BnaSubjectNames { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<NewEntryEvaluation> NewEntryEvaluations { get; set; }
        public virtual ICollection<SubjectMark> SubjectMarks { get; set; }
    }
}
