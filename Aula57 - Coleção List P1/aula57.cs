using System;
using System.Collections.Generic;

class Aula57
{
    static void Main()
    {
        //List É BASICAMENTE UM ARRAY DINAMICO, UM ARRAY MODERNO
        //POIS JA POSSUI DIVERSOS METODOS IMPLEMENTADOS 
        List<string>carros1=new List<string>();
        List<string>carros2=new List<string>();
        string[] carros3=new string[6];

        //METODO Add() PARA ADICIONAR ELEMENTOS 
        carros1.Add("Golf");
        carros1.Add("HRV");
        carros1.Add("Focus");
        carros1.Add("Argo");

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

        //METODO IndexOf() PARA RETORNAR O INDICE DA PRIMEIRA OCORRENCIA PESQUISADA NA LISTA
        string car="Golf";
        int pos=0;
        pos=carros1.IndexOf(car);
        Console.WriteLine("Carro {0} esta na posicao {1}",car,pos);

        //METODO Clear() PARA DELETAR TODOS OS ELEMENTOS DA LISTA
        carros1.Clear();
    }
}