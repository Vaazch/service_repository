using WebApplication.DTO;
using WebApplication.Models;
using WebApplication.Repository;

namespace WebApplication.Services;

/// Here you can write all the bussiness logic and treat all exceptions
public class PersonService:IPersonSevice
{
    private readonly IPersonRepository _personRepostiory;
    public PersonService(IPersonRepository personRepository)
    {
        _personRepostiory = personRepository;
    }

    public List<PersonDto> GetPeople()
    {
        IEnumerable<Person> people = _personRepostiory.GetAll();
        if (people is null)
        {
            throw new Exception("No people found");
        }
        List<PersonDto> result = people.Select(person => PersonDto.ToDto(person)).ToList();
        return result;
    }

    public PersonDto GetPerson(int id)
    {
        Person person = _personRepostiory.GetById(id);
        if (person is null)
        {
            throw new Exception("Person not found");
        }
        return PersonDto.ToDto(person);
    }
}
