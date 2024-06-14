namespace Learning;

public class ArraysTypes
{
    private void SingleArray()
    {
        int[] myArray = { 4, 3, 1, 4 };
        string[] MyStringArray = { "first", "second" };
    }

    private void IndexInSingleArray()
    {
        int[] myArray = { 4, 3, 1, 4, 7 };

        int[] newArray = myArray[..3]; // 4,3,1
        int[] newArray2 = myArray[2..]; // 1,4,7
    }

    private void DoubleArray()
    {
        int[,] myArray =
        {
            { 2, 4, 5, 6, 3 },
            { 3, 4, 2, 1, 4 },
            { 6, 7, 6, 5, 4 }
        };
    }
    
    // Param - неизвестное число элементов в массиве
    public int ParamOp(string str, params int[] param)
    {
        int res = 0;
        string st = str;

        for (int i = 0; i < param.Length; i++)
        {
            res += param[i];
        }
        
        return res;
    }
    private void ParamObj(params object[] param)
    {
        foreach (var obj in param)
        {
            Console.WriteLine($"{obj.GetType()} = {obj}");
        }
    }
    private void Sum()
    {
        int a = ParamOp("t", 4, 3);
        int b = ParamOp("p", 5, 6, 7, 8);
    }
}