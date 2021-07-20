using System;

//UMA INTERFACE NAO PODE CONTER PROPRIEDADES
//SEUS METODOS NAO PODEM SER IMPLEMENTADOS, APENAS PODEM SER ASSINADOS 
//OBRIGATORIAMENTE DEVEM SER IMPLEMTAOS NAS CLASSES QUE UTILIZAREM ESTA INTERFACE
public interface Veiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface Combate
{
    void disparar();
}

class Carro:Veiculo,Combate
{
    //COMO AS INTEFACES NAO PODEM CONTER PROPRIEDADES ELAS DEVEM SER CRIADAS NAS CLASSES DERIVADAS
    public bool ligado;
    private int municao;

    public Carro()
    {
        setMunicao(100);
    }

    public void setMunicao(int qtde)
    {
        this.municao=qtde;
    }

    //OS METODOS DEVEM SER IMPLEMENTADOS OU NO MINIMO OBRIGATORIAMENTE ASSINADOS NAS DERIVADAS
    public void ligar()
    {
        this.ligado=true;
    }

    public void desligar()
    {
        this.ligado=false;
    }

    public void disparar(){} 

    public void info(){}
}

class Aula43
{
    static void Main()
    {

    }
}