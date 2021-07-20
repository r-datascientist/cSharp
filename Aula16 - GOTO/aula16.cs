using System;

class Aula16
{
    static void Main(){

        int tempo = 0;
        char escolha;

        inicio:

        Console.Write("Escolha um transporte: [a]Avião [c]Carro [o]Ônibus: ");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 680;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.Write("Transporte Indisponível.");
        }
        else
        {
            Console.WriteLine("\nPara o Transporte escolhido o tempo é: " + tempo);
        }

        //INICIA BLOCO GOTO PARA RETORNAR A EXECUÇÃO PARA O INICIO DO PROGRAMA
        Console.WriteLine("\nCalcular outro transporte? [s/n]");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.Write("Fim do programa!");
        }
    }
}