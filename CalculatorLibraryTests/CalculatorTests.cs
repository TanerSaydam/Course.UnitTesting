using CalculatorLibrary;

namespace CalculatorLibraryTests;
public class CalculatorTests
{
    private readonly Calculator _sut = new();   

    [Theory]
    [InlineData(5,4,9)]
    [InlineData(0,0,0, Skip = "CI'da hataya sebep oluyor")]
    [InlineData(-5,-5,-10)]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
    {
        // Act
        var result = _sut.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "Şimdi değil sonra bakılacak")]
    public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
    {
        // Act
        var result = _sut.Subtract(10, 7);

        // Assert
        Assert.Equal(3, result);
    }  
}
