namespace WebApi.Services;

/// Here you can write all the bussiness logic and treat all exceptions
public class PersonService : IPersonSevice
{
    private readonly IPersonRepository _personRepostiory;
    public PersonService(IPersonRepository personRepository)
    {
        _personRepostiory = personRepository;
    }

    public IReadOnlyList<PersonDto> GetPeople() =>
        _personRepostiory.GetAll().Select(person => PersonDto.ToDto(person)).ToList();

    public PersonDto GetPerson(int id) =>
         PersonDto.ToDto(_personRepostiory.GetById(id) ?? throw new Exception($"Person with Id {id} was not found"));

}
