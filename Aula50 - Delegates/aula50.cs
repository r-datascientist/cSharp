using System;


//delegate FUNCIONA COMO UM METODO QUE DA ACESSO A UM OU MAIS METODOS STATIC
//COMO SE FOSSE UM ATALHO QUE APONTA PARA O ENDEREÇO DE ENTRADA DO METODO
//ELE PODE SER USADO COM UM OU MAIS PARAMETROS,
//OU ATÉ MESMO COM UM NÚMERO ILIMITADO DE PARAMETROS UTILIZANDO O params E ARRAYS
//SENDO DECLARADO FORA DA CLASSE TEM O ESCOPO GLOBAL
delegate int Op(int n1, int n2);

class Mat
{
    public static int soma(int n1, int n2)
    {
        return n1+n2;
    }

    public static int mult(int n1, int n2)
    {
        return n1*n2;
    }
}

class Aula50
{
    static void Main()
    {
        int res;

        //A PARTIR DO delegate op É ESTANCIADO O OBJETO d1
        //APONTANDO PARA CLASSE Mat E PARA OS METODOS soma E mult
        Op d1=new Op(Mat.soma);

        res=d1(10,50);

        Console.WriteLine("Soma: {0}",res);

        //NAO É NECESSARIO ESTANCIAR UM NOVO OBJETO
        //O MESMO OBJETO PODE APONTAR TAMBEM PARA OUTRO METODO
        d1=new Op(Mat.mult);

        res=d1(5,50);

        Console.WriteLine("Multiplição: {0}",res);       
    }
}