using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Exe2
{ 
    internal class Program
    {
            static void Main(string[] args)
            {       
        
             int l;  // programa dedicado a calcular a area do quadrado apenas com o valor de uma das arestas
             int a;

             Console.WriteLine("Informe o valor da aresta do quadrado: ");
             l = int.Parse(Console.ReadLine());

             a = l * l;

             Console.WriteLine("A area do quadrado é: ");
             Console.WriteLine(a);
            }
    }
}
    
       