using System;

public class Pair<T, U> where T : class where U : class
{
    public T First { get; set; }
    public U Second { get; set; }

    public Pair(T first, U second)
    {
        First = first;
        Second = second;
    }
    public void Swap()
    {
        T temp = First;
        First = Second as T;
        Second = temp as U;
    }

    public override string ToString()
    {
        return $"({First?.ToString() ?? "null"}, {Second?.ToString() ?? "null"})";
    }
}

class Program
{
    static void Main()
    {
        Pair<string, string> pair = new Pair<string, string>("Hello", "World");
        Console.WriteLine($"До обмена: {pair}");
        pair.Swap();
        Console.WriteLine($"После обмена: {pair}");
    }
}