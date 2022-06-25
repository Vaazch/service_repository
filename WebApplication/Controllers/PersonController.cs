namespace WebApi.Controllers;

public class PersonController : ControllerBase
{
    private readonly IPersonSevice _personService;

    public PersonController(IPersonSevice personSevice)
    {
        _personService = personSevice;
    }

    [HttpGet]
    [Route("people")]
    public IReadOnlyList<PersonDto> GetAll() => _personService.GetPeople();
  

    [HttpGet]
    [Route("person")]
    public PersonDto GetById(int Id) => _personService.GetPerson(Id);
}
