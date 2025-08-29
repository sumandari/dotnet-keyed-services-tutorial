using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;


namespace WebApp.Controllers;

[ApiController]
[Route("api/student")]
public class StudentController: ControllerBase
{
    private readonly IPersonRepository<StudentModel> _student;

    public StudentController(IPersonRepository<StudentModel> student)
    {
        _student = student;
    }
    
    [HttpGet]
    public async  Task<ActionResult<string>> GetStudent(
        [FromQuery] string? name,
        [FromQuery] int? age)
    {
        var studentName = !string.IsNullOrEmpty(name) ? name : "Unknown";
        var studentAge = age.HasValue ? age.Value : 0;
        var studentModel = new StudentModel
        {
            Name = studentName,
            Age = studentAge
        };
        var studentInfo = _student.GetPerson(studentModel);
        return Ok(studentInfo);
    }
}