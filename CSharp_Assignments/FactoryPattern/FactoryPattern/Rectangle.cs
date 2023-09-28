﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    
        class Rectangle : Ishapes
        {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public string Getshapename()
            {
                return "Rectangle";
            }
        }
    
}
