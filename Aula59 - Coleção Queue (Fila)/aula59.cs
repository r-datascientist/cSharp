using System;
using System.Collections.Generic;

class Aula59
{
    //IMPORTANTE QUE Queue<> FILA, SEGUE O CONCEITO DE FILA
    //O PRIMEIRO QUE ENTRA É O PRIMEIRO QUE SAI
    static void Main()
    {   
        //AQUI VEMOS A POSSIBILIDADE DE JÁ PASSAR PARA O CONSTRUTUR DA CLASSE Queue<> UMA PROPRIEDADE
        //UM ARRAY QUE JÁ TERÁ CARREGADO SEUS ELEMENTOS COMO ELEMENTOS DA FILA NA SUA PROPRIA CRIAÇAO 
        string[] vs={"Skate","Carro de Lomba","Jato","Canoa"};

        Queue<string>veiculos=new Queue<string>(vs);

        //PARA ADICIONAR ELEMENTOS NO FINAL DA FILA O METODO Enqueue()
        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        //Count() CONTANDO O TAMANHO DA FILA
        Console.WriteLine("Tamanho da Fila: {0}",veiculos.Count);

        //Contains() PARA VERIFICAR SE DETERMINADO ELEMENTO EXISTE NA FILA
        //SE EXISTER RETORNA True E SE NAO RETORNA False
        string v="Skate";
        
        if (veiculos.Contains(v))
        {
            Console.WriteLine("{0} Existe na Fila!",v);
        }else
        {
            Console.WriteLine("{0} NAO existe na Fila!");
        }

        //METODO Peek() RETORNA O PRIMEIRO ELEMENTO DA FILA
        //MAS NAO REMOVE ESTE ELEMENTO DA FILA
        Console.WriteLine("O primeiro elemento da fila é: {0}",veiculos.Peek());

        foreach (string v2 in veiculos)
        {
            Console.WriteLine("Fila Peek: {0}",v2);
        }

        //METODO Dequeue() RETORNA O PRIMEIRO ELEMENTO DA FILA
        //E AO MESMO TEMPO REMOVE ESTE ELEMENTO DA FILA
        Console.WriteLine("O primeiro elemento: {0}, foi removido da fila",veiculos.Dequeue());

        foreach (string v3 in veiculos)
        {
            Console.WriteLine("Fila Dequeue: {0}",v3);
        }

        //PARA REALIZAR UM LOOP QUE VÁ RETORNANDO OS ELEMENTOS DA FILA EM ORDEM
        //E AO MESMO TEMPO VÁ ELIMINANDO OS ELEMENTOS TAMBEM EM ORDEM
        //É MAIS INDICADO REALIZAR O LOOP COM O While POIS NAO SABEMOS A QUANTIDADE ELEMENTOS
        //E TAMBEM UTILIZAR O METODO Dequeue()
        //Count PARA RETORNAR A QUANTIDADE DE ELEMENTES ENQUANTO HOUVER (UM PARA SER REMOVIDO COM O Clear())
        while (veiculos.Count > 1)
        {
            Console.WriteLine("Loop Dequeue: {0}",veiculos.Dequeue());
        }

        Console.WriteLine("Tamanho da Fila: {0}",veiculos.Count);

        //METODO Clear() PARA LIMPAR A FILA
        veiculos.Clear();

        Console.WriteLine("Tamanho da Fila: {0}",veiculos.Count);
    }
}