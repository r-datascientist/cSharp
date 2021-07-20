using System;

class Calc
{
    //A SOBRECARGA DE METODOS ESTÁ SENDO FEITA COM METODOS COM O MESMO NOME COM TIPOS DE PARAMETROS DIFERENTES
    //CONFORME NA AULA27 QUE FORAM FEITOS TAMBEM COM METODOS DE QUANTIDADES DE PARAMETROS DIFERENTES COM A EXPRESSAO params
    //AQUI NESTE CASO ESTAO SENDO UTILIZADOS PARAMETROS SEM LIMITES DE QUANTIDADES E QUANTIDADES PRE DETERMINADAS
    //POIS OS METODOS RECEBEM ARRAYS COMO PARAMETROS 
    public int soma(params int[]n)
    {
        int s=0;
        for (int i = 0; i < n.Length; i++)
        {
            s+=n[i];
        }
        return s;
    }

    public double soma(params double[]n)
    {
        double s=0;
        for (int i = 0; i < n.Length; i++)
        {
            s+=n[i];
        }
        return s;
    }

    class Aula47
    {
        static void Main()
        {
            Calc c1=new Calc();
            Calc c2=new Calc();

            //COM ESTA SINTAXE A VARIAVEL res SENDO DECLARADA SEM UM TIPO EXPLICITO
            //PODERÁ RECEBER RETORNOS DE AMBOS OS METODOS DE TIPOS DIFERENTES
            //TENDO SEU TIPO DECLARADO IMPLICITAMENTE
            var res=c1.soma(12.1,8.6,3.2,1.5,10,5,-2);

            Console.WriteLine(res);
            Console.WriteLine(c2.soma(10,5,-2));
        }
    }        
}