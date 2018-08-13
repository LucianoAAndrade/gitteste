using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num1, soma = 0;

            Console.WriteLine("Digite o primeiro valor: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo valor: ");
            num1 = int.Parse(Console.ReadLine());

            for(int i = num; i < num1; i++)
            {
                if(i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.Write(soma);
            Console.ReadKey();
        }
    }
}
