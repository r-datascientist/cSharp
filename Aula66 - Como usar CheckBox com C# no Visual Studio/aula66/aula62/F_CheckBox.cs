using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA6 CADA VEZ QUE UM CHECKBOX É MARCADO OU DESMARCADO, O EVENTO CheckedChanged É ACIONADO AUTOMATICAMENTE

namespace aula62
{
    public partial class F_CheckBox : Form
    {
        //AQUI ESTÁ SENDO ESTANCIADA UMA COLEÇAO List DO TIPO CheckBox PARA VALIDAÇAO E IMPRESSAO
        List<CheckBox> transp = new List<CheckBox>();  
        public F_CheckBox()
        {
            InitializeComponent();

            //DENTRO DO CONSTRUTOR DA CLASSE SERAO ADICIONADOS OS CHECKBOX NA COLEÇAO
            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        //EVENTO CLIQUE ADICIONADO COM CLIQUE DUPLO NO BOTAO 
        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            //VARIAVEL CRIADA E INICIALIZADA PARA SER UTILIZADA NO IF
            string txt = "";

            //ESTA É A FORMA CONTRAIDA DE EXECUTAR A VALIDAÇAO UTILIZANDO UMA COLEÇAO E UM LOOP
            //A VARIAVEL t DO TIPO CheckBox RECEBE UM ELEMENTO DA LISTA transp A CADA VOLTA DO LOOP
            foreach(CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

//ESTA É UMA FORMA MAIS EXTENSA DE VALIDAÇAO SEM UTILIZAR UMA COLEÇAO OU UM ARRAY, COM UM LOOP
/*
            //PROPRIEDADE Checked RETORNA BOOL, RETORNA TRUE SE O CHECKBOX ESTIVER MARCADO E FALSE SE NAO
            if(cb_carro.Checked)
            {
                //COM O CHECKBOX MARCADO SERÁ PEGO O SEU TEXTO
                txt += cb_carro.Text + ", ";
            }

            if (cb_aviao.Checked)
            {
                //COM O CHECKBOX MARCADO SERÁ PEGO O SEU TEXTO
                txt += cb_aviao.Text + ", ";
            }

            if (cb_navio.Checked)
            {
                //COM O CHECKBOX MARCADO SERÁ PEGO O SEU TEXTO
                txt += cb_navio.Text + ", ";
            }

            if (cb_onibus.Checked)
            {
                //COM O CHECKBOX MARCADO SERÁ PEGO O SEU TEXTO
                txt += cb_onibus.Text + ", ";
            }
*/
            //AGORA ESTA SENDO IMPRESSA EM UMA CAIXA DE MENSAGEM A VARIAVEL COM OS TEXTOS DOS CHECKBOX MARCADOS CONCATENADOS 
            MessageBox.Show(txt);
        }

        //EVENTO ADICIONADO AUTOMATICAMENTE COM CLIQUE DUPLO NO EVENTO CheckedChanged DO CHECKBOX cb_patinete
        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            //AQUI ESTÁ SENDO VALIDADA A MARCAÇAO DO CHECKBOX EM TEMPO DE EXECUÇAO
            //QUANDO O CHECKBOX FOR MARCADO SERÁ IMPRESSA A MENSAGEM
            //QUANDO ELE FOR DESMARCADO NADA SERÁ EXECUTADO PORQUE NADA FOI IMPLEMENTADO
            if(cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado!");
            }
        }
    }
}
