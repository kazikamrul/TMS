﻿using MediatR;
using SchoolManagement.Shared.Models;

namespace SchoolManagement.Application.Features.CourseTasks.Requests.Queries
{
    public class GetSelectedSubjectNameFromCourseTaskBySchoolIdAndCourseNameIdRequest : IRequest<List<SelectedModel>>
    {
        public int BaseSchoolNameId { get; set; } 
        public int CourseNameId { get; set; } 
    }
}   
   