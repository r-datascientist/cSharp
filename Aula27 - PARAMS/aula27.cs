using System;

class Aula27
{
    static void Main(){
        soma1();
        soma1(10);
        soma1(10,2);
        soma1(10,2,3,6,7,7);

    }
    //ESTE METODO FOI CONSTRUIDO PARA RECEBER DOIS VALORES DE ENTRADA E OPERA LOS
    //POREM SE FOSSE NECESSÁRIO RECEBER MAIS ARGUMENTOS SERIA NECESSÁRIO ADICIONAR VARIAVEIS DE ENTRADA E AS OPERAÇÕES
    static void soma(int n1, int n2){
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} com {1} é: {2}", n1, n2, res); 
    }
    //COM A PALAVRA CHAVE params NÃO É NECESSÁRIO ESPECIFICAR QUANTOS SÃO OS PARAMETROS DE ENTRADA 
    //ENTRAR COM VALORES ZERO OU VAZIO, UMA LISTA SEPARADA POR VIRGULA, OU UM VETOR
    //O METODO SOMA1  RECEBE UM VETOR DE INTEIROS NA VARIAVEL n
    static void soma1(params int[]n){
        int res = 0;
        //SE O VETOR NÃO RECEBER NENHUM VALOR, FOR VAZIO
        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        //SENAO SE ELE RECEBER SÓ UM VALOR    
        }else if(n.Length < 2){
            Console.WriteLine("Valores insuficientes para a soma");
        //SENAO ELE RECEBE DOIS OU MAIS VALORES
        }else{
            //PERCORRE CADA POSIÇÃO DO VETOR OS VALORES DE CADA ELEMENTO NA VARIAVEL DE RESULTADO res
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
        
    }

}