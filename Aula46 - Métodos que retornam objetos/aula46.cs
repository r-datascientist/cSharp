using System;

class Galinha
{
    //PROPRIEDADE static SOMANDO O TOTAL GLOBAL DOS OVOS
    public static int qtdeOvo;
    //PROPRIEDADE private SOMANDO O TOTAL DE OVOS DE CADA GALINHA
    private int numOvo;
    private string nomeGalinha;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
        qtdeOvo=0;
    }
    //AQUI ESTA DETERMINADO O METODO PUBLICO QUE TEM COMO RETORNO A CLASSE OVO
    //OU SEJA CADA VEZ QUE UM OBJETO FOR ESTACIADO A PARTIR DA CLASSE Galinha
    //ESTE METODO SERÁ EXECUTADO E RETORNARÁ COM A IMPLEMENTAÇAO DOS MEMBROS DA CLASSE Ovo
    public Ovo botar()
    {
        numOvo++;
        qtdeOvo++;
        return new Ovo(numOvo, nomeGalinha, qtdeOvo);
    }
}

class Ovo
{
    private int numOvo;
    private string minhaGalinha;
    private int qtdeOvo;

    public Ovo(int numOvo, string minhaGalinha, int qtdeOvo)
    {
        this.numOvo=numOvo;
        this.minhaGalinha=minhaGalinha;
        this.qtdeOvo=qtdeOvo;
        Console.WriteLine("Ovo criado: {0} - {1} - Total: {2}",this.numOvo,this.minhaGalinha,this.qtdeOvo);
    }
}

class Aula46
{
    static void Main()
    {
        //CADA OBJETO É ESTANCIADO A PARTIR DA CLASSE Galinha E O PARAMETRO DE NOME É PASSADO PARA SEU CONSTRUTOR
        Galinha g1=new Galinha("Benedita");
        Galinha g2=new Galinha("Felicia");
        Galinha g3=new Galinha("Pipoca");

        //COMO O METODO BOTAR RETORNA UM TIPO OBJETO QUE É A CLASSE Ovo 
        //QUANDO CHAMADO O METODO PELOS OBJETOS ESTANCIADOS A PARTIR DA CLASSE Galinha
        //RETORNA A IMPLEMENTAÇAO DA CLASSE Ovo E DE SEU CONSTRUTOR
        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();
        g2.botar();

        g3.botar();
    }
}