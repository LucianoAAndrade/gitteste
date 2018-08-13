using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Qst2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, soma;

            string[] vet = Console.ReadLine().Split(' ');

            nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            soma = nota1 + nota2 + nota3;

            if (soma >= 60.00)
                Console.WriteLine("A nota do aluno e: " + soma.ToString("F2", CultureInfo.InvariantCulture) + " Aprovado");
            else
                Console.WriteLine("Aluno esta de Dependencia");

            Console.ReadKey();
        }
    }
}
