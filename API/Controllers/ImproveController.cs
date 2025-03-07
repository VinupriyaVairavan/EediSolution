using API.Dto;
using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]/misconceptions/{studentId}")]
public class ImproveController(ILogger<ImproveController> logger, IServiceManager serviceManager) : ControllerBase
{
    /// <summary>
    /// Retrieves misconceptions for a student.
    /// </summary>
    /// <param name="studentId">The ID of the student</param>
    /// <returns>List of Topics with misconceptions</returns>
    /// <response code="200">Returns list of topics </response>
    /// <response code="204">No misconceptions found</response>
    /// <response code="400">Invalid student id format</response>
    /// <response code="404">studentId not valid/found</response>
    [ProducesResponseType(typeof(List<TopicDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet()]
    public async Task<IActionResult> GetMisConceptionsForStudent(int studentId)
    {
        // logger.LogInformation($"Get Misconceptions for student {studentId}");
        var misconceptionsDtos =
            await serviceManager.ImproveService.GetMisConceptionsForStudent(studentId);

        if (!misconceptionsDtos.Any())
        {
            logger.LogInformation($"No misconceptions found for student {studentId}");
            return NoContent();
        }

        return Ok(misconceptionsDtos);
    }

    /// <summary>
    /// Retrieves misconceptions for a student in a specific subtopic.
    /// </summary>
    /// <param name="studentId">The ID of the student</param>
    /// <param name="subtopicId">The ID of the subtopic</param>
    /// <returns>List of SubTopics with misconceptions</returns>
    /// <response code="200">Returns list of subtopics </response>
    /// <response code="204">No misconceptions found for this subtopic</response>
    /// <response code="400">Invalid studentId/subtopicId</response>
    /// <response code="404">Subtopic not found</response>
    [ProducesResponseType(typeof(List<SubTopicDto>), StatusCodes.Status200OK)] 
    [ProducesResponseType(StatusCodes.Status204NoContent)] 
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("subtopics/{subtopicId}")]
    public async Task<IActionResult> GetMisConceptionsForStudentBySubTopicId(int studentId, int subtopicId)
    {
        logger.LogInformation($"Get Misconceptions for student {studentId}");
        var misconceptionsDtos = 
            await serviceManager.ImproveService.GetMisConceptionsForStudentBySubTopicId(studentId, subtopicId);

        return Ok(misconceptionsDtos);
    }
    
    /// <summary>
    /// Re-submits an answer for a question.
    /// </summary>
    /// <param name="studentId">The ID of the student</param>
    /// <param name="questionId">The ID of the question</param>
    /// <param name="answerId">The ID of the new answer</param>
    /// <returns>Updated answer response</returns>
    /// <response code="200">Answer resubmitted successfully</response>
    /// <response code="400">Invalid studentId/questionId/answerId</response>
    /// <response code="404">Question or answer not found</response>
    [ProducesResponseType(typeof(StudentAssignmentDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)] 
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpPut("questions/{questionId}/answer/{answerId}")]
    public async Task<IActionResult> GetMisConceptionsForStudent(int studentId, int questionId, int answerId)
    {
        logger.LogInformation($"Get Misconceptions for student {studentId}");
        var resubmittedAnswer = 
            await serviceManager.ImproveService.ReSubmitAnswerForStudentByQuestionId(studentId, questionId, answerId);

        return Ok(resubmittedAnswer);
    }
}