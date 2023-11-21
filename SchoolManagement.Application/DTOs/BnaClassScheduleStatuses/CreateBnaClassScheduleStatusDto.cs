﻿namespace SchoolManagement.Application.DTOs.BnaClassScheduleStatuses 
{
    public class CreateBnaClassScheduleStatusDto : IBnaClassScheduleStatusDto  
    {
        public int BnaClassScheduleStatusId { get; set; }
        public string? Name { get; set; }
        public int? MenuPosition { get; set; }
        public bool IsActive { get; set; }
    } 
}
