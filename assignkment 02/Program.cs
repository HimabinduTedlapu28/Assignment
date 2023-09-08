using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignkment_02
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 5, 10, 15, 20, 25 };
            double average = arr.Average();
            int min = arr.Min();
            int max = arr.Max();
            Console.WriteLine("average value of array :");
            Console.WriteLine("min value of array:");
            Console.WriteLine("max value of array:");
            Console.ReadLine();
        }
    }
}



class program
{
    static void Main()
    {
        int[] marks = new int[10];
        for (int i = 0; i<10; i++)
        {
            Console.WriteLine($"Enter mark {i + 1}" );
            if (int.TryParse(Console.ReadLine(),out int mark))
            {
                marks[i] = mark;
            }
            else
            {
                Console.WriteLine("Invalid input");
                i--;
            }
        }
        int total = marks.Sum();
        double average = (double)total / 10;
        int min = marks.Min();
        int max = marks.Max();
        Console.WriteLine($"Total marks: {total}");
        Console.WriteLine($"Average mark: {average:F2}");
        Console.WriteLine($"minimum mark: {min}");
        Console.WriteLine($"maximum mark: { max}");
        Console.WriteLine("Marks in ascending order :");
        int[] ascendingMarks = marks.OrderBy(x => x).ToArray();
        foreach(var mark in ascendingMarks)
        {
            Console.WriteLine($"{mark}");
        }
        Console.WriteLine();
        Console.WriteLine("marks in descending order:");
        int[] descendingmarks = marks.OrderByDescending(x => x).ToArray();
        foreach(var mark in descendingmarks )
        {
            Console.WriteLine($"{mark}");
        }
        Console.WriteLine();
    }
}
