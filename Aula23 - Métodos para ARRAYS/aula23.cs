using System;

class Aula23
{
    static void Main(){

        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        //CLASSE RANDOM GERANDO NÚMEROS ALEATÓRIOS PARA O OBJETO random
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            //METODO NEXT DA CLASSE RANDOM RETORNANDO UM INTEIRO ENTRE ZERO E 49 (PARAMETRIZADO COM VALOR MÁXIMO 50)
            //TAMBÉM PODE SER PARAMETRIZADO COM VALOR MÍNIMO E MÁXIMO, OU VAZIO RETORNARÁ UM INTEIRO QUALQUER
            vetor1[i] = random.Next(50);
        }
        //FOREACH IMPRIMINDO CADA ELEMENTO DO VETOR1
        Console.WriteLine("Elementos do vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }

        //PUBLIC STATIC INT BINARYSEARCH(ARRAY,VALOR);
        //RETORNA INTEIRO COM VALOR DO INDICE DO ELEMENTO PESQUISADO
        //RETORNO MENOR QUE ZERO QUANDO O ELEMENTO NÃO FOI ENCONTRADO NA COLEÇÃO
        Console.WriteLine("BinarySearch");
        int procurado = 33;//VALOR DO ELEMENTO ESPECIFICADO PARA PESQUISA NA COLEÇÃO
        int pos = Array.BinarySearch(vetor1, procurado);//ARRAY vetor1 SENDO A COLEÇÃO, E VARIAVEL procurado CONTENDO O VALOR PARA PESQUISA
        Console.WriteLine("Valor {0} está na posição {1}", procurado, pos);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC STATIC VOID COPY(ARRAY ORIGEM, ARRAY DESTINO, QUANTIDADE DE ELEMENTOS);
        //QUANTIDADE DE ELEMENTOS SENDO ATRIBUIDA PELA PROPRIEDADE LENGTH FAZENDO REFERENCIA A TODOS ELEMENTOS DA COLEÇÃO
        //FOREACH IMPRIMINDO CADA ELEMENTO DA COLEÇÃO
        Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");
    
        //PUBLIC VOID COPYTO(ARRAY DESTINO, A PARTIR DA POSIÇÃO...);
        Console.WriteLine("CopyTo");
        vetor2.CopyTo(vetor3,0);
        foreach (int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC LONG GETLONGLENGTH(DIMENSÃO DO ARRAY);
        //RETORNA O NÚMERO DA QUANTIDADE DE ELEMENTOS NA DIMENSÃO ESPECIFICADA
        Console.WriteLine("GetLongLength");
        long qtdeElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC INT GETLOWERBOUND(DIMENSAO DO ARRAY);
        //RETORNA INTEIRO COM O MENOR INDICE NA DIMENSÃO ESPECIFICADA
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC INT GETUPPERBOUND(DIMENSAO DO ARRAY);
        //RETORNA O MAIOR INDICE NA DIMENSÃO ESPECIFICADA
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        Console.WriteLine("Maior índice do vetor1 {0}", MaiorIndiceVetor);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC OBJECT GETVALUE(LONG INDICE);
        //RETORNA UM OBJETO PORQUE PODE SER UTILIZADO COM ARRAYS DE TIPOS COMO: CHAR, STRINGS, OBJETOS...
        //RETORNARÁ O VALOR DO ELEMENTO NO INDICE ESPECIFICADO
         Console.WriteLine("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));//COMO O RETORNO É UM OBJETO É NECESSÁRIO FAZER A CONVERSÃO (CONVERT, CAST...)
        int valor1 = Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor do elemento de índice 3 do vetor1: {0}", valor0);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC STATIC INT INDEXOF(ARRAY,VALOR);
        //RETORNA O INDICE DO PRIMEIRO VALOR ESPECIFICADO ENCONTRADO, SE O VALOR NÃO FOI ENCONTRAO RETORNARÁ -1
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Índice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("-----------------------------------------------");

        //PUBLIC STATIC INT LASTINDEXOF(ARRAY, VALOR);
        //RETORNA O INDICE DO ULTIMO VALOR ESPECIFICADO ENCONTRADO, SE O VALOR NÃO FOI ENCONTRAO RETORNARÁ -1
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1,33);
        Console.WriteLine("Índice do último valor 33: {0}", indice2);
        Console.WriteLine("-----------------------------------------------");
    
        //PUBLIC STATIC VOID REVERSE(ARRAY);
        //RETORNA OS ELEMENTOS DO ARRAY EM ORDEM INVERTIDA
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
         Console.WriteLine(n);   
        }

        //PUBLIC VOID SETVALUE(OBJECT VALOR, LONG INDICE PARA SETAR);
        //PERMITE SETAR UM VALOR A UM ELEMENTO EM DETERMINADO INDICE DO ARRAY
        vetor2.SetValue(99,0);//SETANDO O VALOR 99 NO INDICE 0 
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0,i);//A VARIAVEL DE CONTROLE DO FOR INDICANDO O INDICE ON O VALOR ZERO SERÁ SETADO
        }
        Console.WriteLine("Vetor 2");
        //FOREACH PARA IMPRIMIR CADA INDICE DO ARRAY
        foreach (int n in vetor2)//VARIAVEL n RECEBENDO CADA ELEMENTO DA COLEÇÃO, OBRIGATORIAMENTE DO MESMO TIPO DA COLEÇÃO
        {
            Console.WriteLine(n);
        }

        //PUBLIC STATIC VOID SORT(ARRAY);
        //ORDENA EM ORDEM CRESCENTE OS ELEMENTOS DO ARRAY
        //PARA ORDENAR EM ORDEM DECRESCENTE BASTA REALIZAR UM REVERSE APÓS
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
    }   
}