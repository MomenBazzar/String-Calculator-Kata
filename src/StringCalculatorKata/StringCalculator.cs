using System.Text.RegularExpressions;

namespace StringCalculatorKata;
public class StringCalculator
{
    public int Add(string inputNumbers)
    {
        if (string.IsNullOrWhiteSpace(inputNumbers)) return 0;

        var delimiter = "[,\n]";
        if (inputNumbers.StartsWith("//"))
        {
            delimiter = $"{inputNumbers[2]}";
            inputNumbers = inputNumbers.Replace($"//{delimiter}\n", "");
        }

        var numbers = Regex.Split(inputNumbers, delimiter).Select(int.Parse);;
        int sum;
        try
        {
            sum = numbers.Sum();
        }
        catch
        {
            throw new FormatException("Input String is not in a valid format");
        }

        var negatives = numbers.Where(n => n < 0);
        if (negatives.Any())
        {
            throw new FormatException($"Negatives are not allowed: {negatives.ShowElements()}");
        }

        var sumOfBigNumbers = numbers.Where(n => n > 1000).Sum();
        return sum - sumOfBigNumbers;
    }
}