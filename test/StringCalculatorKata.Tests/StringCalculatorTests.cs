using Xunit;
using System;
using FluentAssertions;
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

    [Theory]
    [InlineData("1,222,r,r")]
    [InlineData("1,,,2")]
    [InlineData("4,3,\n5")]
    [InlineData("7,6\n,3,2\n")]
    public void AddGivenInvalidInput_ThrowsFormatException(string inputNumbers)
    {
        StringCalculator sut = new StringCalculator();

        var result = () => sut.Add(inputNumbers);

        result.Should().Throw<FormatException>()
              .WithMessage("Input String is not in a valid format");
    }
}