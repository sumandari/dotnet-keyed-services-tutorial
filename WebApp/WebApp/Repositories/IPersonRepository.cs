namespace WebApp.Repositories;

public interface IPersonRepository<TModel>
{
    string GetPerson(TModel model);
}