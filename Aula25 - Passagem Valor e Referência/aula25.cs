using System;

class Aula25
{
    static void Main(){
        //QUANDO A VARIAVEL num É DECLARADA RECEBEO VALOR 10
        //SUA POSIÇÃO NA MEMÓRIA CONTEM O VALOR 10
        //POREM QUANDO A VARIAVEL É PASSADA COMO PARAMETRO E PARA O METODO E EM SEGUINDA É IMPRESSA
        //ELA CONTINUA SENDO CONSIDERADA COM A MESMA POSIÇÃO DE MEMÓRIA E O MESMO VALOR
        //POIS NÃO RECEBE O RETORNO DO METODO, POIS MANTEM REFERIDA SUA POSIÇÃO E SEU VALOR DE MEMÓRIA
        int num = 10;
        dobrar(num);
        Console.WriteLine(num);

        //QUANDO A VARIAVEL num ACOMPANHA A PROPRIEDADE ref
        //CONSIDERA SE A POSIÇÃO DE MEMÓRIA UTILIZADA PARA A VARIAVEL DECLARADA COMO ARGUMENTO DO METODO
        //E O VALOR DO RESULTADO DA OPERAÇÃO DO METODO PASSA A SE REFERIR A VARIAVEL num
        int num1 = 10;
        dobrar1(ref num1);
        Console.WriteLine(num1);
    }
    
    //DA MESMA FORMA O METODO NÃO CONTEM A PROPRIEDADE ref
    static void dobrar(int valor){
        valor*=2;
    }
    //METODO COM PROPRIEDADE ref PARA REFERENCIA AO VALOR DA POSIÇÃO DA MEMÓRIA DA VARIAVEL DE ARGUMENTO DO METODO
    static void dobrar1(ref int valor1){
        valor1*=2;
    }
}