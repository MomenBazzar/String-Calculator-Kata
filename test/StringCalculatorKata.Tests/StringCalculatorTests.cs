using Xunit;
using System;
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
    public void AddWithOneNumber_ReturnsTheNumber()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("5");

        Assert.Equal(5, result);
    }

    [Fact]
    public void AddWithTwoNumbers_ReturnsSumOfNumbers()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("1,2");

        Assert.Equal(3, result);
    }

    [Fact]
    public void AddWithUnknownAmountOfNumbers_ReturnsSumOfNumbers()
    {
        StringCalculator sut = new StringCalculator();

        int result = sut.Add("1,2,3,4");

        Assert.Equal(10, result);
    }
}