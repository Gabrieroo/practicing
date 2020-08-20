using System;
using System.Globalization;
namespace practicing
{
    class Program
    {

       

        
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA; " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO; " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL; " + ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

            /**
           Console.WriteLine("Entre os dados do produto:");
           Produto index = new Produto();
           Console.WriteLine("Nome: ");
           index.Nome = Console.ReadLine();
           Console.WriteLine("Preco: ");
           index.Preco = Double.Parse(Console.ReadLine());
           Console.WriteLine("Quantidade: ");
           index.Quantidade = int.Parse(Console.ReadLine());
           Console.WriteLine("Dados do produto: " + index);
           Console.WriteLine("Comandos");
           Console.WriteLine("1 - Adicionar quantidade produtos.");
           Console.WriteLine("2 - Remover quantidade produtos.");
           Console.WriteLine("3 - Total em estoque.");
           Console.WriteLine("4 - Sair.");
           int qte, i = 0;
           while (i != 5){
               if (i == 0)
               {
                   Console.Write("Digite o comando: ");
                   i = int.Parse(Console.ReadLine());
               }
               else if(i == 1)
               {
                   Console.WriteLine("Digite o numero de produtos a ser adicionado");
                   qte = int.Parse(Console.ReadLine());
                   index.AdicionarQuantidade(qte);
                   i = 0;
               }
               else if(i == 2)
               {
                   Console.WriteLine("Digite o numero de produtos a ser removido");
                   qte = int.Parse(Console.ReadLine());
                   index.RemoverQuantidade(qte);
                   i = 0;
               }
               else if(i == 3)
               {
                   Console.WriteLine("dados " + index);
                   i = 0;
               }else if(i == 4)
               {
                   i = 5;
               }
               else if(i < 0 || i > 4)
               {
                   Console.WriteLine("ERROR!!! CODIGO NAO EXISTE!!!");
                   i = 0;
               }
           }
           **/

            /**
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite a medida do primeiro triangulo");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse  (Console.ReadLine());
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
           
            **/

        }

    }
}
