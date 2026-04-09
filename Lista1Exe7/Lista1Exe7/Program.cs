using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;                   //programa para converter milhas nauticas em quilômetros
            double km;

            Console.WriteLine("Digite o total de milhas:");
            m = int.Parse(Console.ReadLine());

            km = ((m * 1852) / 1000) ;           //  1 milha nautica é igual a 1.852 metros    

            Console.WriteLine("Total em quilômetros:");
           
            Console.WriteLine(km);
        }

    }
}           


