using System;

class Aula17
{
    static void Main(){
        //DECLARANDO ARRAY E ATRIBUINDO SEPARADAMENTE
        int[] a = new int[5];//COMEÇANDO POR ZERO

        a[0] = 111;
        a[1] = 222;
        a[2] = 333;
        a[3] = 444;
        a[4] = 555;

        //DECLARANDO ARRAY E ATRIBUINDO VALORES NA MESMA LINHA
        int[] b = new int[3]{55,77,99};

        //DECLARANDO ARRAY E ATRIBUINDO COM SINTAXE CONTRAIDA
        //IMPORTANTE QUE DESSA FORMA A QUANTIDADE DE POSIÇÕES DO ARRAY
        //SERÁ DECLARADA DE FORMA IMPLICITA, DE ACORDO COM A QUANTIDADE DE VALORES ATRIBUIDOS
        int[] c = {00,11,22,33};

        //ACESSANDO AS POSIÇÕES DO ARRAY
        Console.WriteLine(a[0]);
        Console.WriteLine(b[2]);//TERCEIRA POSIÇÃO INDICE 2
        Console.WriteLine(c[1]);
    }
}