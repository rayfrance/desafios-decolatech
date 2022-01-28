// Kogu está buscando as esferas do dragão para invocar Xenlongão e pedir para ele reviver seu amigo Kuriri, que infelizmente morreu de novo na última batalha dos guerreiros Zê.

// Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlongão que é seu conhecido há muito tempo, decidiu abrir uma exceção e aceitou ser invocado caso 
//Kogu encontre todas as esferas cujo o número de divisores da quantidade de estrelas da esfera sejam par.

// Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas, pois elas tem uma quantidade ímpar de divisores, então ele só precisa
//pegar 5 esferas para invocar Xenlongão.
/// Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de esferas existentes, mostre a quantidade mínima de esferas que ele precisa 
//procurar.

// *Entrada*
// A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste. As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 109) que representa a quantidade
// de esferas necessárias para invocar Xenlongão.

// *Saída*
// Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            while (N > 0)
            {
              int bolas = Convert.ToInt32(Console.ReadLine());
              if (bolas >= 2 && bolas <= Math.Pow(10, 9))
              {
               int estrelas = bolas;
               for ( int i = 1; i <= estrelas; i++)
                 {
                   int qtdeDiv = 0;
                   if (estrelas % i == 0)
                   {
                     qtdeDiv++;
                   }
                    if ((qtdeDiv % 2) == 0)
                   {
                     x++;
                   }
                 }
                Console.WriteLine(x);
                N = 0;
              }
            }
        }
    }
}
