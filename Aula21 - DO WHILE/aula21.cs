using System;

class Aula21
{
    static void Main(){
        int num = 5;
        
        //DO WHILE PRIMERAMENTE EXECUTA E DEPOIS TESTA A EXPRESSÃO LÓGICA
        do
        {
            Console.WriteLine("CFB Cursos");
        } while (num < 5);

        //SEGUNDO EXEMPLO
        int tent = 0;
        string senha = "123";
        string user;
        //COMANDO DO WILE, GARANTE QUE O BLOCO É EXECUTADO PELO MENOS UMA VEZ
        do
        {
            Console.Clear();//LIMPAR TELA DO CONSOLE
            if (tent > 0)
            {
                Console.WriteLine("Senha incorreta!");
            }
            Console.WriteLine("Digite sua senha:");
            user = Console.ReadLine();
            tent++;
        } while (user != senha);
        Console.Clear();
        Console.WriteLine("Senha correta em {0} tentativas.", tent);

    }
}