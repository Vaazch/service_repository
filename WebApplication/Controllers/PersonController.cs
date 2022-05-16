using Microsoft.AspNetCore.Mvc;
using WebApplication.DTO;
using WebApplication.Services;
namespace WebApplication.Controllers;

public class PersonController : ControllerBase
{
    private readonly IPersonSevice _personService;

    public PersonController(IPersonSevice personSevice)
    {
        _personService = personSevice;
    }

    [HttpGet]
    [Route("people")]
    public List<PersonDto> GetAll()
    {
        return _personService.GetPeople();
    }

    [HttpGet]
    [Route("person")]
    public PersonDto GetById(int Id)
    {
        return _personService.GetPerson(Id);
    }
}
