using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, quad;

            num = 1;

            while (num != 0)
            {
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    quad = num * num;
                    Console.WriteLine(quad);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            Console.ReadKey();
        }
    }
}
