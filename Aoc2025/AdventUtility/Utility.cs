namespace AdventUtility;

public static class Utility
{
    public static string ReadInput(bool test, int advent)
    {
        string adv = (advent < 10 ? "0" : "") + advent.ToString();

        string path = Path.Combine(
            Path.Combine(AppContext.BaseDirectory, test ? "Test" : "Input"),
            $"input{adv}.txt"
        );
        return File.ReadAllText(path);
    }

    public static T[] ConvertTo<T>(this string input, char separator = '\n')
    {
        string[] x = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        return x.Select(p => (T)Convert.ChangeType(p, typeof(T))).ToArray();
    }
}
