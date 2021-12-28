public class NomyApe
{
    public NomyApe( int id ,string name, string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }

    public int Id { get; set; }
    public string Name { get; }
    public string Surname { get; }
}