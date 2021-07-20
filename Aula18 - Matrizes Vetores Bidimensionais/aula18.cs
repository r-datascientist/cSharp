using System;

class Aula18
{
    static void Main(){
    //DECLARAÇÃO DE ARRAY MATRIZ E ATRIBUIÇÃO EM SEPARADOS
    //VIRGULA INDICANDO QUE É UMA MATRIZ BIDIMENSIONAL
    //DECLARAÇÃO DE LINHAS E COLUNAS
    int[,] m = new int[2,5];

    m[0,0] = 00; m[0,1] = 01; m[0,2] = 02; m[0,3] = 03; m[0,4] = 04; 
    m[1,0] = 10; m[1,1] = 11; m[1,2] = 12; m[1,3] = 13; m[1,4] = 14;

    Console.WriteLine(m[1,2]); 

    //DECLARAÇÃO E ATRIBUIÇÃO EM LINHA ÚNICA
    //CADAS CHAVES SERIA UMA LINHA
    int[,] n = new int[2,2]{{10,20},{30,40}};

    Console.WriteLine(n[1,1]);//INDICE 1 POSIÇÃO 2

    //DECLARAÇÃO E ATRIBUIÇÃO CONTRAÍDAS
    int[,] o = {{10,20},{30,40}};

    Console.WriteLine(o[0,0]);//INDICE 0 POSIÇÃO 1
    }
}