namespace WebApi.Entity;

public record Person 
{
    public long Id { get; init; }
    public string Name { get; init; }
    public int Age { get; init; }
}
