using System;

class Aula52
{
    static void Main()
    {
        int n1,n2,res;
        res=n1=n2=0;

        //AQUI É FORÇADO O ERRO GERANDO UMA DIVISAO POR ZERO
        n1=10;
        n2=0;

        try
        {   //A OPERAÇAO CRITICA FICA DENTRO DO TRATAMENTO DE EXCESSOES
            //ENTAO SE ELA GERAR UM ERRO, ESTE SERÁ TRATADO
            res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
        }
        //O TRATAMENTO BASICO DA EXCESSAO PODE SER FEITO SOMENTE COM O catch
        catch (System.Exception ex)//POREM PARA ACESSAR E TRATAR TAMBEM O RETORNO DA EXECESSAO PELO SISTEMA
        {                          //BASTA PASSAR NO catch A CLASSE Exception E O PARAMETRO DE SAIDA PARA RECEBER ESTE RETORNO, ex

            //AQUI A MENSAGEM DE ERRO IMPRESSA PARA O USUARIO ESTA SENDO TRATADA E PERSONALIZADA
            //TANTO COM TEXTO QUANTO COM METODOS E MEMBROS DA CLASSE Exception
            Console.WriteLine("Exception: {0}",ex);
            Console.WriteLine("Mensagem de erro: {0}",ex.Message);
            Console.WriteLine("Origem do erro: {0}",ex.Source);
            Console.WriteLine("Tipo de exceção: {0}",ex.GetType());
        }
    }
}