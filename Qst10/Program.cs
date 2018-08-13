using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double nota1, nota2, nota3, result;

            Console.WriteLine("Digite quantos alunos a na turma: ");
            N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite o valor das tres notas de cada aluno: ");
            string[] vet = Console.ReadLine().Split(' ');

            nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                result = nota1 + nota2 + nota3;
                Console.WriteLine("A nota final e: " + result.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
