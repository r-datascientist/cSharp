using System;

class Aula04
{
    //A VARIAVEL NUM É UMA VARIAVEL GLOBAL A ESTÁ CLASSE
    static int num = 10;
    //A VARIAVEL NUM2 É UMA VARIAVEL LOCAL
    //E SÓ É VISIVEL PARA O DENTRO DO ESCOPO DO METODO MAIN
    static void Main(){
        int num2 = 0;
        Console.WriteLine("Varial global: " + num + " Variavel loval metodo Main: " + num2);
    }

    //CADA METODO POSSUI AS SUAS VARIAVEIS LOCAIS E TAMBEM ACESSAM AS VARIAVEIS GLOBAIS DA CLASSE
    static void teste(){
        int num2 = 1;//MESMO AS VARIAVEIS DOS DOIS METODOS TENDO O MESMO NOME NAO SAO AS MESMAS VARIAVEIS
        Console.WriteLine("Varial global: " + num +" Variavel loval metodo teste: " + num2);
    }
}