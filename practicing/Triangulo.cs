using System;
using System.Collections.Generic;
using System.Text;

namespace practicing
{
    class Triangulo
    {
        public double A,B,C;
        
        public double Area()
        {
            double index = (A + B + C) / 2.0;
            return Math.Sqrt(index * (index - A) * (index - B) * (index - C));
        }
       
    }
}
