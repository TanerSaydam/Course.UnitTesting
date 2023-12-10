using CalculatorLibrary;

namespace CalculatorLibraryTests;
public class CalculatorTests
{
    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Arrange
        var calculator = new Calculator();


        // Act
        var result = calculator.Add(5, 4);


        // Assert
        Assert.Equal(9, result);
    }
}
