using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PROPRIEDADES DO NUEMRICUPDOWN: 
//Increment: PARA ATRIBUIR O VALOR DE INCREMENTO A CADA ACIONAMENTO 
//Maximum: O VALOR MÁXIMO QUE PODE SER SELECIONADO NO ELEMENTO
//Minimum: O VALOR MÍNIMO QUE PODE SER SELECIONADO 
//UpDownAlign: define se os botoes vao ficar no lado direito ou esquerdo

namespace aula62
{
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        //EVENTO CLIQUE ADICIONADO PARA SETAR NO NUMERICUPDOWN O VALOR INSERIDO NO TEXTBOX
        private void btn_setar_Click(object sender, EventArgs e)
        {
            //O VALOR DO NUMERICUPDOWN NÃO É TEXTO, É DECIMAL, E A PROPRIEDADE UTILIZADA NÃO É Text, É Value
            //COMO NAO TEMOS O METODO ToDecimal() PARA CONVERSAO DEVEMOS USAR OPERAÇÃO DE typecast Parse Decimal.Parse(tb_valor.Text)
            //COMO ESTÃO SETADOS LIMITES NAS PROPRIEDADES Minimum E Maximum É NECESSÁRIO VALIDAR A INSERÇAO DE VALORES PELO TEXTBOX
            //SENDO QUE A VALIDAÇÃO É FEITA DIRETAMENTE PELAS PROPRIEDADES E NAO PELOS VALORES FIXOS NO CODIGO 
            if((Decimal.Parse(tb_valor.Text) >= nup_valor.Minimum) & (Decimal.Parse(tb_valor.Text) <= nup_valor.Maximum))
            {
                nup_valor.Value = Decimal.Parse(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("O valor deve ser maior que " + nup_valor.Minimum + " e menor que " + nup_valor.Maximum  + "!");
            }
        }
    }
}
