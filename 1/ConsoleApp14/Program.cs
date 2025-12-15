using System;
using System.Collections.Generic;
using System.Diagnostics;


class Program
{
    public static void Swap<T>(ref T x, ref T y) where T : struct
    {
        T temp = x;
        x = y;
        y = temp;
    }
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");

        double x = 1.5;
        double y = 2.5;
        Swap(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}"); 

        bool isTrue = true;
        bool isFalse = false;
        Swap(ref isTrue, ref isFalse);
        Console.WriteLine($"isTrue: {isTrue}, isFalse: {isFalse}"); 
    }
}

