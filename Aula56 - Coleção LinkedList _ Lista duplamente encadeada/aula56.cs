using System;
//TAMBEM NECESSARIO ADICIONAR A BIBLIOTECA PARA COLEÇOES GENERICAS
using System.Collections.Generic;

//LinkedList É UMA LISTA DUPLAMENTE ENCADEADA
//CADA ELEMENTO É UM NÓ QUE POSSUI UM LINK PARA O ELEMENTO POSTERIOR E O ELEMENTO POSTERIOR
//POR ESTES MOTIVOS SE DENOMINA DUPLAMENTE ENCADEADA

class aula56
{
    static void Main()
    {
        LinkedList<string> transp=new LinkedList<string>();

        //METODO AddFirst() PARA INSERÇAO DE ELEMENTOS NO INICIO DA LISTA
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        foreach (string t in transp)
        {
            Console.WriteLine("AddFirst: {0}",t);
        }        

        //METODO AddLast() PARA ADICIONAR O ELEMENTO NO FINAL DA LISTA
        transp.AddLast("Bicicleta");
        foreach (string t in transp)
        {
            Console.WriteLine("AddLast: {0}",t);
        }

        //METODO AddAfter() PARA ADICIONAR DEPOIS DE UM ELEMENTO ESPECIFICO
        //LinkedListNode<> PARA CRIAR UM NÓ DE ORIENTACAO
        //METODO FindLast() PARA ENCONTRAR O ULTIMO ELEMENTO ESPECIFICADO     
        LinkedListNode<string>noh1;
        noh1=transp.FindLast("Navio");
        //noh1=transp.FindLast("Navio").Next;//PROPRIEDADE Next PARA REFERENCIAR O PROXIMO ELEMENTO
        //noh1=transp.FindLast("Navio").Previous;//PROPRIEDADE Previous PARA REFERENCIAR O ELEMENTO ANTERIOR
        transp.AddAfter(noh1,"Patinete");

        foreach (string t in transp)
        {
            Console.WriteLine("AddAfter: {0}",t);
        }
        //METODO AddBefore() PARA ADICIONAR ANTES DE UM ELEMENTO ESPECIFICO
        //LinkedListNode<> PARA CRIAR UM NÓ DE ORIENTACAO
        //METODO FindLast() PARA ENCONTRAR O ULTIMO ELEMENTO ESPECIFICADO     
        LinkedListNode<string>noh2;
        noh2=transp.FindLast("Navio");
        transp.AddBefore(noh2,"Patins");

        foreach (string t in transp)
        {
            Console.WriteLine("AddBefore: {0}",t);
        }       

        //METODO Find() PARA VERIFICAR SE EXISTE DETERMINADO ELEMENTO NA LISTA
        //SE ESTE ELEMENTO NAO EXISTIR O METODO RETORNA null
        if (transp.Find("Navio") == null)
        {
            Console.WriteLine("Elemento não encontrado");
        }else
        {
            Console.WriteLine("Elemento encontrado");
        }          

        //METODO Remove() PARA REMOVER UM DETERMINADO ELEMENTO DA LISTA
        transp.Remove("Navio");
        foreach (string t in transp)
        {
            Console.WriteLine("Remove: {0}",t);
        } 

        //PARA REMOVER O PRIMEIRO ELEMENTO DA LISTA O METODO RemoveFirst()
        transp.RemoveFirst();
        foreach (string t in transp)
        {
            Console.WriteLine("RemoveFirst: {0}",t);
        }         

        //PARA REMOVER O PRIMEIRO ELEMENTO DA LISTA O METODO RemoveFirst()
        transp.RemoveLast();
        foreach (string t in transp)
        {
            Console.WriteLine("RemoveLast: {0}",t);
        }   

        //METODO Clear() PARA REMOVER TODOS OS ELEMENTOS DA LISTA
        transp.Clear();



    }
}