using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B;

            Console.WriteLine("Digite o valor de N");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de A");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                if (i % N == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
