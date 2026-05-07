using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imc_genêro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Você se identifica com o genêro feminino ou masculino: ");
            string s = Console.ReadLine();

            Console.Write("Qual é seu peso: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Qual é a sua altura: ");
            double a = double.Parse(Console.ReadLine());

            double r = p / (a * a);

            if (s == "masculino")
            {
                if (r < 20)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else
                {
                    if (r < 25)
                    {
                        Console.WriteLine("Peso ideal");
                    }
                    else
                    {
                        Console.WriteLine("Acima do peso");
                    }

                }
            }

            if (s == "feminino")
            {
                if (r < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else
                {
                    if (r < 24)
                    {
                        Console.WriteLine("Peso ideal");
                    }
                    else
                    {
                        Console.WriteLine("Acima do peso");
                    }

                }
            }

        }
    }
}
