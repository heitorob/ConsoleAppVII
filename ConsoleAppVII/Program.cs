using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleAppVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Jailson");
            }

            Console.Write("Número de Jailsons: " + numero);
            Console.ReadKey();
        }
    }
}
