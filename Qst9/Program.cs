using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst9
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempdura, tempjog, temprest;
            int N;

            Console.WriteLine("Digite a quantidade da bateria: ");
            tempdura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite quantas vezes ira jogar: ");
            N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            temprest = tempdura;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o tempo que pretende jogar: ");
                tempjog = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                temprest = temprest - tempjog;
                if (temprest < 0.0)
                {
                    Console.WriteLine("recarregar");
                }
                else
                {
                    Console.WriteLine(temprest);
                }
            }
            Console.ReadKey();
        }
    }
}
