using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_salario
{
    internal class CALC_SALARIO
    {
        static void Main(string[] args)
        {/* Programa: Cálculo de Salário de Colaborador
          * Problema: Permitir a entrada de dados como valor do salário mínimo, carga horária de trabalho e imposto sobre o salário para o retorno do salário liquido do colaborador
          * Data....: 04/04/2022
          * Autor: Vinícius Santos 11221103398
          */


            // Declaração de variáveis
            double sal_min_ano, met_sal_min, h_trab, sal_brt, impst_sal, val_ret_imp, sal_liqd;

            Console.WriteLine("* * * Cálculo de Salário ao Colaborador * * *");
            Console.WriteLine("Não use letras ou caractéres especiais (*, ., -, etc.)");

            // Entrada de dados
            Console.Write("\nInforme o valor do salário mínimo do ano atual: ");
            sal_min_ano = double.Parse(Console.ReadLine());
            Console.Write("\nInforme a carga horária do colaborador: ");
            h_trab = double.Parse(Console.ReadLine());
            Console.Write("\nInforme a taxa de imposto sobre o salário: ");
            impst_sal = double.Parse(Console.ReadLine());

            // Processamento
            impst_sal = impst_sal / 100;
            met_sal_min = sal_min_ano / 2;
            sal_brt = met_sal_min * h_trab;
            val_ret_imp = sal_brt * impst_sal;
            sal_liqd = sal_brt - val_ret_imp;

            // Saída
            Console.WriteLine("\nO valor a ser pago ao colaborador é: R${0}", sal_liqd);

            Console.Write("\nAperte qualquer tecla para SAIR");
            Console.ReadKey();
        }
    }
}
