using System;

public class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();
        List<string> myList = new List<string>();

        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        foreach(var item in myList)
        {
            Console.WriteLine(myList);
        }

        Console.WriteLine("Hello Sandbox World!");
    }
}