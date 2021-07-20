using System;

class Calc
{

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

    //BASICAMENTE A RECURSIVIDADE É UM LOOP ONDE O METODO CHAMA ELE MESMO
    //DESSA FORMA É NECESSARIO UM CONTROLE PARA DETERMINAR A PARADA DO LOOP
    //O LOOP for PODE SER SUBSTUIDO PELA RECURSIVIDADE E VICE E VERSA
    //A OPERAÇAO FATORIAL É UM EXEMPLO CLASSICO DE RECURSIVIDADE
    //ONDE A MULTIPLICAÇAO SE DA EM REGIME DE ITERAÇAO DE FORMA SUBSEGUENTE 
    //DO VALOR DETERMINADO PARA CALCULO ATÉ 1
    //POR EXEMPLO FATORIAL DE 5: 5! = 5*4*3*2*1
    public int fat(int n)
    {
        int res;

        //AQUI AS REGRAS PARA RECURSIVIDADE NA OPEÇAO FATORIAL
        //NO if res RECEBE 1 CASO O PARAMETRO DE ENTRADA n SEJA MENOR OU IGUAL A 1
        //PORQUE NAO PODERIA SER CALCULADA FATORAÇAO MENOR DO QUE UM E SE FOR IGUAL A UM O RESULTADO SERA O PROPRIO UM
        if (n<=1)
        {
            res=1;
        }else
        {
            //NO CALCULO FATORIAL res RECEBE A MULTIPLICAÇAO DO PARAMETRO DE ENTRADA n PELA RECURSIVIDADE DO PROPRIO METODO
            //PASSANDO O PROPRIO n MENOS 1, ASSIM O VALOR DE ENTRADA É MULTIPLICADO POR ELE MESMO MENOS UM
            //SENDO VALIDADO O LIMITE DO LOOP PELO METODO SENDO CHAMADO RECURSIVAMENTE 
            res=n*fat(n-1);
        }
        return res;
    }


    class Aula48
    {
        static void Main()
        {
            Calc c1=new Calc();
            Calc c2=new Calc();

            var res=c1.fat(5);

            Console.WriteLine(res);
            Console.WriteLine(c2.fat(10));
        }
    }        
}