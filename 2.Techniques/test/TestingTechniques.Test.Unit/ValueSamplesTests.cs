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
}
