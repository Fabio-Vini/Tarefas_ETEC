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
            /*Escreva	 um	 programa	 que	 verifique	 a	 validade	 de	 uma	 senha	 fornecida	
pelo	 usu�rio.	 A	 senha	 v�lida	 �	 o	 n�mero	 1234.	Devem	 ser	impressas	 as	
seguintes	mensagens:	
ACESSO	PERMITIDO	caso	a	senha	seja	v�lida.	
ACESSO	NEGADO	caso	a	senha	seja	inv�lida.*/

            Console.WriteLine("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            if(senha == 1234)
            {
                Console.WriteLine("ACESSO PERMITIDO!");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO, SENHA INV�LIDA");
            }
            Console.ReadKey();
        }
    }
}
