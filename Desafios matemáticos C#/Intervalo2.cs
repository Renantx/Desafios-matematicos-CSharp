//Intevalo 2

/* 
Leia um valor inteiro N. 
Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

ENTRADA

A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 
SAIDA
Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo. 
*/

using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contInt = 0;
            int contExt = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contInt = contInt + 1;
                }
                else
                {
                    contExt = contExt + 1;
                }
 
            }
            Console.WriteLine(contInt + " in");
            Console.WriteLine(contExt + " out");

        }
    }
}