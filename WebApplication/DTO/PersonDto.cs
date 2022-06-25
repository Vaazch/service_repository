namespace WebApi.DTO;

public record PersonDto
{
    public string Name { get; init; }
    public int Age { get; init; }


    //You can do the mapping internaly on the service class or use a method like this one.
    public static PersonDto ToDto(Person person) => new(){ Name = person.Name, Age = person.Age };
}
