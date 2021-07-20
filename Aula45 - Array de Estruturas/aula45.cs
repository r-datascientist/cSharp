using System;

struct Carro
{
    public string modelo;
    public string cor;

    public void info()
    {
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor:... {0}\n",this.cor);
    }    

}

class Aula45
{
    static void Main()
    {
        //PARA CRIAR UM ARRAY DE ESTRUTURAS (structs) BASTA SEGUIR A SINTAXE PADRAO DE CRIAÇAO DE ARRAYS
        //BASICAMENTE ESTE É UM ARRAY DO TIPO struct COMO SE FOSSE POR EXEMPLO UM ARRAY DE UM TIPO PRIMITIVO QUALQUER
        Carro[] carros=new Carro[5];

        //COMO SE ESSE FOSSE UM ARRAY COMUM CADA POSIÇAO DO INDICE É POPULADA
        carros[0].modelo="HRV";
        carros[0].cor="Prata";

        carros[1].modelo="Golf";
        carros[1].cor="Azul";

        carros[2].modelo="Jetta";
        carros[2].cor="Branco";

        //A MANIPULACAO E O ACESSO DO ARRAY DE ESTRUTURAS POR METODOS TAMBEM PODE SER FEITA DIRETAMENTE PELOS INDICES
        carros[0].info();
        carros[1].info();
        carros[2].info();       

        //AINDA NORMALMENTE PODE SER TRABALHADO COM UM LOOP
        for (int i = 3; i < carros.Length; i++)
        {
            carros[i].modelo="Fusca";
            carros[i].cor="Preto";

            carros[i].info();            
        }
    }
}