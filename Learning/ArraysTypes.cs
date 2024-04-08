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
}