using System;

//struct É UM TIPO DE DADOS ESPECIAL QUE PODE RECEBER DIFERENTES TIPOS DE DADOS
//UMA struct NAO É UMA CLASSE, NAO PODE SER HERDADA, MAS PODE TER CONSTRUTORES

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }

    public void info()
    {
        Console.WriteLine("Marca:. {0}",this.marca);
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor:... {0}\n",this.cor);
    }    

}

class Aula44
{
    static void Main()
    {
        //PARA UTILIZAR UMA struct E ACESSAR SEUS MEMBROS BASTA ESTA CHAMADA, SEM A ESTANCIA DE UM OBJETO
        Carro c1;

        //AQUI AS PROPRIEDADES SAO ACESSADAS E DIRETAMENTE EDITADAS
        c1.marca="VW";
        c1.modelo="Golf";
        c1.cor="Azul";

        Console.WriteLine("Marca:. {0}",c1.marca);
        Console.WriteLine("Modelo: {0}",c1.modelo);
        Console.WriteLine("Cor:... {0}\n",c1.cor);

        //MAS TAMBEM É POSSIVEL CHAMAR O CONSTRUTOR DA ESTRUTURA E PASSAR OS VALORES PARA ELE, DA MESMA FORMA QUE SE ESTANCIA UM OBJETO
        Carro c2=new Carro("Honda","HRV","Prata");

        Console.WriteLine("Marca:. {0}",c2.marca);
        Console.WriteLine("Modelo: {0}",c2.modelo);
        Console.WriteLine("Cor:... {0}\n",c2.cor); 

        //DA MESMA FORMA PODE SE CRIAR MAIS METODOS E UTILIZALOS DE FORMA SIMILAR COM OBJETOS
        Carro c3=new Carro("VW","Fusca","Preto");
        c3.info();        
    }
}