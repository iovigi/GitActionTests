namespace Calculator;

using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_Should_Sum()
    {
        // Arrange
        int a = 8;
        int b = 2;
        int expectedSum = 10;

        Calculator calculator = new Calculator();

        // Act
        var sum = calculator.Add(a, b);

        // Assert
        Assert.Equal(expectedSum, sum);
    }
}
