using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst4
{
    class Program
    {
        static void Main(string[] args)
        {
            double val;

            Console.WriteLine("Digite a medida de sua glicose:");
            val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (val <= 100)
            {
                Console.WriteLine("Sua Glicose esta normal. " + val.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if (val <= 140)
            {
                Console.WriteLine("Sua Glicose esta Elevado. " + val.ToString("F1", CultureInfo.InvariantCulture));
            }
            else if (val > 140)
            {
                Console.WriteLine("Você esta com Diabetes. " + val.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
