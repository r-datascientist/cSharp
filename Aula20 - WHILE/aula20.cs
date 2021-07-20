using System;

class Aula20
{
    static void Main(){
        int[] num = new int[10];
        
        //OBRIGATORIAMENTE A VARIAVEL DE CONTROLE DEVE SER INICIALIZADA ANTES DE ENTRAR NO LOOP
        int i = 0;
        //LOOP 1 INCREMENTANDO
        while (i < num.Length)//O ÚNICO PARAMETRO DO LOOP É A EXPRESSÃO LÓGICA DE CONTROLE
        {
            num[i] = 0;
            Console.WriteLine(num[i]);
            i++;//OBRIGATORIAMENTE A VARIAVEL DE CONTROLE UTILIZADA NA EXPRESSÃO LÓGICA 
                //DEVE SER INCREMENTADA/DECREMENTADA DENTRO DO LOOP
        }
        Console.WriteLine("\nFim do loop 1");

        int[] n = new int[10];
        
        //TENDO O VETOR TAMANHO 10, OU SEJA, INDICES DE 0 A 9,
        //E SENDO ELE UTILIZADO COMO CONTROLE PARA POPULAR CADA POSIÇÃO DOS INDICES DO VETOR,
        //A CONTAGEM ENQUANTO(10 > 0) POSSUE 11 POSIÇÕES E SAIRIA FORA DOS LIMITES DO VETOR
        int ind = n.Length-1;//PROPRIEDADE LENGHT DECREMENTADA EM 1 DIRETAMENTE NA VARIAVEL DO VETOR
        //LOOP 2 DECREMENTANDO
        while (ind > 0)
        {
            n[ind] = 0;
            Console.WriteLine(n[ind]);
            ind--;
        }
        Console.WriteLine("Fim do loop 2");
    }
    
}