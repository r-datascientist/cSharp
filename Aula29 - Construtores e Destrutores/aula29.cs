using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    //METODO CONSTRUTOR
    //PARA DEFINIR QUE UM METODO É O CONSTRUTOR DA CLASSE BASTA ELE TER O MESMO NOME DA CLASSE
    //ESTE METODO SERÁ EXECUTADO AUTOMATICAMENTE SEMPRE QUE UM OBJETO DESTA CLASSE FOR ESTANCIADO
    public Jogador(string n){//METODOS CONSTRUTORES TAMBEM PODEM RECEBER PARAMETROS COMO METODOS CONVENCIONAIS
        energia = 100;//COM A DECLARAÇÃO DO METODO CONSTRUTOR AS PROPRIEDADES NÃO SÃO MAIS INICIALIZADAS NA CLASSE
        vivo = true;//MESMO QUE SEJA POSSIVEL INICIALIZAR AS VARIAVEIS DIRETAMENTE NA DECLARAÇÃO NA CLASSE, 
        nome = n;//O IDEAL É FAZER ISSO NO METODO CONSTRUTOR
        
    }
    //METODO DESTRUTOR
    //ESTE SERÁ EXECUTADO SEMPRE NO MOMENTO QUE O OBJETO FOR DESTRUÍDO PELO GARBAGE
    /*O coletor de lixo (garbage Collector) do .NET Framework gerencia a alocação e liberação de memória para sua aplicação. 
    Cada vez que você cria um novo objeto, o Common Language Runtime aloca memória para o objeto a partir do heap gerenciado. 
    Enquanto os espaços de endereços estão disponíveis no heap gerenciado, o runtime continua a alocar espaço para novos objetos.*/
    //http://www.macoratti.net/14/09/c_garb1.htm
    ~Jogador(){//PARA ATRIBUIR UM DESTRUTOR BASTA QUE ELE TENHA O MESMO NOME DA CLASSE ANTECEDIDO DE ~
        Console.WriteLine("Jogador {0} foi destruido.", nome);
    }
}

class Aula29
{
 static void Main(){
     //ESTA SEGUNDA VARIAVEL nome NÃO TEM RELAÇÃO COM A VARIAVEL nome ACIMA
     //POIS A PRIMEIRA TEM O ESCOBO GLOBAL DA CLASSE Jogador E ESTA SEGUNDA O ESCOPO LOCAL DO METODO Main()
     string nome;
     Console.WriteLine("Digite o nome 1: ");
     nome = Console.ReadLine();
     Jogador j1 = new Jogador(nome);
     Jogador j2 = new Jogador("Théo");

     Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
     Console.WriteLine("Nome do jogador 2: {0}", j2.nome);
 }
}