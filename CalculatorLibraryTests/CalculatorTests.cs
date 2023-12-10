using CalculatorLibrary;
using Xunit.Abstractions;

namespace CalculatorLibraryTests;
public class CalculatorTests
{
    private readonly Calculator _sut = new();
    private readonly Guid _guid = Guid.NewGuid();

    private readonly ITestOutputHelper _outputHelper;

    public CalculatorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Act
        var result = _sut.Add(5, 4);


        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void TestGuid1()
    {
        _outputHelper.WriteLine(_guid.ToString());
    }

    [Fact]
    public void TestGuid2()
    {
        _outputHelper.WriteLine(_guid.ToString());
    }
}
