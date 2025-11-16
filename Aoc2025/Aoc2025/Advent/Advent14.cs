using AdventUtility;

namespace Aoc2025.Advent;

internal class Advent14
{
    private static int[] _input = [];

    internal static void Run(bool test, RunFlag flag, int val)
    {
        _input = Utility.ReadInput(test, val).ConvertTo<int>();

        if (flag is RunFlag.All or RunFlag.Part1)
            Part1();

        if (flag is RunFlag.All or RunFlag.Part2)
            Part2();
    }

    private static void Part1()
    {

    }

    private static void Part2()
    {

    }
}
