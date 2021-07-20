
/*
//ESTRUTURA DE UMA CLASSE
//QUANDO NENHUM MODIFICADOR DE CLASSE É UTILIZADO, IMPLICITAMENTE A CLASSE É PUBLICA (public)
[ModificadorClasse] class NOME_DA_CLASSE
{   
    Variáveis / Propriedades
    [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

    //ESTRUTURA DE UM MÉTODO
    [EspecificadorAcesso] retorno NOME_METODO([argumento1,...]){
        //Corpo do método
    } 

}

//ModificadorClasse: Define a visibilidade da classe
    public: Classe pública, sem restrições de visualização.
    abstract: Classe-base para outras classes, não podem ser instanciados objetos desta classe, não podem ser criados objetos desta classe
    sealed: Esta classe não pode ser herdada
    static: Não permite instanciar objetos, porém seus membros podem ser acessados sem serem instanciados, todos os seus membros obrigatoriamente devem ser static

//EspecificadorAcesso(Válidos para métodos e para variáveis): Onde/por onde um membro da classe pode ser acessado
    public: Sem restrição de acesso, pode ser acessado por qualquer membro po de qualquer parte da classe
    private: Só pode ser acessado pela própria classe, só podendo ser manipulada por um método desta classe
    protected: Podem ser acessados na própria classe e nas classes derivadas (Herdadas)
    abstract: Os métodos não tem implementação, somente cabeçalho sem o corpo, suas difinições, suas operações, serão feitas nas classes que estão herdando a classe pai
    sealed: O método não pode ser redefinido, o seu comportamento padrão será sempre o mesmo
    virtual: Permite redifinição em uma classe derivada, um classe que herda a classe pai pode redefinir o comportamento do metodo
    static: Pode ser chamado mesmo que não tenha sido estanciado um objeto da classe, pode acessar este mesmo static sem ter que usar o operador new para instanciar um novo objeto da classe  

*/
using System;

public class Jogador//PARA UMA BOA PRÁTICA EM PADRÃO DE DADOS OS NOMES DE CLASSES SEMPRE INICIAM COM LETRA MAIUSCULA
{
    //DA MESMA FORMA NAS VARIÁVEIS SE O MODIFICADOR DE ACESSO NÃO FOR EXPLICITO, IMPLICITAMENTE ELE É PUBLICO (public)
    public int energia = 100;//AS VARIÁVEIS PODEM SER INICIALIZADAS AQUI COM SEU VALOR JÁ ATRBUIDO
    public bool vivo = true;//OU ENTÃO SEREM SOMENTE DECLARADAS E TEREM SEUS VALORES ATRIBUÍDOS DIRETAMENTE NO CONSTRUTOR

}
class Aula28
{
    static void Main(){
        //PROPRIEDADE new RESERVA/ALOCA PARA O OBJETO UMA NOVA MEMÓRIA E RETORNA O ENDEREÇO DESSE ESPAÇO
        //COM A PROPRIEDADE new UM NOVO OBJETO j1 FOI INSTANCIADO, UMA ENDEREÇO DA MEMÓRIA FOI RESERVADO PARA ESTE OBJETO
        //OUTROS OBJETOS PODEM SER INSTANCIADOS SOMENTE COM O SEU NOME DIFERENTE E CADA UM SERÁ INDEPENDENTE, TERÁ SUA POSIÇÃO NA MEMÓRIA 
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        Console.WriteLine("=================EXEMPLO 1=================");
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);

        //COMO energia e vivo SÃO PROPRIEDADES PUBLICAS ELAS PODEM SER SOMENTE ACESSADAS/LIDAS OU IMPRESSAS (COMO ACIMA) MAS TAMBÉM ALTERADAS NESTE ESCOPO
        j2.energia = 33;
        Console.WriteLine("=================EXEMPLO 2=================");
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

        //CADA OBJETO j1,j2,j3 É INDEPENDENTE PODEM SER TRABALHADO SEPARADAMENTE
        j3.energia = 22;
        Console.WriteLine("=================EXEMPLO 3=================");
        Console.WriteLine("Energia do jogador 3: {0}", j3.energia);
    }
}