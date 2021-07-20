using System;

class Aula24{
/*
    //O METODO1 FOI CRIADO MAS NÃO FOI EVOCADO NENHUMA VEZ
    //ENTÃO O METODO NÃO SERÁ EXECUTADO
    static void Main(){

    }
*/
    //ESTÁ É A ESTRUTURA BASICA DO METODO
    //QUANDO O MÉTODO PRINCIPAL FOR STATIC TODOS METODOS NESTE ESCOPO DEVEM SER STATIC
    //TIPO DE RETORNO VOID É O TIPO QUE NÃO RETORNA VALORES
    //NOME DO METODO, CURTO E INTUITIVO
    static void metodo1(){
        Console.WriteLine("Metodo 1");
    }

    //QUANTOS FOREM ESCRITOS DENTRO DO METODO SERÃO TAMBÉM EXECUTADOS QUANDO ELE FOR EVOCADO
    static void metodo2(){
        Console.WriteLine("CFB Cursos");
        Console.WriteLine("Curso Completo de C#");
        Console.WriteLine("youtube.com/cfbcursos");
    }    

/*    
    //AGORA O METODO1 FOI EVOCADO E SERÁ EXECUTADO UMA VEZ
    static void Main(){
        metodo1();
    }
*/
/*       
    //O METODO SERÁ EXECUTADO QUANTAS VEZES FOR EVOCADO
    static void Main(){
        metodo1();
        metodo1();
        metodo1();
        metodo1();
        metodo1();
    }
*/
 /*
    //A EVOCAÇÃO PODE SER FEITA ATRAVEZ DE UM LOOP
    //FAZENDO COM QUE A EXECUÇÃO TAMBÉM SEJA FEITA REPETIDADMENTE
    static void Main(){
        for (int i = 0; i < 10; i++)
        {
            metodo1();
        }
    }
*/
/*
    //FAZENDO EVOCAÇÃO DE METODO2 COM MULTIPLOS COMANDOS
    static void Main(){
    
        metodo2();   
    }
*/
/*
    //AGORA UM METODO QUE RECEBE DOIS PARAMETROS DE ENTRADA E OS SOMA
    //QUANDO O MÉTODO É CHAMADO SÃO PASSADOS OS DOIS PARAMETROS
    static void Main(){
        soma(10,5);
    }
    //AS VARIAVEIS n1 E n2 DECLARADAS SÃO OS PARAMETROS DE ENTRADA DO METODO
    static void soma(int n1, int n2){
        int res = n1 + n2;//VARIAVEL res RECEBE A SOMA DOS PARAMETROS DE ENTRADA
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }
*/
/*
    //AGORA METODO RECEBENDO VALORES DIRETAMENTE DO DECLADO
    //DIRETAMENTE NO METODO DE CHAMADA SÃO COLETADOS OS VALORES DO TECLADO 
    //E DEPOIS PASSADAS AS VARIAVEIS JÁ POPULADAS NA CHAMADA DO METODO
    //NÃO NECESSÁRIAMENTE O METODO RECEBERÁ SOMENTE INT, PODENDO SER TRABALHADO COM OS MAIS DIVERSOS TIPOS
    static void Main(){
        int v1, v2;
        v1 = Convert.ToInt32(Console.ReadLine());//VALORES RECEBIDOS DO TECLADO SÃO DO TIPO STRING
        v2 = Convert.ToInt32(Console.ReadLine());//NECESSÁRIO REALIZAR CAST OU CONVERT PARA INT
        soma(v1,v2);
    }
    //O METODO É IDENTICO AO EXEMPLO ANTERIOR
    //SÓ A CHAMADA É DIFERENTE
    static void soma(int n1, int n2){
        int res = n1 + n2;//VARIAVEL res RECEBE A SOMA DOS PARAMETROS DE ENTRADA
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }
*/
/////////////////////////////////////////////////
///////////METODOS COM RETORNO///////////////////
/////////////////////////////////////////////////

//OS VALORES COLETADOS DO TECLADO SÃO CONVERTIDOS PARA INT E ARMAZENADOS NAS VARIAVEIS  v1 E v2
//AÍ ENTÃO A VARIAVEL r RECEBE O RETORNO DO METODO SOMA QUE PASSOU COMO PARAMETRO OS VALORES DE v1 E v2
//FINALMENTE A VARIAVEL r COM O RETORNO DO METODO É IMPRESSA
    static void Main(){
        int v1, v2, r;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        r = soma(v1, v2);
        Console.WriteLine("A Soma de {0} e {1} é: {2}", v1, v2, r);
        //TAMBÉM É POSSSIVEL FAZER A CHAMADA DO MÉTODO DIRETAMENTE NA IMPRESSÃO
        //DESSA FORMA O RETORNO DO METODO É RECEBIDO DIRETAMENTE PELO INDICE DA IMPRESSÃO
        //ESTA FORMA ANULA A NECESSIDADE DA CRIAÇÃO DA VARIAVEL DE RECEBIMENTO r, ECONOMIZANDO UMA POSIÇAO NA MEMORIA
        Console.WriteLine("A Soma de {0} e {1} é: {2}", v1, v2, soma(v1,v2));
    }
    static int soma(int n1, int n2){
        int res  = n1 + n2;
        return res;         
    }


 }
