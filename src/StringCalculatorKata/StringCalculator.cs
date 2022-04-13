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
        var numbers = Regex.Split(inputNumbers, delimiter).Select(int.Parse).ToList();
        return numbers.Sum();
    }
}