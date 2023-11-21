using System;
using System.Collections.Generic;

namespace SchoolManagement.Api.Models
{
    public partial class BnaSemester
    {
        public BnaSemester()
        {
            Attendances = new HashSet<Attendance>();
            BnaClassSchedules = new HashSet<BnaClassSchedule>();
            BnaClassTests = new HashSet<BnaClassTest>();
            BnaCurriculumUpdates = new HashSet<BnaCurriculumUpdate>();
            BnaExamAttendances = new HashSet<BnaExamAttendance>();
            BnaExamMarks = new HashSet<BnaExamMark>();
            BnaExamRoutineLogs = new HashSet<BnaExamRoutineLog>();
            BnaExamSchedules = new HashSet<BnaExamSchedule>();
            BnaPromotionLogs = new HashSet<BnaPromotionLog>();
            BnaSemesterDurationBnaSemesters = new HashSet<BnaSemesterDuration>();
            BnaSemesterDurationNextSemesters = new HashSet<BnaSemesterDuration>();
            BnaSubjectNames = new HashSet<BnaSubjectName>();
            TraineeBioDataOthers = new HashSet<TraineeBioDataOther>();
            TraineePictures = new HashSet<TraineePicture>();
            TraineeSectionSelections = new HashSet<TraineeSectionSelection>();
        }

        public int BnaSemesterId { get; set; }
        public string SemesterName { get; set; }
        public int? MenuPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<BnaClassSchedule> BnaClassSchedules { get; set; }
        public virtual ICollection<BnaClassTest> BnaClassTests { get; set; }
        public virtual ICollection<BnaCurriculumUpdate> BnaCurriculumUpdates { get; set; }
        public virtual ICollection<BnaExamAttendance> BnaExamAttendances { get; set; }
        public virtual ICollection<BnaExamMark> BnaExamMarks { get; set; }
        public virtual ICollection<BnaExamRoutineLog> BnaExamRoutineLogs { get; set; }
        public virtual ICollection<BnaExamSchedule> BnaExamSchedules { get; set; }
        public virtual ICollection<BnaPromotionLog> BnaPromotionLogs { get; set; }
        public virtual ICollection<BnaSemesterDuration> BnaSemesterDurationBnaSemesters { get; set; }
        public virtual ICollection<BnaSemesterDuration> BnaSemesterDurationNextSemesters { get; set; }
        public virtual ICollection<BnaSubjectName> BnaSubjectNames { get; set; }
        public virtual ICollection<TraineeBioDataOther> TraineeBioDataOthers { get; set; }
        public virtual ICollection<TraineePicture> TraineePictures { get; set; }
        public virtual ICollection<TraineeSectionSelection> TraineeSectionSelections { get; set; }
    }
}
