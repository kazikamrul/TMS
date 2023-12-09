using SchoolManagement.Application;
using SchoolManagement.Application.DTOs.CourseNomenees;
using SchoolManagement.Application.Features.CourseNomenees.Requests.Commands;
using SchoolManagement.Application.Features.CourseNomenees.Requests.Queries;

namespace SchoolManagement.Api.Controllers;

[Route(SMSRoutePrefix.CourseNomenees)]
[ApiController]
[Authorize]
public class CourseNomeneeController : ControllerBase
{
    private readonly IMediator _mediator;

    public CourseNomeneeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [Route("get-CourseNomenees")]
    public async Task<ActionResult<List<CourseNomeneeDto>>> Get([FromQuery] QueryParams queryParams)
    {
        var CourseNomenees = await _mediator.Send(new GetCourseNomeneeListRequest { QueryParams = queryParams });
        return Ok(CourseNomenees);
    }

    [HttpGet]
    [Route("get-CourseNomeneeDetail/{id}")]
    public async Task<ActionResult<CourseNomeneeDto>> Get(int id)
    {
        var CourseNomenee = await _mediator.Send(new GetCourseNomeneeDetailRequest { CourseNomeneeId = id });
        return Ok(CourseNomenee);
    }

    [HttpPost]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [Route("save-CourseNomenee")]
    public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] ModifiedCreateCourseNomeneeDto CourseNomenee)
    {
        var command = new CreateCourseNomeneeCommand { CourseNomeneeDto = CourseNomenee };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [Route("update-CourseNomenee/{id}")]
    public async Task<ActionResult> Put([FromBody] CourseNomeneeDto CourseNomenee)
    {
        var command = new UpdateCourseNomeneeCommand { CourseNomeneeDto = CourseNomenee };
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    [Route("delete-CourseNomenee/{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteCourseNomeneeCommand { CourseNomeneeId = id };
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet]
    [Route("get-CourseNomeneeByParameters")]

    public async Task<ActionResult> GetCourseNomeneeByParameters(int baseSchoolNameId, int bnaSubjectNameId, int courseModuleId, int courseNameId, int courseDurationId, int courseSectionId)
    {
        var CourseNomeneeByParameters = await _mediator.Send(new GetCourseNomeneeByParametersRequest
        {
            BaseSchoolNameId = baseSchoolNameId,
            BnaSubjectNameId = bnaSubjectNameId,
            //CourseModuleId = courseModuleId,
            CourseNameId = courseNameId,
            CourseDurationId = courseDurationId,
            CourseSectionId = courseSectionId
        });
        return Ok(CourseNomeneeByParameters);
    }

}