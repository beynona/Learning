namespace Learning;

public class OverloadMethods
{
    private int Sum(int a, int b)
    {
        return a + b;
    }

    private int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    
    private double Sum(double a, double b, double c)
    {
        return a + b + c;
    }
}