using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
public interface IPrintable<T> where T : class
{
    void Print();
}

public class Student : IPrintable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public void Print()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}
public class Vector : IPrintable<Vector>
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public void Print()
    {
        Console.WriteLine($"Vector: X = {X}, Y = {Y}, Z = {Z}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student { Name = "Alice", Age = 20, Grade = 4.5 };
        student.Print();

        Vector vector = new Vector { X = 1.0, Y = 2.0, Z = 3.0 };
        vector.Print();
        Console.ReadLine();
    }
}


