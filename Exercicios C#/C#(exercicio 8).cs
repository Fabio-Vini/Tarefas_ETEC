using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Escreva um programa para ler 2 valores
         (considere	 que n�o ser�o informados valores iguais)	
         e escrever    o maior   deles*/

            inicio:
            Console.WriteLine("");
            Console.WriteLine("Digite 2 valores");

            Console.Write("1� valor: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("2� valor: ");
            double y = double.Parse(Console.ReadLine());

            if(x == y)
            {
                Console.WriteLine("N�o digite valores iguais!");
                goto inicio;
            }
            else if(x > y)
            {
                Console.WriteLine("O 1� valor � maior");
            }
            else
            {
                Console.WriteLine("O 2� valor � maior");
            }
            Console.ReadKey();
        }
    }
}
