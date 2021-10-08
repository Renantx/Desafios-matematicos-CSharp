// Polígonos Regulares Simples

/*
Na geometria Euclidiana, um polígono regular é um polígono em que todos os ângulos são iguais e todos os lados tem o mesmo comprimento. 
Um polígono simples é aquele cujos segmentos de reta não se interceptam. 
Abaixo pode-se ver vários mosaicos feitos por polígonos regulares.

Você deve escrever um programa que, dados o número e o comprimento dos lados de um polígono regular, mostre seu perímetro.

ENTRADA

A entrada tem dois inteiros positivos: N e L, que são, respectivamente, o número de lados e o comprimento de cada lado de um polígono regular (3 ≤ N ≤ 1000000 and 1 ≤ L ≤ 4000).

SAIDA

A saída é o perímetro P do polígono regular em uma única linha.
*/

using System; 

class URI {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            
        //Insira o seu código aqui
        var n = int.Parse(v[0]);
        var l = int.Parse(v[1]);
        
        var p = n * l;
        
        Console.Write(p);
    }

}