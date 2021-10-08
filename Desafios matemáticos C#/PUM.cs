//  PUM

/*
Desenvolva um programa que leia um valor inteiro N. 
Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

ENTRADA

O arquivo de entrada contém um número inteiro positivo N.

SAIDA

Imprima a saída conforme o exemplo fornecido.
*/

using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++) {

               // Insira o seu código aqui
                for (int j = 1; j <= 3; j++) {

                    Console.Write(primeiro + " ");
                    primeiro++;
                    if(j % 3 == 0)
                    {
                      primeiro++;
                      Console.WriteLine("PUM");
                    }
                }
            }
        }
    }
}