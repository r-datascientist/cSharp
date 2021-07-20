using System;

class Aula14
{
    static void Main(){

        int nota = 0;
        string resultado;

        Console.Write("\nDigite Sua nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 60)
        {
            if (nota >= 100)
            {
                resultado = "Aprovado com louvor!";
            }
            else if (nota >= 90)
            {
                resultado = "Aprovado com mérito!";
            }
            else
            {
                resultado = "Aprovado!";
            }
        }
        else
        {
            if (nota >= 40)
            {
                resultado = "Em Recuperação...";
            }
            else
            {
                resultado = "Reprovado.";
            }
        }

        Console.Write("Você está: " + resultado);
    }
}