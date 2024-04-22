using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meias = 0, inteiras = 0;
            double vmeias = 0, vinteiras = 0;

            for (int lote = 1; lote <= 30; lote++)
            {
                if (lote <= 10)
                {
                    Console.Write("- Lote I -\nIngresso nº " + lote + "\nA entrada é inteira(I) ou meia(M)? : ");
                    string ingresso = Console.ReadLine().ToUpper().Substring(0, 1);
                    switch (ingresso)
                    {
                        case "M":
                            meias ++;
                            vmeias += 50;
                            Console.Clear();
                            break;

                        case "I":
                            inteiras ++;
                            vinteiras += 100;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Código inválido!! Tente novamente!!");
                            break;
                    }
                }
                else if (lote <= 20)
                {
                    Console.Write("- Lote II -\nIngresso nº " + lote + "\nA entrada é inteira(I) ou meia(M)? : ");
                    string ingresso = Console.ReadLine().ToUpper().Substring(0, 1);
                    switch (ingresso)
                    {
                        case "M":
                            meias ++;
                            vmeias += 75;
                            Console.Clear();
                            break;

                        case "I":
                            inteiras++;
                            vinteiras += 150;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Código inválido!! Tente novamente!!");
                            break;
                    }
                }
                else if (lote <= 30)
                {
                    Console.Write("- Lote III -\nIngresso nº " + lote + "\nA entrada é inteira(I) ou meia(M)? : ");
                    string ingresso = Console.ReadLine().ToUpper().Substring(0, 1);
                    switch (ingresso)
                    {
                        case "M":
                            meias ++;
                            vmeias += 100;
                            Console.Clear();
                            break;

                        case "I":
                            inteiras ++;
                            vinteiras += 200;
                            Console.Clear();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Código inválido!! Tente novamente!!");
                            break;
                    }
                }
            }
            Console.WriteLine("Total dos ingressos: " + (vmeias + vinteiras).ToString("C"));
            Console.WriteLine("Quantidade de inteiras: " + inteiras);
            Console.WriteLine("Quantidade de meias-entradas: " + meias);

            Console.ReadKey();
        }
    }
}
