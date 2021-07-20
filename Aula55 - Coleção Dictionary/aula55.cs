using System;
//PARA UTILIZACAO DE Dictionary DEVE SER FEITA A INCLUSAO DA BIBLIOTECA ABAIXO
using System.Collections.Generic;

class Aula55
{
    static void Main()
    {
        //CLASSE Dictionary É UMA COLECAO DE DADOS ONDE O DADO É RELACIONADO POR UMA CHAVE E UM VALOR
        //SENDO ASSIM BASICAMENTE SEUS VALORES POSSUEM RESPECTIVAS CHAVES

        //DEVEM SER ATRIBUIDOS TIPOS PARA AS CHAVES E PARA OS VALORES
        //ESTES TIPOS PODEM SER O MESMO OU DIFERENTES
        Dictionary <int,string> veiculos = new Dictionary <int,string>();

        //PARA ADICIONAR DADOS AO DICIONARIO TEMOS O METODO Add()
        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Aviao");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        //TEMOS TAMBEM METODOS e PROPRIEDADES PARA ACESSAR E PROCESSAR ESTES DADOS

        //PARA FAZER A CONTAGEM DE VALORES TEMOS A PROPRIEDADE Count, RETORNANDO UM INT
        Console.WriteLine("Tamanho do Dicionario: {0}\n",veiculos.Count);
        
        //ContainsKey() VEIFICA SE NO DICIONARIO EXISTE A CHAVE ESPECIFICADA
        //SE EXISTIR ELE RETORNA True SENAO ELE RETORNA O VALOR ESPEFICIDADO         
        int chave=21;

        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine("A chave {0} esta na colecao",chave);
        }else
        {
            Console.WriteLine("A chave {0} NAO esta na colecao",chave);
        }

        //TAMBEM TEMOS O METODO ContainsValeu()
        //QUE VERIFICA SE O VALOR ESPECIFICADO EXISTE NO DICIONARIO
        string valor="Navio";
        
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine("O valor {0} esta na colecao",valor);
        }else
        {
            Console.WriteLine("O valor {0} NAO esta na colecao",valor);
        }

        //PARA REMOVER UM VALOR ESPECIFICO DO DICIONARIO TEMOS O METODO Remove()
        veiculos.Remove(20);

        //OS VALORES TAMBEM PODEM SER ACESSADOS E TRABALHADOS COMO SE FOSSE UM ARRAY
        //UTILIZANDO O VALOR DA CHAVE COMO SE FOSSE O INDICE DO ARRAY ESTA SENDO ATRIUIDO O VALOR Bicicleta
        veiculos[15] = "Bicicleta";

        //PARA IMPRIMIR TODOS OS ELEMENTOS DO DICIONARIO
        //KeyValuePair PARA ATRIVUIR A VARIAVEL v COM DOIS TIPOS E DOIS ELEMENTO S   
        foreach (KeyValuePair<int,string> v in veiculos)
        {
            Console.WriteLine(v.Key);//TEMOS A PROPRIEDADE Key PARA ACESSAR AS CHAVES
            Console.WriteLine(v.Value);//E A PROPRIEDADE Value PARA OS VALORES
        }
        //UMA OUTRA FORMA DE FAZER ESTA MESA IMPLEMENTACAO É
        Dictionary<int,string>.ValueCollection valores=veiculos.Values;
        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
        Dictionary<int,string>.KeyCollection chaves=veiculos.Keys;
        foreach (int v in chaves)
        {
            Console.WriteLine(v);
        }        

        //PARA LIMPAR O DICIONARIO TEMOS O METODO Clear()
        veiculos.Clear();

    }
}