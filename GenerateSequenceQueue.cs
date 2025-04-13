using System;
using System.Collections.Generic;

public class GenerateSequenceQueue
{
    public static void Run()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(N);

        int count = 0;
        while (count < 50)
        {
            int current = queue.Dequeue();
            Console.Write($"{current} ");
            count++;

            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current + 1);
            queue.Enqueue(current + 2);
        }

        Console.WriteLine();
    }
}
