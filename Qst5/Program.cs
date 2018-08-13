using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst5
{
    class Program
    {
        static void Main(string[] args)
        {
            double val1, val2, val3, result;

            Console.WriteLine("Digite o valor do primeniro lançamento:");
            val1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do Segundo lançamento:");
            val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do Terceiro lançamento:");
            val3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(val1 > val2)
            {
                Console.WriteLine("O Primeiro lançamento e " + val1.ToString("F2", CultureInfo.InvariantCulture));
            }else if(val2 > val1)
            {
                Console.WriteLine("O Segundo lançamento e " + val2.ToString("F2", CultureInfo.InvariantCulture));
            }else
                Console.WriteLine("O Terçeiro lançamento e " + val3.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
