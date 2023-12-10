using CalculatorLibrary;

namespace CalculatorLibraryTests;
public class Tests
{
    [Fact]
    public void TestAdd()
    {
        var calculator = new Calculator();

        var result = calculator.Add(5, 4);

        Assert.Equal(9, result);
    }
}
