using System;

class Jogador{

    //PROPRIEDADES private NAO PODEM SER ASSESSADAS FORA DA CLASSE
    //MESMO QUE UM OBJETO FOSSE ESTANCIADO A PARTIR DESTA CLASSE NAO TERIA ACESSO AS PROPRIEDADES private
    private int energia;
    private string nome;


    public Jogador(string nome){
        this.nome=nome;
        energia=100;
    }

    //PARA OBTER ACESSO PARA ESTAS PROPRIEDADES PRIVATE DEVEM SER CRIADOS METODOS
    public int getEnergia(){
        return energia;
    }
    //PARA PERMITIRQUE AS PROPRIEDADES private SEJAM ALTERADAS DEVE SE CRIAR METODOS
    //ESTE METODO PERMITE A ALTERACAO E GARANTE QUE ELA SE MANTENHA COM MAXIMO 100 E MINIMO 0
    public void setEnergia(int e){
        if (e<0)
        {   //ESTE PONTO O SINAL DE + GARANTE TAMBEM QUE DOIS SINAIS DE MENOS NAO ACABEM SOMANDO AO INVES DE SUBTRAIR
            if (energia+e < 0)
            {
                energia=0;
            }else
            {   //ESTE EH UM PONTO DE ATENCAO!!!
                //AQUI O SINAL DE + GARANTE QUE SE FOR INSERIDO UM VALOR NEGATIVO PARA SUBTRAIR DA PROPRIEDADE private 
                //ELE NAO SEJA SOMADO AO INVES DE SUBTRAIDO, PORQUE SERIAM DOIS SINAIS DE MENOS, E MENOS COM MENOS EH MAIS
                energia+=e;
            }
        }else if (e>0)
        {
            if (energia+e > 100)
            {
                energia=100;
            }else
            {
                energia+=e;
            }
        }
    }

    public string getNome(){
        return nome;
    }    
}
class Aula33{

    static void Main(){

        //ENTAO MESMO QUE O OBJETO SEJA ESTANCIADO OS VALORES SAO RECEBIDOS ATRAVES DA CHAMADA DOS METODOS
        Jogador j1=new Jogador("Bruno");

        j1.setEnergia(-150);

        Console.WriteLine("Nome:....{0}", j1.getNome());
        Console.WriteLine("Energia:.{0}", j1.getEnergia());
    }
}