using System;
using System.Collections.Generic;

public delegate double Function(double x);
class Program
{
    public static double SimpsonMethod(Function f, double b, double a, int n)
    {
        double sum = 0;
        double h = (b - a) / n;
        for (int i = 0; i < n; i++)
            sum += (f(a) + f(b) + 4 * (f(a + h) + f(a + (i - 1) * h)) + 2 * (f(a + 2 * h) + f(a + (i - 2) * h))) * h / 3;
        return sum;
    }

    public static double SimpsonMethod_For_x(double x)
    {
        return x;
    }

    static void Main(string[] args)
    {
        Function sim = new Function(SimpsonMethod_For_x);
        double a, b;
        int n;
        Console.Write("The lower bound of integration. a=");
        a = Double.Parse(Console.ReadLine());
        Console.Write("The upper bound of integration. b=");
        b = Double.Parse(Console.ReadLine());
        Console.Write("Number of segments. n=");
        n = int.Parse(Console.ReadLine());
        Console.Write("Integral = {0}", SimpsonMethod(sim, b, a, n));
        Console.ReadKey();
    }
}
