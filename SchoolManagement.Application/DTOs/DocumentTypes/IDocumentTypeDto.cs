﻿namespace SchoolManagement.Application.DTOs.DocumentTypes 
{
    public interface IDocumentTypeDto
    {
        public int DocumentTypeId { get; set; }
        public string? DocumentTypeName { get; set; }
        public string? IconName { get; set; }
        public int? MenuPosition { get; set; }
        public bool IsActive { get; set; }
    }
}
 