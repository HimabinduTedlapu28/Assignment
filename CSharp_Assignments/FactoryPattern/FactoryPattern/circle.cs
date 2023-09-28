using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    
        class circle : Ishapes
        {
        public double Radius { get; set; }

        public circle(double radius)
        {
            Radius = radius;
        }

        public circle()
        {
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        }


   
}
    

