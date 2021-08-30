//Mês

/*
Leia um valor inteiro entre 1 e 12, inclusive. 
Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, em inglês, com a primeira letra maiúscula.

ENTRADA

A entrada contém um único valor inteiro.

SAIDA

Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.
*/

using System;

class Program
{
    static void Main(string[] args)
    {

        int m = int.Parse(Console.ReadLine());

        if (m == 1)
        {
                Console.WriteLine("Janeiro");
            }
            else if (m == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (m == 3)
            {
                Console.WriteLine("Março");
            }
            else if (m == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (m == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (m == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (m == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (m == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (m == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (m == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (m == 11)
            {
                Console.WriteLine("Novembro");
            }
            else
            {
                Console.WriteLine("Dezembro");
            }
    }
}