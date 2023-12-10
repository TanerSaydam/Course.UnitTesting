namespace TestingTechniques;
public class ValueSamples
{
    public string FullName = "Taner Saydam";

    public int Age = 33;

    public DateOnly DateOfBirth = new(1989, 09, 03);

    public User AppUser = new()
    {
        FullName = "Taner Saydam",
        Age = 33,
        DateOfBirth = new(1989, 09, 03)
    };
}
