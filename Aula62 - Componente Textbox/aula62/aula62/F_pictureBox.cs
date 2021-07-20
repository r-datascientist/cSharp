using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EM Solution Explore > Properties, CLIQUE DUPLO EM Resources.resx, SAO CONFIGURADOS RECURSOS QUE PODEM SER UTILIZADOS EM TODO O PROGRAMA APENAS SENDO CHAMADOS
//NAS PROPRIEDADES DO PICTUREBOX, A DIMENSÃO DA IMAGEM É CONFIGURA EM SizeMode

namespace aula62
{
    public partial class F_pictureBox : Form
    {
        public F_pictureBox()
        {
            InitializeComponent();
        }

        //EVENTO LOAD CRIADO PARA O FORMULARIO ONDE SERAO CARREGADOS OS RECURSOS CRIADOS E CHAMADOS LOGO NA ABERTURA DO FORMULARIO
        private void F_pictureBox_Load(object sender, EventArgs e)
        {
            l_nome.Text = Properties.Resources.nomeCanal;
            l_url.Text = Properties.Resources.urlCanal;
        }

        //EVENTO ADICIONADO PARA ALTERAR IMAGEM DO PICTUREBOX
        private void btn_imagem1_Click(object sender, EventArgs e)
        {
            pb_imagem.Image = Properties.Resources.localDeProjetosVisualStudioAutoneum;
        }

        //EVENTO ADICIONADO PARA ALTERAR IMAGEM DO PICTUREBOX
        private void btn_imagem2_Click(object sender, EventArgs e)
        {
            pb_imagem.Image = Properties.Resources.IMG_6211;
        }

        //EVENTO ADICIONADO PARA ALTERAR IMAGEM DO PICTUREBOX
        private void btn_imagem3_Click(object sender, EventArgs e)
        {
            pb_imagem.Image = Properties.Resources.teste;
        }
    }
}
