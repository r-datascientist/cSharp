using System;
class Aula03{
    static void Main(){
        //VARIAVEIS LOCAIS AO METODO MAIN
        byte n1 = 10;
        int num = 0;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Bruno";

        //QUANDO USADO OPERADOR VAR E NÃO É ATRIBUIDO O TIPO
        //A TIPAGEM É ATRIBUIDA PELO COMPILADOR
        //DE ACORDO COM O VALOR ATRIBUIDO A VARIAVEL
        var aux = nome; //VARIAVEL DO TIPO STRING 

        Console.WriteLine("Valor da variável: " + aux + "...");

        //DECLARANDO VARIAVEIS EM CONJUNTO
        int num1, num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.Write("A multiplicação de: " + num1 + " por: " + num2 + " é igual a: " + res);

        //A MULTIPLICAÇÃO TAMBPEM PODE SER FEITA NAS PROPRIAS VARIAVEIS, POREM A OPERAÇÃO SERA REALIZADA SEMPRE QUE FOR NECESSÁRIO ACESSAR O VALOR
        Console.Write("\nA multiplicação de: " + num1 + " por: " + num2 + " é igual a: " + num1*num2);

    }
}