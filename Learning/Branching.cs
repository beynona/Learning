namespace Learning;

public class Branching
{
    private void IfElseBranch(bool trust)
    {
        if (trust)
        {
            //condition if true
        }
        else
        {
            //condition if false
        }
    }
    
    private void WhileBranch(bool trust = false)
    {
        // Проверяет while, если true, то начинает выполнять
        while (trust)
        {
            // code
        }
    }
    
    private void DoWhileBranch(bool trust = false)
    {
        // Выполняет действие. Проверяет while, если true, то повторить. Выполняется минимум 1 раз
        do
        {
            // code
        } while (trust);
    }

    private void ForBranch(int col = 5)
    {
        // (счётчик; условие; итератор)
        for (int i = 0; i < col; i++)
        {
            Console.WriteLine($"Hello {i}");
        }
    }

    private void BreakAndContinueBranch(int col = 5)
    {
        // (счётчик; условие; итератор)
        for (int i = 0; i < col; i++)
        {
            Console.WriteLine($"Hello {i}");

            if (i == 2)
            {
                //пропустить итерацию и перейти к следующей
                continue;
            }

            if (i >= 5)
            {
                //Прерывает цикл
                break;
            }
        }
    }

    private enum SwitchNumber
    {
        First,
        Second
    };
    private void SwitchOp(SwitchNumber switchNumber)
    {
        switch (switchNumber)
        {
            case SwitchNumber.First:
                Console.WriteLine("First");
                break;
            case SwitchNumber.Second:
                Console.WriteLine("Second");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
    
    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
    private void DoOperation(double x, double y, Operation op)
    {
        double result = op switch
        {
            Operation.Add => x + y,
            Operation.Subtract => x - y,
            Operation.Multiply => x * y,
            Operation.Divide => x / y,
            _ => throw new ArgumentOutOfRangeException(nameof(op), op, null)
        };
        Console.WriteLine(result);
    }
  
}