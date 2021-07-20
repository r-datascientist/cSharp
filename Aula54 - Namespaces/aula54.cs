using System;

//O namespace É UM MAIOR NIVEL DE ORGANIZAÇAO E ESPECIFICAÇAO DE CLASSES E IMPLEMENTAÇOES
namespace Calc1
{
    //COM O USO DE namespace É POSSÍVEL A CRIAÇAO DE CLASSES COM O MESMO NOME
    //MESMO COM IMPLEMENTAÇOES IGUAIS OU DIFERENTES, O QUE NAO É POSSIVEL SEM namespace
    class Area
    {
        public static float quad(float bas,float alt)
        {
            if(bas==0 || alt==0)
            {
                throw new Exception("Base ou altura não pode ser igual a zero!");
            }
            return bas*alt;
        }
    }
}

namespace Calc2
{   //AQUI É CLASSE ACIMA É DUPLICADA, MAS MESMO COM O MESMO NOME ELA SE DIFERE NA SUA CHAMADA, Calc2.Area
    class Area
    {
        public static float quad(float bas,float alt)
        {
            if(bas==0 || alt==0)
            {
                throw new Exception("Base ou altura não pode ser igual a zero!");
            }
            return bas*alt;
        }
    }
}


class Aula54
{
    static void Main()
    {
        float area=0;

        try
        {   //A CLASSE Calc1.Area É CHAMADA FAZENDO REFERENCIA AO namespace Calc1
            area=Calc1.Area.quad(0,5F);
            Console.WriteLine("\nÁrea do quadrado: {0}",area);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("\nMensagem de erro: {0}",ex.Message);
        }finally
        {
            Console.WriteLine("Fim do processo.\n");
        }
    }
}