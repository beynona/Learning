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

        return SumNumbers(value / 10) + value % 10;
    }
}