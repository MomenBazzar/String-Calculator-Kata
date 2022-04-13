using System.Text.RegularExpressions;

namespace StringCalculatorKata;
public class StringCalculator
{
    public int Add(string inputNumbers)
    {
        if (string.IsNullOrWhiteSpace(inputNumbers)) return 0;
        
        var numbers = Regex.Split(inputNumbers, "[,\n]").Select(int.Parse).ToList();
        return numbers.Sum();
    }
}