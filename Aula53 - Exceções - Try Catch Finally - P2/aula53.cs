using System;

class Area
{
    public static float quad(float bas,float alt)
    {
        if (bas==0 || alt==0)
        {
            //AQUI A EXCESSAO É DISPARADA MESMO FORA DO BLOCO try catch
            //SENDO VALIDADA PELO if E USANDO O TRATAMENTO DE EXCESSAO PARA PERSONALIZAR E TRATAR O ERRO
            throw new Exception("Base ou altura não pode ser igual a zero!");
        }
        return bas*alt;
    }
}

class Aula53
{
    static void Main()
    {
        float area=0;

        try
        {
            //OS VALORES PARA O METODO REALIZAR A OPERAÇAO SAO PASSADOS DENTRO DO try
            //COM A ENTRADA NO IF RETORNA A EXCESSAO
            //ENTAO A EXECUÇAO PASSA PARA OS BLOCOS catch E finally
            area=Area.quad(0,5F);
            Console.WriteLine("\nÁrea do quadrado: {0}",area);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("\nMensagem de erro: {0}",ex.Message);
        }finally
        {
            Console.WriteLine("Fim do processo.\n");
        }

        int n1,n2,res;
        res=n1=n2=0;

        //AQUI O ERRO NAO SERÁ FORÇADO 
        n1=10;
        n2=2;

        try
        {
            res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            //COM O throw MESMO QUE A OPERACAO NAO GERA ERRO A EXCESSAO É DISPARADA
            throw new Exception("CFB Cursos");
        }
        catch (System.Exception ex)
        {                          
            Console.WriteLine("Exception: {0}",ex);
            Console.WriteLine("Mensagem de erro: {0}",ex.Message);
            Console.WriteLine("Origem do erro: {0}",ex.Source);
            Console.WriteLine("Tipo de exceção: {0}",ex.GetType());
        }finally//O BLOCO finally SERÁ SEMPRE EXECUTADO, SENDO GERADO ERRO OU NAO
        {
            Console.WriteLine("Fim do programa!");
        }
    }
}