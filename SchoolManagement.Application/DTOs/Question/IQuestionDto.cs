﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.DTOs.Question
{
    public interface IQuestionDto
    {

        public int QuestionId { get; set; }
        public int? TraineeId { get; set; }
        public int? QuestionTypeId { get; set; }
        public string? Answer { get; set; }
        public string? AdditionalInformation { get; set; } 
        public int? MenuPosition { get; set; }
        public bool IsActive { get; set; }
    }
}
