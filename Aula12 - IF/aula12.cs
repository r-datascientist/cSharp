using System;

class Aula12
{
    static void Main(){
        //DECLARANDO VARIAVEIS E ATRIBUINDO VAlORES EM CONJUNTO
        int nota1, nota2, nota3, nota4, total;
        nota1 = nota2 = nota3 = nota4 = total = 0;

        string resultado = "Reprovado";
        //IMPRIME NA TELA MENSAGEM
        Console.Write("\nDigite a nota 1: ");
        //RECEBE O VALOR DE ENTRADA DA NOTA
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        nota4 = int.Parse(Console.ReadLine());

        total = nota1 + nota2 + nota3 + nota4;
        //SE A CONDIÇÃO (nota >= 60) FOR VERDADEIRA O BLOCO SERÁ EXECUTADO
        //SENÃO ESTE BLOCO NÃO SERÁ EXECUTADO PULANDO PARA O PRÓXIMO
        // OPERADORES LÓGICOS: > < >= <= == !=
        if (total >= 60)// OUTRA OPÇÃO IF((NOTA1+NOTA2+NOTA3+NOTA4) >= 60)
        {
            resultado = "Aprovado";
        }

        Console.WriteLine("\nNota final: {0} \nResultado: {1}", total, resultado);
    }
}