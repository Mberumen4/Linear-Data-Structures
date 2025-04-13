using System;
using System.Collections.Generic;

public class CountOccurrences
{
    public static void Run()
    {
        int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

        foreach (var kvp in counts)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
        }
    }
}
