using System;

class Aula09
{
    static void Main(){
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        int num4 = 40;
        int num5 = 50;
        int num6 = 5;

        //BITWISE PARA A DIREITA >>
        //DESLOCA OS CINCO ULTIMOS DOS OITO BITS PARA A DIREITA
        //DIMINUINDO O VALOR PARA SUA METADE
        num1 = num1 >> 1;

        Console.WriteLine("Bitwise 1 a direita: {0}", num1);

        //BITWISE PARA A ESQUERDA >>
        //DESLOCA OS CINCO ULTIMOS DOS OITO BITS PARA A ESQUERDA
        //AUMENTANDO O VALOR PARA O SEU DOBRO
        num2 = num2 >> 1;

        Console.WriteLine("Bitwise 1 a esquerda: {0}", num2);

        num3 = num3 << 2;

        Console.WriteLine("Bitwise 2 a esquerda: {0}", num3);

        num4 = num4 >> 2;

        Console.WriteLine("Bitwise 2 a direita: {0}", num4);

        num5 = num5 >> 5;

        Console.WriteLine("Bitwise 5 a direita: {0}", num5);

        num6 = num6 >> 5;

        Console.WriteLine("Bitwise 5 a direita: {0}", num6);
    }
}