using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repositories;


namespace WebApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController: ControllerBase
{
    private readonly IPersonRepository<TeacherModel> _teacher;

    public TeacherController([FromKeyedServices("teacher")] IPersonRepository<TeacherModel> teacher)
    {
        _teacher = teacher;
    }
    
    [HttpGet]
    public async  Task<ActionResult<string>> GetTeacher(
        [FromQuery] int? grade)
    {
        var teacherModel = new TeacherModel
        {
            Grade = grade ?? 0,
        };
        var teacherInfo = _teacher.GetPerson(teacherModel);
        return Ok(teacherInfo);
    }
}