using System;

class Veiculo{//CLASSE BASE

    private int rodas;
    public int velMax;
    private bool ligado;
    //ESTE CONSTRUTOR DA CLASSE BASE POR SER O UNICO OBRIGA O RECEBIMENTO DE UM PARAMETRO, QUE DEVERÁ SER PASSADO PELA CLASSE DERIVADA
    public Veiculo(int rodas){
        this.rodas=rodas;        
    }

    public void ligar(){
        ligado=true;
    }

    public void desligar(){
        ligado=false;
    }

    public string getLigado(){
        //PARA RESUMIR A VALIDACAO FEITA NO IF PODE SE UTILIZAR OS OPERADORES TERNARIOS ? :
        //? REPRESENTA RETORNO VERDADEIRO E : FALSO
        return (ligado?"Sim":"Não");

/*      if (ligado)
        {
            return "Sim";
        }else
        {
            return "Não";
        }
*/
    }

    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas<0)
        {
            this.rodas=0;
        }else if(rodas>40)
        {
            this.rodas=40;
        }else
        {
            this.rodas=rodas;
        }
    }
}
//CLASSE DERIVADA
class Carro:Veiculo{

    public string nome;
    public string cor;
    //A EXPRESSAO :base() FAZ A PASSAGEM DE PARAMETRO PARA A CLASSE BASE
    public Carro(string nome, string cor):base(4){
        desligar();
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

//CADEIA DE HERANCA
class CarroCombate:Carro{

    public int municao;
    //DA MESMA FORMA A CLASSE BASE DESTA CLASSE DERIVADA É A CLASSE Carro, QUE HERDA A CLASSE BASE Veiculo
    //ENTÁO PASSA OS ARGUMENTOS PARA O CONSTRUTOR DE SUA CLASSE BASE
    //QUE PASSA O ARGUMENTO A CLASSE BASE Veiculo
    public CarroCombate():base("Carro de Combate","Preto"){
        municao=100;
        //COMO A PROPRIEDADE rodas É private PARA SER MANIPULADO AQUI DEVE SER ATRAVES DE UM METODO CRIADO NA SUA CLASSE
        setRodas(6);
    }
}

class Aula34{
    static void Main(){

        Carro c1=new Carro("Rapidão","Vermelho");
        c1.ligar();

        CarroCombate cc1=new CarroCombate();
        //PROPRIEDADES public PODEM SER ACESSADAS EM TODOS O ESCOPO SEM NECESSIDADE DE METODOS
        cc1.velMax=60;

        Console.WriteLine("Cor:........{0}",c1.cor);
        Console.WriteLine("Nome:.......{0}",c1.nome);
        Console.WriteLine("Rodas:......{0}",c1.getRodas());
        Console.WriteLine("Ligado:.....{0}",c1.getLigado());
        Console.WriteLine("Vel.Máxima:.{0}\n",c1.velMax);

        Console.WriteLine("Cor:........{0}",cc1.cor);
        Console.WriteLine("Nome:.......{0}",cc1.nome);
        Console.WriteLine("Rodas:......{0}",cc1.getRodas());
        Console.WriteLine("Munição:....{0}",cc1.municao);
        Console.WriteLine("Ligado:.....{0}",cc1.getLigado());
        Console.WriteLine("Vel.Máxima:.{0}",cc1.velMax);
        
    }
}