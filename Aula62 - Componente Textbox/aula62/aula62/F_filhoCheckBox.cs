using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA67 OS ELEMENTOS CHECKBOX DO F_CheckBox [Design] FORAM DIRETAMENTE COPIADOS E COLADOS PARA O F_filhoCheckBox [Design]
//AULA67 OS ELEMENTOS CHECKBOX F_CheckBox [Design] TIVERAM SUA PROPRIEDADE Modifiers ALTERADA PARA Public
//AULA67 EM CADA ELEMENTO CHECKBOX TEVE CLIQUE  DUPLO EM EVENTS CheckedChanged CRIAÇAO AUTOMATICA DE EVENTO PARA PASSAR VALORES

namespace aula62
{
    public partial class F_filhoCheckBox : Form
    {
        //CRIADA VARIAVEL DO TIPO DO FORMULARIO DE ONDE SERAO RECEBIDOS OS VALORES DOS CHECKBOX
        public F_CheckBox fcb;
        public F_filhoCheckBox()
        {
            InitializeComponent();

            //IMPORTANTE QUE Application.OpenForms[] SÓ PODE SER EXECUTADO COM O FORMULARIO ABERTO
            //POR TANTO ESTÁ SENDO USADO UM TRATAMENTO try PARA CASO O FORMULARIO NAO ESTEJA ABERTO O ERRO SER TRATADO
            try
            {
                //AQUI A VARIAVEL RECEBE UMA COLEÇAO DO TIPO FORMULARIO, QUE É CONVERTIDA NO TIPO F_CheckBox
                fcb = Application.OpenForms["F_CheckedListBox"] as F_CheckBox;

                //ENTAO CADA CHECKBOX DESTE FORMULARIO F_filhoCheckBox VAI SER FLEGADO CONFORME O SEU CHECKBOX REFERENCIA NO FORMULARIO PAI F_CheckBox
                cb_carro.Checked = fcb.cb_carro.Checked;
                cb_aviao.Checked = fcb.cb_aviao.Checked;
                cb_navio.Checked = fcb.cb_navio.Checked;
                cb_onibus.Checked = fcb.cb_onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir formulario!");
            }
        }


        //CADA CHECKBOX TERÁ UM EVENTO ONDE AGORA TAMBEM PASSARA SEU VALOR PARA O CHECKBOX DO FORMULARIO PAI
        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            //DA MESMA FORMA SE O FORMULARIO NAO ESTIVER ABERTO E GERAR ERRO NO OpenForms[] IRÁ GERAR NA PASSAGEM DE DADOS, POIS O FORMULARIO NAO ESTA ABERTO
            try
            {
                fcb.cb_carro.Checked = cb_carro.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar CheckedChanged!");
            }
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fcb.cb_aviao.Checked = cb_aviao.Checked;
        }
            catch
            {
                MessageBox.Show("Erro ao carregar CheckedChanged!");
            }
}

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fcb.cb_navio.Checked = cb_navio.Checked;
}
            catch
            {
                MessageBox.Show("Erro ao carregar CheckedChanged!");
            }
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fcb.cb_onibus.Checked = cb_onibus.Checked;
}
            catch
            {
                MessageBox.Show("Erro ao carregar CheckedChanged!");
            }
        }
    }

}

