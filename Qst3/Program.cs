using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst3
{
    class Program
    {
        static void Main(string[] args)
        {
            int largfoto, largretrato, altFoto, altretrato;

            Console.WriteLine("Digite a Largura da foto");
            largfoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Altura da foto");
            altFoto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Largura do porta retratos");
            largretrato = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Altura do porta retratos");
            altretrato = int.Parse(Console.ReadLine());

            if (largfoto <= altretrato)
                Console.WriteLine("Sim");

            else
                Console.WriteLine("Não");

            Console.ReadKey();
        }
    }
}
