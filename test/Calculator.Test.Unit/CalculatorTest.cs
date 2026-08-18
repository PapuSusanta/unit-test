using Calculator;
namespace Test.Calculator;

public class CalculatorTest
{
    [Fact]
    public void Add_TowNumbers_ShoulsReturnsCorrectResult()
    {
        var calculator = new Calculation();
        var result = calculator.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Subtract_TowNumbers_ShoulsReturnsCorrectResult()
    {
        var calculator = new Calculation();
        var result = calculator.Subtract(1, 2);
        Assert.Equal(-1, result);
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