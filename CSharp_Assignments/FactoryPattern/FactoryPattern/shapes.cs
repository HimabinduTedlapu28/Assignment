using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class shapes
    {
        public interface Ishapes
        {
            string Getshapename();
            int Getshapelength();
            int Getshapebreadth();
            double Getarea();
        }
    }
}
