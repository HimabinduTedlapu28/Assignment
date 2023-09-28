using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern.shapes;

namespace FactoryPattern
{
    class Program
    {
        private static object shapesFactory;

        static void Main(string[] args)
        {
            Console.WriteLine("enter shape name :");
            string shapename = Console.ReadLine();

            Ishapes cc = shapesFactory.GetShapes(shapename);


            if (cc != null)
            {
                Console.WriteLine("shapename : {0}", cc.Getshapename());
                Console.WriteLine("shapelength : {0}", cc.Getshapelength());
                Console.WriteLine("shapebreadth : {0}", cc.Getshapebredth());
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }

        }
    }
}
