
namespace Practic;

public abstract class Program
{
    public static void Main(string[] args)
    {
        //array insert
        int[] arr =  { 1, 2, 3, 5 };
        ArrayPractice.Insert(ref arr, 4,3);
        foreach (var fore in arr)
        {
            Console.Write($"{fore} ");
        }
        Console.WriteLine();
        //array insert to the first
        ArrayPractice.AddFirst(ref arr, 0);
        foreach (var fore in arr)
        {
            Console.Write($"{fore} ");
        }
    }
}