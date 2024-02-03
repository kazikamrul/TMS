﻿using SchoolManagement.Application.Contracts.Persistence;
using MediatR;
using AutoMapper;
using SchoolManagement.Domain;
using SchoolManagement.Application.Features.CourseDurations.Requests.Queries;
using System.Data;

namespace SchoolManagement.Application.Features.CourseDurations.Handlers.Queries
{
    public class GetUpcomingCourseListByTypeFromSpRequestHandler : IRequestHandler<GetUpcomingCourseListByTypeFromSpRequest, object>
    {

        private readonly ISchoolManagementRepository<CourseDuration> _courseDurationRepository;

        private readonly IMapper _mapper;

        public GetUpcomingCourseListByTypeFromSpRequestHandler(ISchoolManagementRepository<CourseDuration> courseDurationRepository, IMapper mapper)
        {
            _courseDurationRepository = courseDurationRepository;
            _mapper = mapper;
        }

        public async Task<object> Handle(GetUpcomingCourseListByTypeFromSpRequest request, CancellationToken cancellationToken)
        {
            
            var spQuery = String.Format("exec [spGetUpcomingCourseByType] {0},'{1}'", request.CourseTypeId, request.CurrentDate);
            
            DataTable dataTable = _courseDurationRepository.ExecWithSqlQuery(spQuery);
            return dataTable;
         
        }
    }
}
