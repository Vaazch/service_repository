using WebApplication.DTO;

namespace WebApplication.Services;

public interface IPersonSevice
{
    List<PersonDto> GetPeople();
    PersonDto GetPerson(int id);
}
