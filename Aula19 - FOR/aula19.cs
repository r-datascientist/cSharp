using System;

class Aula19
{
    static void Main(){
        //IMPORTANTE QUE A VARIAVEL DECLARADA DENTRO DO FOR TEM O ESCOPO SOMENTE DO FOR
        //SE A VARIAVEL FOR UTILIZADA EM OUTRAS PARTES DO PROGRAMA ELA PODE SOMENTE SER INSTACIADA NO FOR, JÁ TENDO SIDO DECLARADA ANTES
        //O COMANDO FOR CONFIGURA SE EM TRES PARTES
        //A PRIMEIRA PARTE É O CONTADOR OU INICIALIZADOR, É DE ONDE IRÁ PARTIR O LOOP DO FOR
        //A SEGUNDA PARTE É A REGRA QUE DEVE SER ATENDIDA ENQUANTO O LOOP FOR EXECUTADO
        //ENQUANTO A CONDIÇÃO DA SEGUNDA PARTE RETORNAR TRUE O LOOP SERÁ EXECUTADO
        //A TERCEIRA PARTE É A INCREMENTAÇÃO/DECREMENTAÇÃO QUE IRÁ LIMITAR O LOOP, IMPOSSIBILITANDO QUE ELE SEJA INFINITO
        for (int c = 0; c < 10; c++)//C = C + 1 / C + = 1 / C++
        {
            Console.WriteLine("CFB Crusos");
        }
        Console.WriteLine("\n");
        //TAMBEM É POSSIVEL MANIPULAR O VALOR DA VARIAVEL DE CONTAGEM
        int[] num = new int[10]{00,11,22,33,44,55,66,77,88,99};//VETOR DECLARADO E INICIALIZADO COM TODAS AS POSIÇÕES ZERO

        //PARA EVITAR O ERRO DE HAVER MAIS EXECUÇÕES DO LOOP DO QUE AS POSIÇÕES DO ARRAY
        //USA SE A PROPRIEDADE LENGTH COM O ARRAY
        for (int i = 0; i < num.Length; i++)
        {
            //num[i] = 0;
            Console.WriteLine("Na posição {0} o valor do Vetor é {1}",i,num[i]);
        }
        Console.WriteLine("\n");

        //também é possível atribuir ao vetor o valor da variavel de contagem (indice)
        int[] n = new int[10];

        for (int i = 0; i < n.Length; i++)
        {
            n[i] = i;
            Console.WriteLine("Na posição {0} o valor do Vetor é {1}",i,n[i]);
        }
        Console.WriteLine("\n");
    }
}