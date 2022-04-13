namespace StringCalculatorKata;
public class StringCalculator
{
    public int Add(string inputNumbers)
    {
        if (inputNumbers.Equals("")) return 0;
        
        if (!inputNumbers.Contains(','))
            return int.Parse(inputNumbers);

        string[] numbers = inputNumbers.Split(',');

        return int.Parse(numbers[0]) + int.Parse(numbers[1]);
    }
}