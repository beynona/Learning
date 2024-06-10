namespace Practic;

public static class ArrayPractice
{
    public static void Insert(ref int[] array, int value, int index)
    {
        int[] newArray = new int[array.Length + 1];

        newArray[index] = value;

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = index; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        array = newArray;
    }

    public static void AddFirst(ref int[] array, int value)
    {
        Insert(ref array, value, 0);
    }

}