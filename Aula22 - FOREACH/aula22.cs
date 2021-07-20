using System;

class Aula22
{
    static void Main(){
        int[] colecao = new int[5]{11,22,33,44,55};

        //BLOCO FOR AQUI ESTÁ EXECUTANDO A MESMA FUNÇÃO DO FOR EACH ABAIXO
        //POREM SENDO APENAS LEITURA O FOR EACH É MAIS SIMPLES E MAIS INDICADO
        for (int i = 0; i < colecao.Length; i++)
        {
            Console.WriteLine(colecao[i]);
        }
        Console.WriteLine("\n");
        //VARIAVEL n RECEBENDO CADA ELEMENTO DA COLEÇÃO
        //OBRIGTORIAMENTE ESTA VARIAVEL TEM QUE TER O MESMO TIPO DA COLEÇÃO
        //PARA CADA ELEMENTO DA COLEÇÃO SERÁ EXECUTADO O COMANDO DO BLOCO
        foreach (int n in colecao)
        {
            Console.WriteLine(n);
        }
    }
}