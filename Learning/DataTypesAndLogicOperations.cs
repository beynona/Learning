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

    private void NullOp()
    {
        string str = null;
        
        // оператор ?? проверяет ссылочные данные на null, иначе дефолтное поведение
        Console.WriteLine(str ?? "нет данных");
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