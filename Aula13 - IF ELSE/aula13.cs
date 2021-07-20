using System;

class Aula13
{
    static void Main(){

        int nota = 0;
        string resultado;

        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota < 40)
        {
            resultado = "Reprovado. :o(";
        }
        else if(nota < 60)
        {
            resultado = "Em Recuperação... :oP";
        }
        else
        {
            resultado = "Aprovado! :o)";
        }    

        Console.WriteLine("Você está " + resultado);
    }
}