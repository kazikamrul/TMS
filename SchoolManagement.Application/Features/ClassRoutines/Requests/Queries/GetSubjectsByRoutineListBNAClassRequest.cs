﻿using MediatR;
using SchoolManagement.Application.DTOs.BnaSubjectName;
using SchoolManagement.Application.Models;
using SchoolManagement.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Features.ClassRoutines.Requests.Queries
{
    public class GetSubjectsByRoutineListBNAClassRequest : IRequest<object>
    {
        public int BaseSchoolNameId { get; set; }
        public int CourseNameId { get; set; }
        //public int CourseDurationId { get; set; }
        public int CourseWeekId { get; set; }
        public int CourseSectionId { get; set; }
    }
}

