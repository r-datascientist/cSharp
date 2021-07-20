using System;

//SEMPRE QUE HAJA HERANÇA E DERIVAÇAO DE HERANÇAS DE CLASSES A ORDEM DE EXECUÇAO DOS CONTRUTORES É SEMPRE DA BASE PARA AS DERIVADAS
class Base{

    public Base(){

        Console.WriteLine("Construto da Classe Base");
    }
}

class Derivada1:Base{

        public Derivada1(){

        Console.WriteLine("Construto da Classe Derivada 1");
    }
}

class Derivada2:Derivada1{

        public Derivada2(){

        Console.WriteLine("Construto da Classe Derivada 2");
    }
}

class Aula37{

    static void Main(){

        Derivada2 d2 = new Derivada2();

    }
}