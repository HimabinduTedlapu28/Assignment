using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern.shapes;

namespace FactoryPattern
{
    
        public static Ishapes Getshapes(string shapename)
        {
            Ishapes Icc = null;
            if (shapename == "Triangle")
            {
                Icc = new Triangle();
            }
            else if (shapename == "Rectangle")
            {
                Icc = new Rectangle();
            }
            else if (shapename == "circle")
            {
                Icc = new circle();
            }
            return Icc;







        }

    
}
