using System;
using System.CodeDom;
using System.Linq;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        var list = input.GroupBy(name => name);
        foreach (var word in list)
        {
            Console.WriteLine(string.Join(" ",word));
        }
    }
}

