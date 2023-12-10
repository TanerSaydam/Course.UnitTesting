using CalculatorLibrary;
using Xunit.Abstractions;

namespace CalculatorLibraryTests;
public class CalculatorTests : IAsyncLifetime
{
    private readonly Calculator _sut = new();

    private readonly ITestOutputHelper _outputHelper;

    public CalculatorTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _outputHelper.WriteLine("Hello from the ctor");
    }

    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Act
        var result = _sut.Add(5, 4);

        _outputHelper.WriteLine("Hello from the add method");

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Act
        var result = _sut.Subtract(10, 7);

        _outputHelper.WriteLine("Hello from the subtract method");

        // Assert
        Assert.Equal(3, result);
    }    

    public async Task InitializeAsync()
    {
        _outputHelper.WriteLine("Hello from the initialize async");
        Task.Delay(1);
    }

    public async Task DisposeAsync()
    {
        _outputHelper.WriteLine("Hello from the dispose async");
        Task.Delay(1);
    }
}
