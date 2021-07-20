using System;

class Aula10
{
    //ENUMERADOR CRIADO PARA OS DIAS DA SEMANA
    //CADA DIA DA SEMANA É UM TIPO E POSSUI UMA POSIÇÃO NO ENUMERADOR
    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){

        //VARIAVEL DS RECEBE O ENUMERADOR E O TIPO DOMINGO
        DiasSemana ds1 = DiasSemana.Domingo;

        Console.WriteLine(ds1);

        //COMO CADA POSIÇÃO DO ENUMERADOR É UM TIPO
        //PARA ACESSA LA PELO NÚMERO DA POSIÇÃO
        //É NECESSÁRIO REALIZAR UM CAST
        DiasSemana ds2 = (DiasSemana) 3;

        Console.WriteLine(ds2);

        //PARA ACESSAR O VALOR DO INDICE DO TIPO
        //É NECESSÁRIO FAZER UM CAST TRANFORMANDO ELE EM INTEIRO
        int ds3 = (int)DiasSemana.Sexta;

        Console.WriteLine(ds3);

        

        

    }
}