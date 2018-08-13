using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst1
{
    class Program
    {
        static void Main(string[] args)
        {
                int valinicial, vazbomb, temp, rest;

                Console.WriteLine("Digite a quantedade de veno no frasco:");
                valinicial = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de veneno " + valinicial);

                Console.WriteLine("Digite a vasão da bomba em segundos:");
                temp = int.Parse(Console.ReadLine());
                Console.WriteLine("Tempo de Vazão por segundo " + temp);

                Console.WriteLine("Digite o tempo de utilização:");
                vazbomb = int.Parse(Console.ReadLine());
                Console.WriteLine("Tempo de utilização " + vazbomb);

                rest = valinicial - temp * vazbomb;

                if (rest >= 0)
                    Console.WriteLine("A quantidade de veneno restante é: " + rest);

                else
                    Console.WriteLine("nao eh possivel:");

                Console.ReadKey();
        }
    }
}
