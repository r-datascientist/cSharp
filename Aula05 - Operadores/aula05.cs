using System;

class Aula05
{
    static void Main(){
        //OPERADORES MATEMATICOS
        int res = (10 + 5) * 2;

        Console.WriteLine(res);

        //OPERADOR RELACIONAL > < => <= != ==
        bool res2 = 10 > 5;

        Console.WriteLine(res2);

        //OPERADOR DE INCREMENTO
        //PARA + - / *
        int num = 10;

        num ++;//num +=1; //num = num + 1

        Console.WriteLine(num);

        int num1 = 10;

        //A ATRIBUIÇÃO PODE SER FEITA ESCREVENDO A VARIAVEL MAIS DE UMA VEZ OU DE FORMA CONTRAIDA UTILIZANDO OS OPERADORES
        //PARA INCREMENTAR EM 1 EXISTEM DUAS FORMAS CONTRAIDAS
        num++;//num1 +=1; //num = num + 1;

        //PARA INCREMENTAR MAIS DE UM SÓ EXISTE UMA FORMA CONTRAÍDA
        //num1 +=2; //num = num + 2

        //ESTA FORMA CONTRAIDA PODE SER USADA PARA OPERAÇÕES DE 
        //SOMA +
        //SUBTRAÇÃO -
        //DIVISÃO /
        //MULTIPLICAÇÃO *

        Console.WriteLine(num1);

        //OPERADORES LÓGICOS 
        // & = AND / E
        // | = OR / OU
        bool res3 = (5 > 3) & (10 > 5);

        Console.WriteLine(res3);
    }
}