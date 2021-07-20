using System;

class Veiculo{//CLASSE BASE
    //COM O CONCEITO DE HERANÇA MESMO QUE NA CLASSE DERIVADA NADA SEJA IMPLEMENTADA ELA HERDARÁ TODOS OS MEMBROS DA CLASSE BASE
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
        if (ligado)
        {
            return "Sim";
        }else
        {
            return "Não";
        }
    }
}
//CLASSE DERIVADA
class Carro:Veiculo{
    //IMPORTANTE QUE MESMO EM CLASSES DERIVADAS NAO É POSSÍVEL ACESSAR MEMBROS private, POIS SÓ PODEM SER ACESSADOS DENTRO DE SUA CLASSE
    public string nome;
    public string cor;

    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class Aula34{
    static void Main(){
        //IGUALMETE FORA DA CLASSE BASE E DA CLASSE DERIVADA SÓ PODEM SER ACESSADAS PROPRIEDADES public
        Carro c1=new Carro("Rapidão","Vermelho");

        Console.WriteLine("Cor:........{0}",c1.cor);
        Console.WriteLine("Nome:.......{0}",c1.nome);
        Console.WriteLine("Rodas:......{0}",c1.rodas);
        Console.WriteLine("Ligado:.....{0}",c1.getLigado());
        Console.WriteLine("Vel.Máxima:.{0}",c1.velMax);
        
    }
}