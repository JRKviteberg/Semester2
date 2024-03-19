using TDDCalc;

namespace TestTDDCalc;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        // Arrange
        Calculator calc;
        calc = new Calculator();

        // Act
        int result = calc.Add(35, 7);
        int correct = 42;

        // Assert
        Assert.Equal(correct, result);
    }
    
    [Fact]
    public void TestSubtract()
    {
        // Arrange
        Calculator calc;
        calc = new Calculator();

        // Act
        int result = calc.Subtract(35, 7);
        int correct = -28;

        // Assert
        Assert.Equal(correct, result);
    }
}