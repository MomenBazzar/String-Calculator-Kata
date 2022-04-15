namespace StringCalculatorKata;
public static class ListExtensions
{
    public static string ShowElements(this IEnumerable<int> collection)
    {
        var result = "";
        foreach (var num in collection)
        {
            result += $"{num} ";
        }
        return result;
    }
}
