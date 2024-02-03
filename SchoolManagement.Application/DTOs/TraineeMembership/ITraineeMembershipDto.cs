﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.DTOs.TraineeMembership
{
    public interface ITraineeMembershipDto
    {
        public int TraineeMembershipId { get; set; }
        public int TraineeId { get; set; }
        public int MembershipTypeId { get; set; }
        public string OrgName { get; set; } 
        public string BriefAddress { get; set; } 
        public string Appointment { get; set; }
        public DateTime DurationFrom { get; set; }
        public DateTime DurationTo { get; set; }
        public string? AdditionalInformation { get; set; }
        public int? MenuPosition { get; set; }
        public bool IsActive { get; set; }
    }
}
