using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle : Ishapes
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public string Getstringname()
        {
            return "Triangle";
        }
    }
}
