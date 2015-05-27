using System;
using System.Collections.Generic;
using System.Linq;

internal class SubsetSums
{
    private static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> noDuplicates = numbers.ToList();
        noDuplicates = noDuplicates.Distinct().ToList();

        var subsets = from m in Enumerable.Range(0, 1 << noDuplicates.Count)
            select
                from i in Enumerable.Range(0, noDuplicates.Count)
                where (m & (1 << i)) != 0
                select noDuplicates[i];
        bool noOutPut = true;
        
        foreach (var item in subsets)
        {
            int sumTemp = 0;
            foreach (var number in item)
            {
                sumTemp += Convert.ToInt32(number);
            }
            if (sumTemp == sum && item.Count() > 0)
            {
                Console.WriteLine(string.Join("+",item)+" = {0}",sum);
                noOutPut = false;
            }
        }
        if(noOutPut)
            Console.WriteLine("No matching subsets.");
    }
}
