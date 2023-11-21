using AutoMapper;
using MediatR;
using SchoolManagement.Application.Contracts.Persistence;
using SchoolManagement.Application.DTOs.CourseWeeks;
using SchoolManagement.Application.Features.CourseWeeks.Requests.Queries;
using SchoolManagement.Application.Responses;
using SchoolManagement.Domain;

namespace SchoolManagement.Application.Features.CourseWeeks.Handlers.Queries
{
    public class GetAutoCourseWeekCountForBnaRequestHandler : IRequestHandler<GetAutoCourseWeekCountForBnaRequest, object>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISchoolManagementRepository<CourseWeek> _CourseWeekRepository;
        //private readonly ISchoolManagementRepository<CourseDuration> _CourseDurationRepository;
        private readonly ISchoolManagementRepository<BnaSemesterDuration> _BnaSemesterDurationRepository;
        public GetAutoCourseWeekCountForBnaRequestHandler(ISchoolManagementRepository<CourseWeek> CourseWeekRepository, ISchoolManagementRepository<BnaSemesterDuration> BnaSemesterDurationRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _CourseWeekRepository = CourseWeekRepository;
            //_CourseDurationRepository = CourseDurationRepository;
            _BnaSemesterDurationRepository = BnaSemesterDurationRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<object> Handle(GetAutoCourseWeekCountForBnaRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            //var CourseDuration = _CourseDurationRepository.FinedOneInclude(x => x.CourseDurationId == request.CourseDurationId);
            var BnaSemesterDuration = _BnaSemesterDurationRepository.FinedOneInclude(x => x.BnaSemesterDurationId == request.BnaSemesterDurationId);
          
            DateTime startDate, endDate;

            List<CourseWeek> courseWeeks = new List<CourseWeek>();
            //DateTime[] startDate1 = new DateTime[20], endDate1 =new DateTime[20];
            int i = 1;
            for (startDate = Convert.ToDateTime(BnaSemesterDuration.StartDate); startDate <= Convert.ToDateTime(BnaSemesterDuration.EndDate); startDate = startDate.AddDays(7))
            {
                var courseWeek = new CourseWeek()
                {
                    CourseDurationId = BnaSemesterDuration.CourseDurationId,
                    BnaSemesterDurationId = BnaSemesterDuration.BnaSemesterDurationId,
                    //CourseNameId = BnaSemesterDuration.CourseDuration.CourseNameId,
                    BaseSchoolNameId = 2,// BnaSemesterDuration.CourseDuration.BaseSchoolNameId,
                    DateFrom = startDate,
                    DateTo = startDate.AddDays(6),
                    WeekName =Convert.ToString( i +" Week"),
                    Status = 0,
                    IsActive = true
                };
               
                i++;
                courseWeeks.Add(courseWeek);
            }

            await _unitOfWork.Repository<CourseWeek>().AddRangeAsync(courseWeeks);
            await _unitOfWork.Save();

            response.Success = true;
            response.Message = "Creation Successful";

            return response;


        }
    }
}
