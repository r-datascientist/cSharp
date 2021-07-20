using System;

class Calculos{

    public int v1;
    public int v2;

    public Calculos(int v1, int v2){
        //this FAZ REFERENCIA AO OBJETO PRINCIPAL
        //DESSA FORMA A VARIAVEL QUE TEM ASSOCIADO O this SE REFERE AS VARIAVEIS DA CLASSE 
        //AS VARIAVEIS SEM ASSOCIACAO DO this SE REFEREM AO PARAMETROS DE ENTRADA DO METODO CONSTRUTOR
        this.v1=v1; 
        this.v2=v2;
    }

    public int Somar(){
    return v1+v2;
    }

    class Aula32{

        static void Main(){

            Calculos c=new Calculos(10,2);
            Console.WriteLine(c.Somar());

        }
    } 
}