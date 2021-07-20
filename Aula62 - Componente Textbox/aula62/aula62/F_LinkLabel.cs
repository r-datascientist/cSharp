using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA71 DUPLOCLIQUE EM EVENTS LinkClicked DOS ELEMENTOS LinkLabel PARA CRIAÇAO DE EVENTO DE REDIRECIONAMENTO PARA LINK APÓS O CLIQUE

namespace aula62
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            //AQUI NO CONSTRUTOR DA CLASSE ESTAO SENDO ATRIBUIDOS MAIS DE UM LINK PARA O MESMO LinkLabel
            //COM A PROPRIEDADE Links E O METODO Add() PASSANDO EM QUAL POSIÇAO (COMO UM INDICE) DO LinkLabel COMEÇA O LINK
            //E QUAL SEU TAMANHO TOTAL, ALEM DA PROPRA URL DO LINK
            //POREM EVENTO LinkClicked DEVE DA MESMA FORMA SER CRIADO, PARA EXECUTAR O REDIRECIONAMENTO COM O CLIQUE
            ll_links.Links.Add(0,6,"www.google.com.br");
            ll_links.Links.Add(9,5,"www.youtube.com/cfbcursos");
            ll_links.Links.Add(17,7,"www.youtube.com");

            //PARA DESABILITAR UM LINK UTILIZANDO A PROPRIA COLEÇAO DE LINKS DO LinkLabel COM O INDICE CORRESPONDENTE AO LINK NA PROPRIEDADE Links
            //E TAMBEM A PROPRIEDADE Enabled ATRIBUINDO O VALOR false
            ll_links.Links[2].Enabled = false;
        }

        //EVENTO CRIADO PARA REDIRECIONAMENTO PARA LINK APÓS CLIQUE NO ELEMENTO LinkLabel
        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //AQUI ESTÁ SENDO CHAMADO UM PROCESSO DO WINDOWS QUE PARA ABRIR A URL PASSADA IRÁ EXECUTAR O NAVEGADOR PADRAO
            //APÓS A URL ESTA SENDO CONCATENADO DIRETAMENTE O TEXTO QUE ESTIVER NO TEXTBOX 
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos/nome=" + tb_nome.Text);

            //DEFININDO PROPRIEDADE LinkVisited = true PARA MARCAR LINK COMO VISITADO APOS O CLIQUE
            ll_canal.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //A MESMA LÓGICA ANTERIOR POREM AQUI ESTA SENDO DIRETAMENTE EXECUTADO UM PROGRAMA NATIVO DO SISTEMA OPERACIONAL
            //DA MESMA FORMA PODERIA SER PASSADO O CAMINHO ABSOLUTO DO ARQUIVO NO SISTEMA
            System.Diagnostics.Process.Start("calc.exe");

            //OUTRA FORMA DE ADMINISTRAR O ELEMENTO E DEFINI LO COMO VISITADO É
            //CRIAR UMA VARIAVEL DO PROPRIO TIPO LinkLabel E ATRIBUIR A ELA O PROPRIO ELEMENTO QUE ESTÁ SENDO PASSADO NO PARAMETRO object sender
            LinkLabel ll = (LinkLabel)sender;

            //ENTAO ATRIBUIR A PROPRIEDADE LinkVisited DA VARIAVEL DE TIPO LinkLabel O VALOR TRUE
            ll.LinkVisited = true;
        }

        private void ll_links_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //VEMOS QUE NESTE METODO LinkClicked SAO PASSADOS DOIS PARAMETROS object sender, LinkLabelLinkClickedEventArgs e
            //object sender CONTEM O PROPRIO ll_links_LinkClicked
            //LinkLabelLinkClickedEventArgs e CONTEM A AREA QUE FOI CLICADA NO OBJETO, OU SEJA, QUAL LINK FOI CLICADO
            //ENTAO BASTA UTILIZAR O PARAMETRO e COM A PROPRIEDADE Link E A PROPRIEDADE LinkData, CONVERTENDO O RETORNO PARA STRING 
            //PARA RECEBER O LINK E A URL CORRESPONDENTES AO CLIQUE
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //NESTE CASO COMO ESTAMOS TRABALHANDO COM O PARAMETRO e SERÁ UTILIZADO EM SEPARADO A PROPRIEDADE Link E ATRIBUIDO TRUE PARA A PROPRIEDADE Visited
            e.Link.Visited = true;

        }
    }
}
