//Quantidade de números positivos

/*
Crie um programa que leia 6 valores. 
Você poderá receber valores negativos e/ou positivos como entrada, devendo desconsiderar os valores nulos. 
Em seguida, apresente a quantidade de valores positivos digitados.

ENTRADA

Você receberá seis valores, negativos e/ou positivos.

SAIDA

Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é exibido abaixo no exemplo de saída. 
Não esqueça da mensagem "valores positivos" ao final.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
      
        double[] arr = new double[6]; 
      
        for (int i = 0; i < 6; i++) 
        {
              arr[i] = double.Parse(Console.ReadLine());
        }
        
        int ehPositivo = 0;

        for (int i = 0; i < 6; i++) 
        {
            if (arr[i] > 0.0) ehPositivo++;
        }

        Console.WriteLine(ehPositivo + " valores positivos");
    }
}