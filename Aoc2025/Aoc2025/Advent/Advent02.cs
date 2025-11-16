using AdventUtility;

namespace Aoc2025.Advent;

internal class Advent02
{
    private static string[] _input = [];

    internal static void Run(bool test, RunFlag flag, int val)
    {
        _input = Utility.ReadInput(test, val).ConvertTo<string>();

        if (flag is RunFlag.All or RunFlag.Part1)
            Part1();

        if (flag is RunFlag.All or RunFlag.Part2)
            Part2();
    }

    private static void Part1()
    {
        Console.WriteLine(_input[0]);
    }

    private static void Part2()
    {

    }
}
