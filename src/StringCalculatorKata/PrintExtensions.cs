namespace StringCalculatorKata;
public static class ListExtensions
{
    public static string ShowElements(this IEnumerable<int> collection)
    {
        var result = string.Join(" ", collection);
        return result;
    }
}
