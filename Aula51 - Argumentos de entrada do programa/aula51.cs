using System;

//OS ARGUMENTOS DE ENTRADA PARA O PROGRAMA SAO DECLARADOS DIRETAMENTE NO METODO MAIN
//ESTE PRIMEIRO EXEMPLO DEMONSTRA A ENTRADA DE UM ARRAY DE STRINGS
//E A IMPRESSAO DA QUANTIDADE DE ARGUMENTOS QUE O ARRAY RECEBEU
//ALEM DA IMPRESSAO DE CADA ARGUMENTO RECEBIDO NO INDICE DO ARRAY
/*
class Aula51
{
    static void Main(string[] args)
    {
        if (args.Length>0)
        {
            Console.WriteLine("Quantidade de Argumentos: {0}",args.Length);

            for (int i = 0; i < args.Length; i++)
            {
               Console.WriteLine("Argumento: {0} = {1}",i,args[i]); 
            }
        }else
        {
            Console.WriteLine("Não foram passados Argumentos!");
        }
    }
}
*/

//ESTE SEGUNDO EXEMPLO TAMBEM RECEBE STRINGS, POEM ELE FAZ A SOMA DE INTEIROS
//PARA ISSO DEVEM SER INSERIDOS SOMENTE INTEIROS E A CONVERSAO DO TIPO É FEITO COM O METODO Parse
class Aula51
{
    static void Main(string[] args)
    {
        int res=0;

        if (args.Length>0)
        {
            Console.WriteLine("Quantidade de Argumentos: {0}",args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                res+=Int32.Parse(args[i]);
            }
            //PARA SER IMPRESSA A SOMA DA VARIAVEL E NAO CADA ELEMENTO DO INDICE
            //A IMPRESSAO FOI MOVIDA PARA FORA DO LOOP
            Console.WriteLine("Soma Argumentos: {0}",res); 
        }else
        {
            Console.WriteLine("Não foram passados Argumentos!");
        }
    }
}
