using Calculator;
using FluentAssertions;

namespace Calculator.Test.Unit;

public class CalculatorTest
{
    [Fact]
    public void Add_TowNumbers_ShoulsReturnsCorrectResult()
    {
        var calculator = new Calculation();
        var result = calculator.Add(1, 2);
        result.Should().Be(3);
    }

    // [Fact]
    [Theory]
    [InlineData(1, 2, -1)]
    public void Subtract_TowNumbers_ShoulsReturnsCorrectResult(int a, int b, int c)
    {
        var calculator = new Calculation();
        var result = calculator.Subtract(a, b);
        result.Should().Be(c);
    }

    [Fact]
    public void Multiply_TowNumbers_ShoulsReturnsCorrectResult()
    {
        var calculator = new Calculation();
        var result = calculator.Multiply(1, 2);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Divide_TowNumbers_ShoulsReturnsCorrectResult()
    {
        var calculator = new Calculation();
        var result = calculator.Divide(4, 2);
        Assert.Equal(2 , result);
    }
}