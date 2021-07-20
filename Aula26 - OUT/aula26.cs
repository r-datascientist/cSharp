using System;

class Aula26
{
    static void Main(){
        int r;
        int r2 = 10;
        metodo1();
        r = metodo2(5,3);
        metodo3(ref r2);

        Console.WriteLine("=====================================");
        Console.WriteLine("{0}",metodo2(5,3));
        Console.WriteLine("{0}",r);
        Console.WriteLine("{0}",r2);
        Console.WriteLine("=====================================");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(r2);
        }
        Console.WriteLine("=====================================");
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 5;
        //PARA ASSOCIAR A VARIAVEL DE SAÍDA A VARIAVEL DE RECEBIMENTO 
        //DEVE SE UTILIZAR O MODIFICADOR out NA CHAMADA DO METODO
        //PASSANDO A VARIAVEL DE RECEBIMENTO COMO UM PARAMETRO DE ENTRADA DO METODO
        //A VARIAVEL quoc ESTÁ RECEBENDO O RETORNO DO MÉTODO, RETORNO DA PROPRIEDADE return
        //A VARIAVEL rest COM O MODIFICADOR out ESTÁ RECEBENDO O VALOR DE SAÍDA DA OPERAÇÃO REALIZADA NO MÉTODO
        quoc = divide(divid, divis, out rest);
        //AS VARIAVEIS divid e divis SÃO PASSADAS COMO ARGUMENTOS DO METODO E TAMBÉM SÃO IMPRESSAS 
        //A VARIAVEL rest ESTÁ SENDO IMPRESSA JÁ COM O VALOR DO RESTO DA DIVISÃO CALCULADO NO METODO
        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}",divid, divis, quoc, rest);
        Console.WriteLine("=====================================");
    }

    static void metodo1(){
        Console.WriteLine("CFB Crusos");
    }

    static int metodo2(int v1, int v2){
        int res;
        res = v1 + v2;
        return res;
    }

    static void metodo3(ref int v3){
        v3*=2;
    }

    //METODO COM RETORNO POR VALOR INTEIRO
    //ESTE MÉTODO RETORNARÁ O QUOCIENTE E O RESTO DA DIVISÃO
    //COM O MODIFICADOR out PODEMOS DECLARAR VARIAVEIS DE SAÍDA
    //UTILIZANDO UMA SEGUNDA OPÇAO DE VALOR DE SAÍDA ALÉM DO return
    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;//OPERADOR divide / RETORNA O QUOCIENTE DA DIVISÃO
        resto = dividendo%divisor;//OPERADOR mod % RETORNANDO O RESTO DA DIVISÃO
        return quociente; 

    }
}