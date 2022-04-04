using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade_2025
{
    internal class idade_25
    {
        static void Main(string[] args)
        {
        Start:
            // Variáveis
            int seg, min, m_s, tot_seg;

            Console.WriteLine("*** Minutos e Segundos para Segundos\n");


            // Entrada de dados
            Console.Write("Minutos: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("\nSegundos: ");
            seg = int.Parse(Console.ReadLine());
            if (seg > 60)
            {
                Console.WriteLine("\nValor Inválido para segundos. Insira um valor entre 1 e 60");
                goto Start;
            }

            // Processamento
            m_s = (min * 60);
            tot_seg = (seg + m_s);

            // Saída
            Console.WriteLine("\nTotal de segundos: {0}", tot_seg);

            Console.Write("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
