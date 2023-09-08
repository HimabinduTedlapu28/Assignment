using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if(num1 == num2)
        {
            Console.WriteLine("The Numbers are equal");
        }
        else
        {
            Console.WriteLine("The Numbers are not equal");
            Console.ReadLine();
        }



        }
}

namespace assignment01
{
    class class1
    {
        static void Main()
        {
            Console.WriteLine(" Enter a Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the SEcond NUmber :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num1 + num2", num1, num2);
            Console.WriteLine("num1 - num2", num1, num2);
            Console.WriteLine("num1 * num2", num1, num2);
            Console.WriteLine("num1 / num2", num1, num2);



        }

    }
}

    class program
    {
    public static void calc()
     {
        int num;
        Console.Write("\n\n");
        Console.WriteLine("Enter the number :");

        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)
            Console.WriteLine("{0} is a Positive Number. \n", num);
        else
            Console.WriteLine("It is a Negative Number. \n", num);
        Console.ReadLine();

     }
   }





