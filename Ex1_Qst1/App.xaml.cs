using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Ex1_Qst1
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    static void Main(string[] args)
    {
        int valinicial, vazbomb, temp, rest;

        Console.WriteLine("Digite a quantedade de veno no frasco:");
        valinicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade de veneno" + valinicial);

        Console.WriteLine("Digite a vasão da bomba em segundos:");
        vazbomb = int.Parse(Console.ReadLine());
        Console.WriteLine("Tempo de Vazão por segundo" + vazbomb);

        Console.WriteLine("Digite o tempo de utilização:");
        temp = int.Parse(Console.ReadLine());
        Console.WriteLine("Tempo de utilização" + temp);

        rest = temp * vazbomb + valinicial;

        if (rest <= valinicial)
            Console.WriteLine("A quantidade de veneno restante é:");

        else
            Console.WriteLine("nao eh possivel:");

        Console.ReadKey();
    }
}
