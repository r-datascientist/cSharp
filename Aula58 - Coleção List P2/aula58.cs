using System;
using System.Collections.Generic;

class Aula58
{
    static void Main()
    {
        //List É BASICAMENTE UM ARRAY DINAMICO, UM ARRAY MODERNO
        //POIS JA POSSUI DIVERSOS METODOS IMPLEMENTADOS 
        List<string>carros1=new List<string>();
        List<string>carros2=new List<string>();
        string[] carros3=new string[8];

        //METODO Add() PARA ADICIONAR ELEMENTOS 
        carros1.Add("Golf");
        carros1.Add("HRV");
        carros1.Add("Focus");
        carros1.Add("Argo");
        carros1.Add("Golf");

        foreach (string c in carros1)
        {
            Console.WriteLine("Carros 1: {0}",c);
        }

        //METODO AddRange() PARA ADICIONAR EM BLOCO TODOS OS ELEMENTOS EM UM LISTA
        //NESTE CASO ESTAO SENDO ADICIONADOS TODOS ELEMENTOS DE UMA LISTA EM UM NOVA LISTA
        carros2.AddRange(carros1);

        foreach (string c in carros2)
        {
            Console.WriteLine("Carros 2: {0}",c);
        }

        //METOS Contains() VERIFICA SE DETERMINADO VALOR ESTÁ DENTRE OS ELEMENTOS DA LISTA
        //SE EXISTER RETORNA True
        if (carros1.Contains("Gol"))
        {
            Console.WriteLine("Carro encontrado");
        }else
        {
            Console.WriteLine("Carro NAO encontrado");
        }

        //METODO CopyTo() PARA COPIAR TODA A LISTA E GRAVAR A PARTIR DE UMA POSIÇAO ESPECIFICA NO ARRAY
        //DEVE SER PASSADO O ARRAY DE DESTINO E O INDICE DA POSIÇAO DE GRAVACAO,
        //PARA A PARTIR DESTA POSIÇAO A COPIA SER REALIZADA
        carros1.CopyTo(carros3,2);

        foreach (string c in carros3)
        {
            Console.WriteLine("Carros 3: {0}",c);
        }

        //METODO IndexOf() PARA RETORNAR O INDICE DA PRIMEIRA OCORRENCIA O DETERMINADO ELEMENTO DE PESQUISA NA LISTA
        string car1="Golf";
        int pos1=0;
        pos1=carros1.IndexOf(car1);
        Console.WriteLine("Carro {0} esta na posicao {1}",car1,pos1);       

        //METODO LastIndexOf() PARA RETORNAR O INDICE DA ULTIMA OCORRENCIA O DETERMINADO ELEMENTO DE PESQUISA NA LISTA
        string car2="Golf";
        int pos2=0;
        pos2=carros1.LastIndexOf(car2);
        Console.WriteLine("Carro {0} esta na posicao {1}",car2,pos2);

        //METODO Insert() PARA INSERIR UM ELEMENTO EM UMA POSICAO ESPECIFICA
        carros2.Insert(1,"Cruze");

        foreach (string c in carros2)
        {
            Console.WriteLine("Insert: {0}",c);
        }

        //PARA REMOVER UM ELEMENTO ESPECIFICO PELO INDICE O METODO RemoveAt()
        //PARA REMOVER A PRIMEIRA OCORRENCIA DO ELEMENTO ESPECIFICO PELO VALOR O METODO Remove()
        //EXECUTADA A REMOÇAO RETORNA True
        carros2.RemoveAt(3);
        carros2.Remove("Golf");

        foreach (string c in carros2)
        {
            Console.WriteLine("Remove e RemoveAt: {0}",c);
        }

        //PARA INVERTER A ORDEM DA LISTA O METODO Reverse()
        carros2.Reverse();         

        foreach (string c in carros2)
        {
            Console.WriteLine("Reverse: {0}",c);
        }

        //PARA ORDENAÇAO DA LISTA O METODO Sort()
        //NESTE CASO ORDENACAO ALFABETICA
        carros2.Sort();

        foreach (string c in carros2)
        {
            Console.WriteLine("Sort: {0}",c);
        }

        //PROPRIEDADE Count PARA RETORNAR O TAMANHO DA LISTA
        int tam=carros2.Count;
        Console.WriteLine("Tamanho da Lista: {0}",tam);

        //PROPRIEDADE Capacity PARA RETORNAR A CAPACIDADE DA LISTA
        int cap=carros2.Capacity;
        Console.WriteLine("Capacidade da Lista: {0}",cap);

        //PROPRIEDADE Capacity PARA DETERMINAR A CAPACIDADE DA LISTA
        carros2.Capacity=20;
        int cap2=carros2.Capacity;
        Console.WriteLine("Capacidade 2 da Lista: {0}",cap2);        

        //METODO Clear() PARA DELETAR TODOS OS ELEMENTOS DA LISTA
        carros1.Clear();
    }
}