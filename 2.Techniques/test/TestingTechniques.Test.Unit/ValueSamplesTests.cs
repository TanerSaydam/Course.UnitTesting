using FluentAssertions;

namespace TestingTechniques.Test.Unit;
public class ValueSamplesTests
{
    private readonly ValueSamples _sut = new();

    [Fact]
    public void StingAssertionsExample()
    {
        var fullName = _sut.FullName;


        fullName.Should().Be("Taner Saydam");
        fullName.Should().NotBeEmpty();
        fullName.Should().StartWith("Taner");
        fullName.Should().EndWith("Saydam");
    }
}
