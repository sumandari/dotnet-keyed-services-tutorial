using WebApp.Models;
namespace WebApp.Repositories;

public class StudentRepository : IPersonRepository<StudentModel>
{
    public string GetPerson(StudentModel _student)
    {
        var studentClass = "unknown";
        switch (_student.Age)
        {
            case >= 0 and <= 5:
                studentClass = "Preschool";
                break;
            case >= 6 and <= 13:
                studentClass = "Elementary School";
                break;
            case >= 14 and <= 18:
                studentClass = "High School";
                break;
            case > 18:
                studentClass = "College/University";
                break;
        }
        return $"{studentClass} student: {_student.Name} is {_student.Age} years old.";
    }
}