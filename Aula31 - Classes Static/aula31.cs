using System;

//CLASSE STATIC
//CLASSES ESTATICAS NÃO PERMITEM ESTANCIAR OBJETOS A PARTIR DELA, NÃO PERMITEM TAMBÉM O USO DE CONSTRUTORES
//TODOS OS MEMBROS DA CLASSE ESTATICA OBRIGATORIAMENTE DEVEM SER ESTATICOS
static class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){
        nome = n;
        energia = 100;
        vivo = false;
    }
    static public void imp(){
        Console.WriteLine(nome);
    }
    //SOBRECARGA DE METODOS STATIC
    static public void imp(bool v){
        Console.WriteLine(vivo);
    }
}
//CLASSE NÃO STATIC UTILIZANDO UMA PROPRIEDADE COMO STATIC
//A VARIAVEL alerta COMO STATIC 
class Inimigo
{
    static public bool alerta;
    public string nome;

    //CONSTRUTOR SETANTO A PROPRIEDADE STATIC COMO false 
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    //METODO PARA FAZER A IMPRESSÃO
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("==============================");
    }     
}
class Aula31
{
    static void Main(){
        //OS MEMBROS DA CLASSE STATIC SÃO ACESSADOS DIRETAMENTE PELO NO DA CLASSE SEGUIDO DE PONTO E O NOME DO MEMBRO
        //PERMITINDO O ACESSO A CLASSE STATIC EM QUALQUER ELEMENTO DO PROGRAMA SEM TER QUE INSTANCIAR OBJETOS 
        //SENDO QUE A QUALQUER MOMENTO QUE A REFERIDA CLASSE STATIC FOR ALTERADA, SE REFLETIRA EM TODOS OS ELEMENTOS QUE A REFERENCIAM
        Jogador.iniciar("Pedro");
        Jogador.imp();
        Console.WriteLine(Jogador.energia);
        Jogador.imp(Jogador.vivo);

        //OBJETOS DA CLASSE NÃO ESTATICA PARA TESTAR A PROPRIEDADE ESTATICA
        Inimigo i1 = new Inimigo("Lucas");
        Inimigo i2 = new Inimigo("Thiago");
        Inimigo i3 = new Inimigo("Matheus");

        //A VARIAVEL STATIC É ACESSADA DA MESMA FORMA QUE UMA CLASSE STATIC, PELO NOME DA CLASSE SEGUIDO DE PONTO E O NOME DA VARIAVEL
        //ISTO GARANTE QUE TODOS OS OBJETOS ESTARÃO APONTANDO PARA ESTA MESMA PROPRIEDADE, OU SEJA
        //TODOS OS MEMBROS QUE ESTIVEREM ACESSANDO ESSA VARIAVEL TERÃO O VALOR SETADO CONFORME ESTE COMANDO DETERMINA
        Inimigo.alerta = true;

        //IMPRESSÃO DOS OBJETOS DA CLASSE NAÕ ESTATICA
        i1.info();
        i2.info();
        i3.info();
    }
    
} 