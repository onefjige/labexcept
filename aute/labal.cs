using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int i = 3;
        
        // Filter out the number that is equal to 'i'
        IEnumerable<int> filteredNumbers = numbers.Where(x => x != i);

        foreach (int number in filteredNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
