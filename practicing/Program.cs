using System;

namespace practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite a medida do primeiro triangulo");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a medida do segundo triangulo");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaY = y.Area();
            double areaX = x.Area();

            if(areaX > areaY)
            {
                Console.WriteLine("O triangulo X = " + areaX +" e maior que o triangulo y " + areaY);
            }
            else
            {
                Console.WriteLine("O triangulo Y = " + areaY + " e maior que o triangulo X " + areaX);
            }



        }
    }
}
