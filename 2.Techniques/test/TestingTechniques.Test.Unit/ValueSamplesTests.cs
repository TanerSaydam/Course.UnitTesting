using FluentAssertions;

namespace TestingTechniques.Test.Unit;
public class ValueSamplesTests
{
    private readonly ValueSamples _sut = new();

    [Fact]
    public void StingAssertionExample()
    {
        var fullName = _sut.FullName;


        fullName.Should().Be("Taner Saydam");
        fullName.Should().NotBeEmpty();
        fullName.Should().StartWith("Taner");
        fullName.Should().EndWith("Saydam");
    }

    [Fact]
    public void NumberAssertionExmaple()
    {
        var age = _sut.Age;

        age.Should().Be(33);
        age.Should().BePositive();
        age.Should().BeGreaterThan(20); 
        age.Should().BeLessThanOrEqualTo(33);
        age.Should().BeInRange(20, 50);
    }

    [Fact]
    public void DateAssertionExample()
    {
        var dateOfBirth = _sut.DateOfBirth;

        dateOfBirth.Should().Be(new(1989, 09, 03));
        dateOfBirth.Should().BeAfter(new(1900, 01, 01));
        dateOfBirth.Should().BeBefore(new(2900, 01, 01));
    }

    [Fact]
    public void ObjectAssertionTest()
    {
        var expected = new User
        {
            FullName = "Taner Saydam",
            Age = 33,
            DateOfBirth = new(1989, 09, 03)
        };

        var user = _sut.AppUser;

        user.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void EnumerableObjectAssertionExample()
    {
        var expected = new User
        {
            FullName = "Taner Saydam",
            Age = 33,
            DateOfBirth = new(1989, 09, 03)
        };

        var users = _sut.Users.As<User[]>();

        users.Should().ContainEquivalentOf(expected);
        users.Should().HaveCount(3);
        users.Should().Contain(x => x.FullName.StartsWith("Tahir") && x.Age > 5);
    }

    [Fact]
    public void EnumrableNumberAssertionExample()
    {
        var numbers = _sut.Numbers.As<int[]>();

        numbers.Should().Contain(5);
    }

    [Fact]
    public void ExceptionThrownAssertionExample()
    {
        Action result = () => _sut.Divide(1, 0);

        result.Should().Throw<DivideByZeroException>().WithMessage("Attempted to divide by zero.");
    }

    [Fact]
    public void EventRaisedAssertionExample()
    {
        var monitorSubject = _sut.Monitor();

        _sut.RaiseExampleEvent();

        monitorSubject.Should().Raise("ExampleEvent");        
    }

    [Fact]
    public void TestingInternalMembersExample()
    {
        var number = _sut.InternalSecretNumber;

        number.Should().Be(42);
    }
}
