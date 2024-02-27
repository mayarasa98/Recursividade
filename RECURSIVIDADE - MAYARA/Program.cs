using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVIDADE___MAYARA
{
    /* Exercício 1: 
    Faça um programa para calcular a potencia de um número. O método recursivo deve receber como parâmetro a base e 
    o expoente, e devolver o valor da potência.
    EX: double CalculaPotencia (int p_base, int p_expoente)
    CalculaPotencia (2,3) = 8 
    */


    internal class Program
    {
        static void Main(string[] args)
        {
            double p_base;
            double p_expoente;
            double resultado;

            Console.WriteLine("Digite o valor do número de base: ");
            p_base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do expoente: ");
            p_expoente = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(p_base, p_expoente);

            Console.WriteLine("O resultado é: {0}", resultado);


            double CalculaPotencia(int n_base, int n_expoente)
            {
                if (n_expoente == 0)
                    return 1;
                else if (n_expoente >= 1)
                    return n_base * CalculaPotencia();
                else
                    return;
            }





            Console.ReadKey();
        }
    }
}
