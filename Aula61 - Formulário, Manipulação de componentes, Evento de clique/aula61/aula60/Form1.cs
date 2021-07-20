using System;
//AQUI ESTÁ A BIBLIOTECA QUE VINHA SENDO USADA PARA DICIONARIOS, LISTAS,FILAS E ETC
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//AQU O namespace COM O NOME DO PROJETO
namespace aula60
{
    //AQUI TEMOS A CLASSE F_Principal COM A HERANÇA : Form
    //CONCEITO DE HERANÇA DE CLASSE
    public partial class F_Principal : Form
    {
        //METODO F_Principal() É O CONSTRUTOR DA CLASSE F_Principal 
        //POIS POSSUI O MESMO NOME E FARA A INICIALIZAÇAO DOS MEMBROS DA CLASSE
        public F_Principal()
        {
            InitializeComponent();
        }

        //COM CLIQUE DUPLO NO BOTAO NA AREA DE DESIGN 
        //FOI ADICIONADO AUTOMATICAENTE O EVENTO CLIQUE
        //QUE É ESTE METODO btn_texto_Click()
        private void btn_texto_Click(object sender, EventArgs e)
        {
            //VARIAVEL string txt É CRIADA PARA RECEBERO O VALOR DIGITADO NO TEXTBOX 
            string txt;
            //VARIAVEL RECEBENDO A PROPRIEDADE Text DO TEXTBOX DE NOME tb_texto
            txt = tb_texto.Text;
            //PARA QUE COM O CLIQUE DO BOTAO O TEXTO DO TEXTBOX SEJA RECEBIDO NO LABEL
            //O LABEL lb_texto RECEBE NA SUA PROPRIEDADE Text O VALOR DA VARIAVEL txt
            lb_texto.Text = txt;
       
            //UMA FORMA CONTRAIDA DE EXECUTAR A MESMA OPERAÇAO ACIMA É

            //lb_texto.Text = tb_texto.Text;

            //DESTA FORMA COM A EXECUÇAO DO EVENTO, COM O CLIQUE NO BOTAO
            //ESTE METODO É EXECUTADO E DIRETAMENTE O TEXTO DO LABEL RECEBE O TEXTO DO TEXTBOX
        }
    }
}
