using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            int a;

            Console.WriteLine("Digite o valor do diãmetro do circulo:");
            d = int.Parse(Console.ReadLine());

            a = (int)(Math.PI * Math.Pow(( d / 2), 2));

            Console.WriteLine("A área do circulo é: ");
            Console.WriteLine(a);


        }
    }
}