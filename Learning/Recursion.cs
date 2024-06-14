namespace Learning;

public class Recursion
{
    public class Item
    {
        public int Value { get; set; }
        public Item? Child { get; set; }
    }

    public static Item InitItem()
    {
        return new Item()
        {
            Value = 5,
            Child = new Item()
            {
                Value = 10,
                Child = new Item()
                {
                    Value = 2
                }
            }
        };
    }

    public static void Print(Item? item)
    {
        if (item != null)
        {
            Console.WriteLine(item.Value);
            Print(item.Child);
        }
    }
}