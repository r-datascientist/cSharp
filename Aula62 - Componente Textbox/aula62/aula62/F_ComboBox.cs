using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA69 NO COMBOBOX EM EVENTS FOI ADICIONADO COM CLIQUE DUPLO O EVENTO SelectedIndexChanged, QUE SERÁ DISPARADO QUANDO O VALOR DO COMBO BOX FOR ALTERADO

namespace aula62
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        //EVENTO DE CLIQUE PARA MOSTRAR SELECIONADO
        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            //IMPRIMENTO NA TELA O TEXTO CONTIGO NO COMBOBOX 
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            //LIMPANDO PARA NAO CONCATENAR
            cb_transportes.Items.Clear();

            //CRIANDO LISTA PARA ARMAZENAR OS ITENS DO COMBOBOX
            List<string> tr = new List<string>();

            ////ADICIONANDO OS ITENS DO COMBOBOX
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Ônibus");
            tr.Add("Trem");

            ////ADICIONANDO NO COMBOBOX TODOS OS ITENS DE UMA SÓ VEZ
            cb_transportes.Items.AddRange(tr.ToArray());

        }

        //EVENTO DE CLIQUE PARA LIMPAR OS ITENS DO COMBOBOX
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //LIMPANDO OS ITENS DO COMBOBOX COM O METODO Clear()
            cb_transportes.Items.Clear();
        }

        //EVENTO ADICIONADO PARA NA ALTERAÇAO DO VALOR DO COMBOBOX ESTE NOVO VALOR SER PASSADO PARA O TEXTBOX
        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        //EVENTO CLIQUE PARA ADICIONAR NOVOS ITENS AO COMBOBOX
        private void btn_adicionarNovo_Click(object sender, EventArgs e)
        {
            //PRIMEIRAMENTE VALIDA SE O TEXTBOX NAO ESTA VAZIO
            if(tb_transporte.Text != "")
            {
                //COM O METODO FindString() É VERIFICADO SE NO ELEMENTO JÁ EXISTE O VALOR QUE ESTA SENDO ADICIONADO
                // O VALOR JÁ EXISTE O METODO RETORNA A POSIÇAO DO ELEMENTO E SE NAO EXISTE ELE RETORNA -1
                if (cb_transportes.FindString(tb_transporte.Text) < 0)
                {
                    //ADICIONANDO O TEXTO DO TEXTBOX COMO UM NOVO ITEM DO COMBOBOX
                    cb_transportes.Items.Add(tb_transporte.Text);

                    //LIMPANDO O TEXTBOX APÓS A ADIÇAO
                    tb_transporte.Clear();
                }
            }
        }
    }
}
