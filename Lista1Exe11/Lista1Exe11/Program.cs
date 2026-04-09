using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe11
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // calculando um numero x pelo expoente y

            int x;
            int y;
         
            Console.WriteLine("Digite um número inteiro x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente y:");
            y = int.Parse(Console.ReadLine());

           
            Console.WriteLine("O resultado de x elevado a y é:" + Math.Pow(x , y));

        }
    }
} 