using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace Lista1Exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cot;
            int dol;
            int valor; 
            
            Console.WriteLine("Digite a cotação do dolar:");
            cot = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em dolar:");
            dol = int.Parse(Console.ReadLine());

            valor = cot * dol;

            Console.WriteLine("O valor em reais é: " + valor);
            
        }
    }
}   
