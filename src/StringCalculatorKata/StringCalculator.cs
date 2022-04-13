namespace StringCalculatorKata;
public class StringCalculator
{
    public int Add(string inputNumbers)
    {
        if (string.IsNullOrWhiteSpace(inputNumbers)) return 0;
        
        var numbers = inputNumbers.Split(',').Select(int.Parse).ToList();
        return numbers.Sum();
    }
}