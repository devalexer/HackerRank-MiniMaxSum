using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(s => long.Parse(s));

        var min = input.Sum() - input.Max();
        var max = input.Sum() - input.Min();
        Console.WriteLine($"{min} {max}");
    }
}