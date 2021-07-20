using System;

public class Jogador
{
    int energia;
    bool vivo;
    string nome;
    int inf;
    //O CONCEITO DE SOBRECARGA DE MÉTODOS/CONSTRUTORES ASSOCIA O MÉTODO CORRESPONDENTE PELA QUANTIDADE DE PARAMETROS PASSADOS
    //NESTE PRIMEIRO CONSTRUTOR NÃO SÃO PASSADOS NENHUM PARAMETRO, DESSA FORMA SERÃO MANTIDOS OS VALORES ATRIBUIDOS PARA AS PROPRIEDADES
    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    //ESTE SEGUNDO CONSTRUTOR RECEBE O ARGUMENTO n QUE É PASSADO NA CRIAÇÃO DO OBJETO COM A CHAMADA DO MÉTODO
    public Jogador(string n){
        energia = 90;
        vivo = true;
        nome = n;
    }
    //ESTE TERCEIRO CONSTRUTOR RECEBE OS ARGUMENTOS n E e QUE SÃO PASSADOS NA CRIAÇÃO DO OBJETO COM A CHAMADA DO MÉTODO
    public Jogador(string n, int e){
        energia = e;
        vivo = true;
        nome = n;
    }
    //ESTE QUARTO CONSTRUTOR RECEBE OS ARGUMENTOS n,e E v QUE SÃO PASSADOS NA CRIAÇÃO DO OBJETO COM A CHAMADA DO MÉTODO
    public Jogador(string n, int e, bool v){
        energia = e;
        vivo = v;
        nome = n;
    }
    //ESTE QUINTO CONSTRUTOR ALÉM DOS ARGUMENTOS QUE OS MÉTODOS ANTERIORES RECEBEM
    //ELE RECEBE i DIRETAMENTE DO TECLADO NA CRIAÇÃO DO OBJETO E UTILIZA PARA FAZER A IMPRESSÃO
    //SEM QUE SEJA NECESSÁRIO O OBJETO CHAMAR O METODO DE IMPRESSÃO 
    public Jogador(string n, int e, bool v, int i){
        energia = e;
        vivo = v;
        nome = n;
        inf = i;

        if (i < 1)
        {
            Console.WriteLine("\nNome do Jogador:......{0}", nome);
        }else if (i < 2)
        {
            Console.WriteLine("\nNome do Jogador:......{0}", nome);
            Console.WriteLine("Energia do Jogador:...{0}", energia);            
        }
        else{
            info();
        }
    }
    //DA MESMA FORMA A SOBRECARGA DE METODOS SIMPLES, QUE NÃO SÃO CONSTRUTORES
    //ESTE PRIMEIRO NÃO RECEBE NENHUM PARAMETRO E EXECUTA A IMPRESSÃO DIRETAMENTE PELAS PROPRIEDADES DA CLASSE
    public void info(){
        Console.WriteLine("\nNome do Jogador:......{0}", nome);
        Console.WriteLine("Energia do Jogador:...{0}", energia);
        Console.WriteLine("Estado do Jogador:....{0}", vivo);
    }
    //ESTE SEGUNDO NO CONCEITO DE SOBRECARGA RECEBE UM ARGUMENTO DE ENTRADA ATRAVEZ DO TECLADO
    //COM A ESTRUTURA CONDICIONAL EXECUTA IMPRESSÕES OU TAMBÉM CHAMA O MÉTODO ANTERIOR PARA FAZE LAS
    public void info(int i){

        if (i < 1)
        {
            Console.WriteLine("\nNome do Jogador:......{0}", nome);
        }else if (i < 2)
        {
            Console.WriteLine("\nNome do Jogador:......{0}", nome);
            Console.WriteLine("Energia do Jogador:...{0}", energia);            
        }
        else{
            info();
        }
    }
}

class Aula30{
    static void Main(){
        int i;
        Console.WriteLine("Digite 0 para Nome, 1 para Nome e Energia e 2 para tudo");
        i = Convert.ToInt32(Console.ReadLine());
        //OBJETOS SÃO CRIADOS E OS ARGUMENTOS SÃO ATRIBUIDOS, CADA CONSTRUTOR SERÁ REFERENCIADO DE ACORDO COM ESTES PARAMETROS
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Josué");
        Jogador j3 = new Jogador("Zeca", 99);
        Jogador j4 = new Jogador("Juca", 0, false);
        Jogador j5 = new Jogador("Pedro", 0, false);
        //OBJETO j6 FAZ A IMPRESSÃO DIRETAMENTE NO CONSTRUTOR
        Jogador j6 = new Jogador("João", 0, false, i);

        //OBJETOS CHAMAM OS METÓDOS SIMPLES PARA IMPRESSÃO
        j1.info();
        j2.info();
        j3.info();
        j4.info();
        //OBJETO j5 PASSANDO UM PARAMETRO E UTILIZANDO A SOBRECARGA DE METODOS SIMPLES
        j5.info(i);
    }    
}