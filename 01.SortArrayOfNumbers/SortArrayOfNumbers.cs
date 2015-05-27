using System;
using System.Linq;


class SortArrayOfNumbers
{
    static void Main()
    {
        double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Array.Sort(arr);
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
    }
}

