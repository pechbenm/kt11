using System;
public class LinkedList<T> where T : class
{
    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;

    public void Add(T item)
    {
        var newNode = new Node(item);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public bool Remove(T item)
    {
        if (head == null) return false;

        if (head.Data.Equals(item))
        {
            head = head.Next;
            return true;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data.Equals(item))
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public bool Contains(T item)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }
}
public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var stringList = new LinkedList<string>();
        stringList.Add("Hello");
        stringList.Add("World");
        Console.WriteLine(stringList.Contains("Hello")); 
        stringList.Remove("Hello");
        Console.WriteLine(stringList.Contains("Hello")); 

        var personList = new LinkedList<Person>();
        personList.Add(new Person("Alice"));
        personList.Add(new Person("Bob"));
        Console.WriteLine(personList.Contains(new Person("Alice"))); 

        var bookList = new LinkedList<Book>();
        bookList.Add(new Book("1984"));
        bookList.Add(new Book("Brave New World"));
        Console.WriteLine(bookList.Contains(new Book("1984"))); 
    }
}
