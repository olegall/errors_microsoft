// CS8132.cs (5,9)
using System;

class Program
{
    static void F(object x, object y, object? z)
    {
        (object? a, object? b) = (x, y, z = 3);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(z);
    }

    static void F(object x, object y, object? z)
    {
        (object? a, object? b, object _) = (x, y, z = 3);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(z);
    }
}