using System;

class Carro
{
    private int velMax;

    //PARA AS PROPRIEDADES get E set NAO SE UTILIZA PARENTESES NA SUA ESTRUTURA
    //COM get PODE SE LER OU RECEBER O VALOR DA VARIAVEL
    //COM O set PODE SE EDITAR O VALOR DA VARIAVEL,SENDO QUE O VALOR ORIGINAL DA VARIAVEL ESTA NA POSICAO value
    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if (value<0)
            {
                velMax=0;

            }else if (value>300)
            {
                velMax=300;
            }else
            {
                velMax=value;
            }
        }
    }
    
    public Carro()
    {
        //DIRETAMENTE PODE SE ATRIBUIR VALORES AS PROPRIEDADES get E set
        vm=120;
    }
}

class Aula41
{
    static void Main()
    {
        Carro c1=new Carro();

        //RECEBENDO O VALOR PARA LEITURA ATRAVES DA PROPRIEDADE get
        Console.WriteLine("Velocidade {0}",c1.vm);

        //SETANDO O VALOR PARA ESCRITA ATRAVES DA PROPRIEDADE set
        c1.vm=220;
        Console.WriteLine("Velocidade {0}",c1.vm);
    }
}