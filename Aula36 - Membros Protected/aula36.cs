using System;

class Veiculo{//CLASSE BASE
    public int velAtual;
    private int velMax;
    //DIFERENTE DAS PROPRIEDADES private AS PROPRIEDADES protected PODEM SER ACESSDAS DIRETAMENTE NAS CLASSES DERIVADAS
    //MAS SOMENTE NAS CLASSES DERIVADAS, SE POR EXEMPLO UM OBJETO ESTANCIADO A PARTIR DE UMA CLASSE DERIVADA, 
    //FOR CHAMADO FORA DO ESCOPO DESTA CLASSE, O ACESSO NAO SERÁ VÁLIDO
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }

    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{

    public string nome;
    //DIFERENTEMENTE DA AULA ANTERIOR, NESTE CASO O PARAMETRO DO CONSTRUTOR DA CLASSE BASE É RECEBIDO COMO UM PARAMETRO DO CONSTRUTOR DA CLASSE DERIVADA 
    //E PASSADO DIRETAMENTE PARA A CLASSE BASE COMO UMA VARIAVEL NO COMANDO base
    public Carro(string nome, int vm):base(vm){
        this.nome=nome;
        ligado=true;
    }
}

class Aula36{

    static void Main(){

        Carro car=new Carro("Bonitão",120);

        Console.WriteLine("Nome:....... {0}",car.nome);
        Console.WriteLine("Ligado:..... {0}",car.getLigado());
        Console.WriteLine("Vel.Máxima:. {0}",car.getVelMax());


    }
}