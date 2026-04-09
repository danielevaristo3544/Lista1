using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;  //programa para calcular a área do quadrado a partir da medida de sua diagonal
            int a;

            Console.WriteLine("Digite a medida da diagonal do quadrado: ");
            d = int.Parse(Console.ReadLine());

            a = (d * d) / 2;    

            Console.WriteLine("A área do quadrado é: ");
            Console.WriteLine(a);
        }
    }
}   