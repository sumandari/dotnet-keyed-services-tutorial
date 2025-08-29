using WebApp.Models;
using Bogus;

namespace WebApp.Repositories;

public class TeacherRepository: IPersonRepository<TeacherModel>
{
    public string GetPerson(TeacherModel _teacher)
    {
        var faker = new Faker();
        var _teacherName = faker.Name.FullName();
        return $"Grade {_teacher.Grade} teacher: {_teacherName}.";
    }
}