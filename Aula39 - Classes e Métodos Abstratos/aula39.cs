using System;


//CLASSES ABSTRATAS SÃO CLASSES DE REFERENCIA
//QUANDO UMA CLASSE É DECLARADA COMO ABSTRATA ELA IRÁ SERVIR DE BASE PARA OUTRAS CLASSES
//EM METODOS ABSTRATOS NÃO SÃO FEITAS IMPLEMENTAÇÕES, SOMENTE É CRIADO O PROTÓTIPO PARA SER HERDADO PELAS CLASSES DERIVADAS
//UMA CLASSE ABSTRATA PODE CONTER METODOS NÃO ABSTRATOS E IMPLEMENTADOS
//NÃO PODEM SER INSTANCIADOS OBJETOS A PARTIR DE UMA CLASSE ABSTRATA

abstract class Veiculo
{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado=false;
        velAtual=0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado=ligado;
    }

    public int getVelAtual()
    {
        return velAtual;
    }      

    //METODO ABSTRATO APENAS COMO PROTOTIPO, SEM NENHUMA IMPLEMENTACAO
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo
{
    public Carro()
    {
        velMaxima=120;
    }

    //OBRIGATORIAMENTE O METODO ABSTRATO TEM QUE SER IMPLEMENTADO NA CLASSE DERIVADA
    //PARA IMPLEMENTACAO O METODO ABSTRATO DA CLASSE BASE ABSTRATA É SUBSCRITO COM O override
    override public void aceleracao(int mult)
    {
        velAtual+=10*mult;
    }
}
class Aula39
{
    static void Main()
    {
        Carro c1=new Carro();

        c1.aceleracao(1);
        c1.aceleracao(2);
        c1.aceleracao(-1);

        Console.WriteLine(c1.getVelAtual());
    }
}