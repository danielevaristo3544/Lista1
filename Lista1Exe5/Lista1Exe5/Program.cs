using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;    //programa dedicado a fazer a média aritmética de 4 números inteiros
            int b;
            int c;
            int d;
            int m;

            Console.WriteLine("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());  

            Console.WriteLine("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número: ");
            d = int.Parse(Console.ReadLine());

            m = (a + b + c + d) / 4;

            Console.WriteLine("A média aritmética dos números é: ");
            Console.WriteLine(m);

        }
    }
}
