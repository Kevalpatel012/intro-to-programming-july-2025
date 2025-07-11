

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("3", 3)]
    public void CanAddASingleNumber(string value, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,3", 6)]
    [InlineData("4,20", 24)]
    [InlineData("5,30", 35)]
    [InlineData("6,40", 46)]
    [InlineData("7,50", 57)]
    public void CanAddTwoNumbers(string value, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,3,3", 9)]
    [InlineData("4,20,1", 25)]
    [InlineData("5,30,1", 36)]
    [InlineData("6,41,3", 50)]
    [InlineData("1,2,3,4,5,6", 21)]
    public void CanAddMultipleNumbers(string value, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("4\n20", 24)]
    [InlineData("5\n30", 35)]
    [InlineData("6\n41", 47)]
    [InlineData("1\n9", 10)]
    public void CanAddNonCommaNumbers(string value, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2,5", 8)]
    [InlineData("4\n20,5", 29)]
    [InlineData("5\n30,5", 40)]
    [InlineData("6\n41,5", 52)]
    [InlineData("1\n9,5", 15)]
    public void CanAddNonCommaAndCommaNumbers(string value, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(value);

        Assert.Equal(expected, result);
    }
}
