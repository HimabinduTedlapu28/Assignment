using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace concession_app

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Concession.concessioncalculator calculator = new Concession.concessioncalculator
            {
                Name = name,
                Age = age
            };

            calculator.CalculateConcession();

            Console.ReadKey();

        }
    }
}
    

                    












       

