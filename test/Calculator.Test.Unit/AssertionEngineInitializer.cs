using Calculator.Test.Unit;
using FluentAssertions;

[assembly: FluentAssertions.Extensibility.AssertionEngineInitializer(
    typeof(AssertionEngineInitializer), 
    nameof(AssertionEngineInitializer.AcknowledgeSoftWarning))]

namespace Calculator.Test.Unit;

public static class AssertionEngineInitializer
{
    public static void AcknowledgeSoftWarning()
    {
        License.Accepted = true;
    }
}