using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA68 ADICIONADO ELEMENTO CHECKED LISTBOX, EM PROPRIEDADES ITENS OU NA SETA DE OPÇOES DO ELEMENTO PODEM SER ADICIONADOS OU EDITADOS SUA LISTA DE CHECKBOX

namespace aula62
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        //EVENTO CLIQUE ADICIONADO COM CLIQUE DUPLO
        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            //CRIADA VARIÁVEL PARA RECEBER O ELEMENTO QUE ESTIVER COM O CHECKBOX SELECIONADO
            string txt = "";

            /*
              //PRIMEIRAMENTE UTILIZANDO A PROPRIEDADE Itens[] COMO UM ÍNDICE PERMITINDO TRABALHAR COM TODOS OS ITENS DO CHECKED LISTBOX
              txt = clb_transportes.Items[0].ToString();

            //COM A PROPRIEDADE CheckedItems TAMBEM É POSSIVEL USAR INDICE POREM AGORA SOMENTE COM OS ITENS QUE ESTIVEREM COM CHECKBOX SELECIONADOS
            txt = clb_transportes.CheckedItems[0].ToString();
          */

            //DESTA VEZ SEM UTILIZAR INDICE MAS UTILIZANDO UM LOOP PARA RETORNAR TODOS OS ITENS SELECIONADOS
            foreach(string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            //IMPRESSAO 
            MessageBox.Show(txt);


        }

        //EVENTO CLIQUE ADICIONADO PARA LIMPAR OS ITENS DO CHECKED LISTBOX
        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            //METODO Clear() PARA LIPAR TODOS OS ITENS DO LISTBOX
            clb_transportes.Items.Clear();
        }

        //EVENTO CLIQUE ADICIONADO PARA RESETAR A LISTA PARA OS ITENS DEFAULTS, POREM NA VERDADE ELES SERAO ADICIONADOS COM O CLIQUE
        private void btn_resetarlista_Click(object sender, EventArgs e)
        {
            //IMPORTANTE FAZER A LIMPEZA DOS ITENS ANTES DE ADICIONALOS NOVAMENTO
            //PARA ELES NAO SEJAM CONCATENADOS SENDO ADICIONADOS VARIAS VEZES SE O RESET FOR ACIONADO SEM SER ACIONADO O LIMPAR
            clb_transportes.Items.Clear();

            /*
              //METODO Add() PARA ADICIONAR ITENS
              //O PRIMEIRO PARAMETRO DE ENTRADA É O PROPRIO OBJETO/ITEM QUE SERÁ CRIADO, O SEGUNDO DETERMINA SE ELE ESTARÁ SELECIONADO OU NAO
              clb_transportes.Items.Add("Carro", false);
              clb_transportes.Items.Add("Avião", false);
              clb_transportes.Items.Add("Ônibus", false);
              clb_transportes.Items.Add("Trem", false);\
            */
            //AGORA SERÁ CRIADA UMA LISTA PARA ADICIONAR TODOS OS ITENS DO LISTBOX DE UMA VEZ SÓ
            List<string> tr = new List<string>();

            //ADICIONANDO OS ITENS NA LISTA
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Ônivus");
            tr.Add("Trem");

            //AQUI OS MEMBROS DA LISTA SAO ADICIONADOS AO LISTBOX TODOS DE UMA VEZ COM O METODO AddRange()
            //IMPORTE QUE A LISTA PRECISA SER CONVERTIDA PARA UM TIPO ARRAY COM O METODO ToArray(), POIS COMO LISTA NAO É UMA COLEÇAO
            clb_transportes.Items.AddRange(tr.ToArray());
        }

        //EVENTO ADICIONADO PARA ADICIONAR NOVO ITENS NO LISTBOX
        private void btn_adicionarTransportes_Click(object sender, EventArgs e)
        {
            //SOMENTE IRÁ ADICIONAR SE O TEXTBOX NAO TIVER VAZIO
            if (tb_novoTransporte.Text != "")
            {
                //ADICIONANDO O CONTEUDO DO TEXTBOX
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                //LIMPANDO O TEXTBOX
                tb_novoTransporte.Clear();
                //RETORNANDO O CURSOR PARA O TEXTBOX
                tb_novoTransporte.Focus();
            }
        }
    }
}
