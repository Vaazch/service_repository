using WebApplication.Models;

namespace WebApplication.Repository;

public interface IPersonRepository
{
    IEnumerable<Person> GetAll();
    Person GetById(int Id);
}
