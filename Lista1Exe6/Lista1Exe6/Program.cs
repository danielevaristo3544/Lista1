using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;    // programa dedicado a fazer a media geométrica de dois valores recebidos
            double b;
            double s;
            double m;

            Console.WriteLine("Informe o primeiro valor:");
            Console.ReadLine();

            Console.WriteLine("Informe o segundo valor:");
            Console.ReadLine();
            
            s = a * b;

            m = Math.Sqrt(s);

            Console.WriteLine("A média geométrica é:");
            Console.WriteLine(m);


        }
    }
}