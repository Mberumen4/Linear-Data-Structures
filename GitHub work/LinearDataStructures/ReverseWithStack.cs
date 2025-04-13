using System;
using System.Collections.Generic;

public class ReverseWithStack
{
    public static void Run()
    {
        Console.Write("Enter number of integers: ");
        int n = int.Parse(Console.ReadLine());
        Stack<int> numbers = new Stack<int>();

        Console.WriteLine("Enter integers:");
        for (int i = 0; i < n; i++)
        {
            numbers.Push(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Reversed order:");
        while (numbers.Count > 0)
        {
            Console.WriteLine(numbers.Pop());
        }
    }
}
