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
        /*Escreva um	programa para	ler o ano de nascimento de	
         uma	pessoa e escrever uma mensagem que diga	se ela	poder� ou 
         n�o votar este ano (n�o	�	necess�rio	considerar	o	m�s
         em que ela nasceu).*/
         
            Console.WriteLine("Digite o ano de seu nascimento, confira se pode votar ou n�o: ");

            int ano = int.Parse(Console.ReadLine());

            if(ano <= 2004)
            {
                Console.WriteLine("Voc� pode votar!");
            }
            else
            {
                Console.WriteLine("N�o tem idade suficiente!");
            }
            Console.ReadKey();
        }
    }
}
