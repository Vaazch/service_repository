namespace WebApi.Repository;
public class PersonRepository : IPersonRepository
{
    public IEnumerable<Person> GetAll() => GetPeople();

    public Person GetById(int Id) => GetPeople().FirstOrDefault(p => p.Id == Id);

    #region private
    public IEnumerable<Person> GetPeople() => new List<Person>()
        {
            new Person() { Id = 1, Name = "Mike", Age = 32 },
            new Person() { Id = 2, Name = "Ana", Age = 24 },
            new Person() { Id = 3, Name = "Jake", Age = 28 }
        };
    #endregion
}
