﻿using System;
using System.Collections.Generic;

namespace SchoolManagement.Api.Models
{
    public partial class Religion
    {
        public Religion()
        {
            Castes = new HashSet<Caste>();
            FamilyInfos = new HashSet<FamilyInfo>();
            ParentRelatives = new HashSet<ParentRelative>();
            TraineeBioDataGeneralInfos = new HashSet<TraineeBioDataGeneralInfo>();
            TraineeBioDataOthers = new HashSet<TraineeBioDataOther>();
        }

        public int ReligionId { get; set; }
        public string ReligionName { get; set; }
        public int? MenuPosition { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Caste> Castes { get; set; }
        public virtual ICollection<FamilyInfo> FamilyInfos { get; set; }
        public virtual ICollection<ParentRelative> ParentRelatives { get; set; }
        public virtual ICollection<TraineeBioDataGeneralInfo> TraineeBioDataGeneralInfos { get; set; }
        public virtual ICollection<TraineeBioDataOther> TraineeBioDataOthers { get; set; }
    }
}
