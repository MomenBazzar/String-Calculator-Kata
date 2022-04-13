using Xunit;
namespace StringCalculatorKata.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void AddWithEmptyString_ReturnsZero()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void AddStringWithOneNumber_ReturnsTheNumber()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("5");

        Assert.Equal(5, result);
    }
    
    [Fact]
    public void AddStringWithTwoNumbers_ReturnsSum()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("1,2");

        Assert.Equal(3, result);
    }
}