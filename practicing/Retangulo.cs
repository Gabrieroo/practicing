using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace practicing
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt((Largura * 2) + (Altura * 2));
            return diagonal;
        }


    }
}
