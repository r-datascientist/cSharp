using System;

//CLASSES NAO ESTATICAS PODEM POSSUIR MEMBROS ESTATICOS
//DESSA FORMA SEUS METODOS E SUAS VARIAVES E SEUS METODOS PODEM SER ACESSADOS SEM A ESTANCIAÇAO DE OBJETOS
//UTLIZANDO SEMPRE A MESMA POSIÇAO NA MEMORIA
class Mat
{
    public static double pi = 3.14;
    
    public static int dobro(int n)
    {
        return n*2;
    }
}

class Aula49
{
    static void Main()
    {
        //OS MEMBROS SAO ACESSADOS CHAMANDO A CLASSE E O RESPECTIVO MEMBRO
        double vpi=Mat.pi;

        int num=10;

        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));
    }
}