using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NECESSARIO ADICIONAR ESTA BIBLIOTECA PARA TRABALHAR COM TRADESLEEP
using System.Threading;

//PROGRESSBAR TEM A MESMA LÓGICA DE NUMERICUPDOWN PARA CONFIGURAR VALORES EM PROPRIEDADES
//Minimum: PARA DETERMINAR O VALOR MINIMO
//Maximum: PARA DETERMINAR O VALOR MAXIMO
//Value: PARA DETERMINAR O VALOR INICIAL

namespace aula62
{
    public partial class F_progressBar : Form
    {
        public F_progressBar()
        {
            InitializeComponent();
        }

        //EVENTO CLIQUE PARA SETAR PROPRIEDADE PARA VALOR MINIMO AOS PROGRESSBAR
        private void btn_setarMinimo_Click(object sender, EventArgs e)
        {
            pb_carregar.Minimum = int.Parse(tb_setarMinimo.Text);
            pb_temporizador.Minimum = int.Parse(tb_setarMinimo.Text);
        }

        //EVENTO CLIQUE PARA SETAR PROPRIEDADE PARA VALOR MAXIMO AOS PROGRESSBAR
        private void button2_Click(object sender, EventArgs e)
        {
            pb_carregar.Maximum = int.Parse(tb_setarMaximo.Text);
            pb_temporizador.Maximum = int.Parse(tb_setarMaximo.Text);
        }

        //EVENTO CLIQUE PARA SETAR UM VALOR PREDETERMINADO AOS PROGRESSBAR, ONDE TAMBEM SERÁ INICIADA A CONTAGEM 
        private void btn_setar_Click(object sender, EventArgs e)
        {
            //VALIDACAO PARA GARANTIR QUE O VALOR SETADO ESTÁ DENTRO DO RANGE DE VALORES MINIMO E MAXIMO
            if
            (
                (int.Parse(tb_valor.Text) >= pb_carregar.Minimum) & 
                (int.Parse(tb_valor.Text) <= pb_carregar.Maximum) &
                (int.Parse(tb_valor.Text) <= pb_temporizador.Maximum) &
                (int.Parse(tb_valor.Text) <= pb_temporizador.Maximum)
            )
            {
                //VALORES DO TEXTBOS SAO ATRIBUIDOS A PROPRIEDADE VALUE DOS PROGRESSBAR
                pb_carregar.Value = int.Parse(tb_valor.Text);
                pb_temporizador.Value = int.Parse(tb_valor.Text);
            }
            else
            {
                //SE O VALOR NAO ESTIVER DENTRO DO RANGE OS LIMITES SAO INFORMADOS
                MessageBox.Show("O valor precisa ser maior/igual que "+pb_carregar.Minimum+" e menor/igual que "+pb_carregar.Maximum+"!");
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            //O LOOP COMEÇA A CONTAGEM A PARTIR DO VALOR SETADO NO TEXTBOX E VAI ATÉ O VALOR MÁXIMO DO PROGRESBAR
            for (int i = int.Parse(tb_valor.Text); i <= pb_temporizador.Maximum; i++)
            {
                pb_temporizador.Value = i;
                Thread.Sleep(100);
            }

            //O LOOP COMEÇA A CONTAGEM A PARTIR DO VALOR SETADO NO TEXTBOX E VAI ATÉ O VALOR MÁXIMO DO PROGRESBAR
            for (int i = int.Parse(tb_valor.Text); i <= pb_carregar.Maximum; i++)
            {
                tb_valorContagem.Text = i.ToString();
                pb_carregar.Value = i;
            }
        }
    }
}
