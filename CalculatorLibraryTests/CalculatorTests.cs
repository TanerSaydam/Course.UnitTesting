using CalculatorLibrary;

namespace CalculatorLibraryTests;
public class CalculatorTests
{
    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        var calculator = new Calculator();

        var result = calculator.Add(5, 4);

        Assert.Equal(9, result);
    }
}
