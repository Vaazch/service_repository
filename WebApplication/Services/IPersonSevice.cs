namespace WebApi.Services;

public interface IPersonSevice
{
    IReadOnlyList<PersonDto> GetPeople();
    PersonDto GetPerson(int id);
}
