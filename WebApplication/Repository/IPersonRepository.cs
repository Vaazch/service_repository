namespace WebApi.Repository;

public interface IPersonRepository
{
    IEnumerable<Person> GetAll();
    Person GetById(int Id);
}
