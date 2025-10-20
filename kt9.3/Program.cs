using System;

public class Calculator<T> where T : new()
{
    public static T Add(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx + dy;
    }

    public static T Subtract(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx - dy;
    }

    public static T Multiply(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx * dy;
    }

    public T Zero()
    {
        return new T();
    }

    public static T GetZero()
    {
        return new T();
    }
}

class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine($"Calculator<int>:");
        Console.WriteLine($"{a} + {b} = {Calculator<int>.Add(a, b)}");
        Console.WriteLine($"{a} - {b} = {Calculator<int>.Subtract(a, b)}");
        Console.WriteLine($"{a} * {b} = {Calculator<int>.Multiply(a, b)}");
        Console.WriteLine($"Нулевое значение: {new Calculator<int>().Zero()}");

        Console.WriteLine();

        double x = 7.5, y = 2.5;
        Console.WriteLine($"Calculator<double>:");
        Console.WriteLine($"{x} + {y} = {Calculator<double>.Add(x, y)}");
        Console.WriteLine($"{x} - {y} = {Calculator<double>.Subtract(x, y)}");
        Console.WriteLine($"{x} * {y} = {Calculator<double>.Multiply(x, y)}");
        Console.WriteLine($"Нулевое значение: {Calculator<double>.GetZero()}");
    }
}