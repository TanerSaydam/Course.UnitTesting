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

    public IEnumerable<User> Users = new[]
    {
        new User()
        {
            FullName = "Taner Saydam",
            Age = 33,
            DateOfBirth = new(1989,09,03)
        },
        new User()
        {
            FullName = "Tahir Saydam",
            Age = 6,
            DateOfBirth = new(2017,09,22)
        },
        new User()
        {
            FullName = "Toprak Saydam",
            Age = 3,
            DateOfBirth = new(2019,09,05)
        },
    };

    public IEnumerable<int> Numbers = new[] { 5, 10, 25, 50 };

    public float Divide(int a, int b)
    {
        EnsureThatDivisorIsNotZero(a);
        EnsureThatDivisorIsNotZero(b);

        return a / b;
    }

    private void EnsureThatDivisorIsNotZero(int b)
    {
        if(b == 0)
        {
            throw new DivideByZeroException();
        }
    }

    public event EventHandler ExampleEvent;    

    public virtual void RaiseExampleEvent()
    {
        ExampleEvent(this, EventArgs.Empty);
    }

    internal int InternalSecretNumber = 42;
}
