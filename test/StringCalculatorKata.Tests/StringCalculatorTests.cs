using Xunit;

namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("5", 5)]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3,4", 10)]
    [InlineData("1,2\n3", 6)]
    [InlineData("//:\n1:2:3", 6)]
    public void AddGivenValidInput_ReturnsSum(string inputNumbers, int expectedAnswer)
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add(inputNumbers);

        Assert.Equal(expectedAnswer, result);
    }
}