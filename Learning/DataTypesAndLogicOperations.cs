namespace Learning;

public class DataTypesAndLogicOperations
{
    private int IncDec()
    {
        int a = 0;

        // увеличить-уменьшить после операции
        a++;
        a--;
        // увеличить-уменьшить до операции
        ++a;
        --a;

        return a;
    }

    private void ComparisonOp()
    {
        /*
        == Равно
        != Не равно
        > Больше
        < Меньше
        >= Больше или равно
        <= Меньше или равно
        */
    }
    
    private void LogicOp()
    {
        /*
         && Сокращённое И
         || Сокращённое ИЛИ
         & И
         | ИЛИ
         ! НЕ
         
         Разница между сокращённым и не сокращённым: не проверяет 2 часть, если 1 ложная
        */
    }

    // naming parameters
    private int NamingOp(int a, int b)
    {
        return a + b;
    }
    private void NamingMain()
    {
        NamingOp(b: 5, a: 9);
    }
    // optional parameters
    private int Sum(int a, int b, bool enable = false)
    {
        return enable ? a + b : 0;
    }

    private struct MyStruct
    {
        public int a;
        public double b;
        public string c;
    }
    // ref можно не присваивать значение,
    // позволяет изменять значимые переменные (структуры и енамы) по ссылке в стеке
    private void RefOp(ref MyStruct myStruct)
    {
        myStruct.a = -5;
        myStruct.b = 3;
        myStruct.c = "data";
    }
    
    // out - обязаны присвоить значение переменной в любом месте где есть out
    // позволяет изменять значимые переменные (структуры и енамы) по ссылке в стеке.
    // При объявлении out мы гарантируем, что где-то переменной будет присвоено значение.
    private void OutOp(out MyStruct myStruct)
    {
        myStruct.a = -5;
        myStruct.b = 3;
        myStruct.c = "data";
    }
    
    private void NullOp()
    {
        string str = null;
        
        // оператор ?? проверяет ссылочные данные на null, иначе дефолтное поведение
        Console.WriteLine(str ?? "нет данных");
        
        // оператор присваивания объедидения с null значениями: ??=
        string st = null;
        st ??= string.Empty;
        Console.WriteLine(st);
    }
    
    // In - позволяет только получить данные, но не изменять их
    struct Point
    {
        public float x;
        public float y;
        public float z;
    }
    // копируем все переменные Point в память для новой переменной
    static void Fo(Point p)
    {
        
    }
    // смотрим данные в памяти по ссылке. Не тратим память на копирование
    // мы можем только смотреть, но не изменять (readonly)
    static void InFo(in Point p)
    {
        var x = p.x;
    }
    private void InMain()
    {
        Point p = new Point();
    }

    private void ConditionalNull(int[] arr)
    {
        // Оператор условного null - ?, если наш массив налл, то дальнейший код не выполняется.
        // Как альтернатива через ?? задаём дефолтное поведение
        Console.WriteLine($"Array sum: {arr?.Sum() ?? 0}");
    }

    private void TernarniyOp(int a, string b)
    {
        // переменная = условие ? вариант при true : вариант при false
        string access = a > 0 && b != "User" ? "Admin" : "Operator";
    }

    private void ArithmeticOp()
    {
        int x = 10;
        int z;
        
        // Операция сложения двух чисел
        z = x + 12; // 22
        
        // Операция вычитания двух чисел
        z = x - 6; // 4
        
        // операция деления двух чисел
        z = x / 5; // 2
        double a = 10;
        double b = 3;
        double c = a / b; // 3.33333333
        double f = x / 4; //результат равен 2
        double g = 10.0 / 4.0; //результат равен 2.5
        
        // Операция получение остатка от целочисленного деления двух чисел
        double x1 = 10.0;
        double z1 = x1 % 4.0; //результат равен 2
        
    }
}