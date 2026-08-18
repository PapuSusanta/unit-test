using Calculator;

namespace Test.Calculator;

public class TestMultiplication
{
    [Fact]
    public void Multiply_TwoNumber_ShouldReturnResult()
    {
        var calculator = new Calculation();
        var result = calculator.Multiply(2, 2);
        Assert.Equal(2, result);
    }
}