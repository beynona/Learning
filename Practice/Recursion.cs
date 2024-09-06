using System.Runtime.InteropServices.JavaScript;

namespace Practic;

public static class Recursion
{
    public static int SumNumbers(int value)
    {
        if (value < 10)
        {
            return value;
        }

        var number = value % 10;
        return SumNumbers(value / 10) + number;
    }
}