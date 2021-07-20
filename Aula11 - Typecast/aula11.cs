using System;

class Aula11{
    static void Main(){

        //ESTE É UM EXEMPLO DE CONVERSÃO IMPLICITA
        //É FEITA PELO COMPILADOR COM SEGURANÇA
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2);

        //ESTE É UM EXEMPLO DE CONVERSÃO EXPLICITA
        //FEITA ATRAVES DE TYPE CAST
        float n3 = 10.5f;
        int n4 = (int)n3;//TYPECAST

        Console.WriteLine(n4);

        int n5 = 10;
        short n6 = (short)n5;//TYPECAST

        Console.WriteLine(n6);
    }
}