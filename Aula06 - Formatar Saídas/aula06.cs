using System;

class Aula06
{
    static void Main(){

        int n1, n2, n3;

        n1 = 10;
        n2 = 20;
        n3 = 30;

        //AS VARIAVEIS SÃO IMPRESSAS A PARTIR DAS SUAS POSIÇÕES NO INDICE
        //CARACTERES DE ESCAPE \n quebra linha \t tab
        Console.Write("\nn1={0}, \nn2={1}, \nn3={2}...\n ", n1, n2, n3);

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        //DENTRO DAS CHAVES O VALOR 15 REPRESENTA A DISTANCIA DE TABULAÇÃO QUE ESTÁ SENDO DETERMINADA
        //TAMBÉM DENTRO DAS CHAVES OS CARACTERES :c DETERMINA QUE O VALOR SERÁ MOSTRA COMO MONITARIO E O :p COMO PERCENTUAL
        Console.WriteLine("\nProduto............:{0,15}",produto);
        Console.WriteLine("Val.Compra.........:{0,15:c}",valorCompra);
        Console.WriteLine("Lucro..............:{0,15:p}",lucro);        
        Console.WriteLine("Val.Venda..........:{0,15:c}",valorVenda);        
    }
}