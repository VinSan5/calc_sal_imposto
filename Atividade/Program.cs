using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("* * * Calculadora Hipotenusa * * *");

            // Entrada de dados
            Console.Write("\nDigite o valor do cateto oposto: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\nDigite o valor do cateto adjacente: ");
            y = double.Parse(Console.ReadLine());

            // Processamento
            z = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));

            // Saída
            Console.Write("\n{0}", z);

            Console.WriteLine("\nPressiona qualquer tecla para SAIR");
            Console.ReadKey();
            
        }
    }
}
