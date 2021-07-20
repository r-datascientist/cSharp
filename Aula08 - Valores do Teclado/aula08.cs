using System;

class Aula08
{
    static void Main(){
        int v1, v2, soma;
        string nome;

        //METODO READLINE PARA PEGAR VALOR DIGITADO NO TECLADO
        //TODO VALOR RECEBIDO DO TECLADO É UMA STRING
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);

        Console.Write("Digite o primeiro valor: ");
        //PARSE CONVERTENDO STRING RECEBIDA DO TECLADO DIRETAMENTE PARA INT
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        //CONVERT CONVERTENDO PARA INT COM TOINT32
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1, v2, soma);
    }
}