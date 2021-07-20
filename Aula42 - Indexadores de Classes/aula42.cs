using System;

class Carro
{
    private int[] velMax=new int[5]{80,120,160,240,300};

    //UM INDEXADOR EH UM MEMBRO DA CLASSE 
    //E IRÁ PERMITIR QUE OS OBJETOS ESTANCIADOS A PARTIR DESTA CLASSE SEJAM ACESSADOS COMO ARRAYS
    //NA SUA ESTRUTURA CONSTA public PARA SER ACESSADO FORA DO ESCOPO DA CLASSE
    //TIPO int POIS O ARRAY QUE ESTÁO SENDO UTILIZADO COMO REFERENCIA É DO TIPO INT
    //EXPRESSÁO this PARA DETERMINAR O INDEXADOR SEGUIDO DO INDICE DO TIPO  int PARA TRABALHARMOS COM VALORES RELATIVOS AOS INDICES DO ARRAY
    public int this[int i]
    {
        get
        {   //COMO ESTÁ SENDO TRABALHADO UM ARRAY DEVE SER PASSADO TAMBEM O INDICE
            return velMax[i];
        }
        set
        {
            if (value<0)
            {
                velMax[i]=0;

            }else if (value>300)
            {
                velMax[i]=300;
            }else
            {
                velMax[i]=value;
            }
        }
    }
    
    public Carro()
    {

    }
}

class Aula42
{
    static void Main()
    {
        Carro c1=new Carro();

        //ASSIM O OBJETO PODE SER ACESSADO IGUALMENTE A UM ARRAY
        Console.WriteLine("Velocidade {0}",c1[2]);

        c1[2]=220;
        Console.WriteLine("Velocidade {0}",c1[2]);
    }
}