using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CategorizeNumFindMinMaxAverage
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<double> roundNum=new List<double>();
        List<double> floatNum=new List<double>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%1 != 0)
            {
                floatNum.Add(numbers[i]);
            }
            else
            {
                roundNum.Add(numbers[i]);
            }
         }
        Console.Write("[");
        floatNum.ForEach(a => Console.Write(a + " "));
        Console.Write("] -> ");
        Console.Write("min: {0}, ", floatNum.Min());
        Console.Write("max: {0}, ", floatNum.Max());
        Console.Write("sum: {0}, ", floatNum.Sum());
        Console.Write("avg: {0:F2}", floatNum.Average());
        Console.WriteLine();
        Console.Write("[");
        roundNum.ForEach(b=>Console.Write(b+" "));
        Console.Write("] -> ");
        Console.Write("min: {0}, ",roundNum.Min());
        Console.Write("max: {0}, ", roundNum.Max());
        Console.Write("sum: {0}, ", roundNum.Sum());
        Console.WriteLine("avg: {0:F2}", roundNum.Average());
    }
}

