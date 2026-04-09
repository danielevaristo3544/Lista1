using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;     //programa dedicado a calcular a área de um retângulo com a entrada de valores de base e altura
            int h;
            int a;

            Console.WriteLine("Digite a base do retângulo: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            h = int.Parse(Console.ReadLine());

            a = b * h;

            Console.WriteLine("A área do retângulo é: ");
            Console.WriteLine(a);
        }
    }
}