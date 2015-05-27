using System;
using System.Linq;


class SortArrayOfNumUsingSelectionSort
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    var tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
                }
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]+" ");
        }
    }
}

