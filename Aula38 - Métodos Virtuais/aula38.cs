using System;

class Base
{
    //ESTE É O METODO virtual QUE PODERÁ SER SUBSCRITO NAS CLASSES DERIVADAS QUE O HERDAREM
    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}

class Derivada1:Base
{
    //ESTE METODO SUBSCREVE O METODO VIRTUAL CRIADO NA CLASSE BASE COM O override
    override public void info()
    {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1
{
    //ESTE METODO SUBSCREVE O METODO VIRTUAL CRIADO NA CLASSE BASE COM O override
    override public void info()
    {
        Console.WriteLine("Derivada 2");
    } 
}

class Aula38{

    static void Main()
    {
        //OBJETO ESTANCIADO A PARTIR DA CLASSE BASE MANIPULANDO OBJETO VIRTUAL
        Base b1 = new Base();
        b1.info();

        //OBJETO A PARTIR DE CLASSE DERIVADA SUBSCREVENDO METODO VIRTUAL DA CLASSE BASE
        Derivada1 d1 = new Derivada1();
        d1.info();

        //Ref CRIA UMA REFERENCIA PARA AS DERIVADAS DA CLASSE BASE
        //PERMITINDO QUE SE CONTROLE QUAIS METODOS OS ELEMENTOS SEJAM MANIPULADOS,
        //TAMBÉM SUBSCREVENDO METODO VIRTUAL DA CLASSE BASE
        Base Ref;
        Derivada2 d2 = new Derivada2();
        //AQUI Ref RECEBE UM OBJETO ESTANCIADO A PARTIR DE UMA CLASSE DERIVADA
        //E UTILIZA UM METODO VIRTUAL SUBSCRITO PELA CLASSE DERIVADA
        Ref=d2;
        Ref.info();        

    }
}