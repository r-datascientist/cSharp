using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA70 ADICIONADO FORMULARIO PARA ELEMENTO DATETIMEPICKER

namespace aula62
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        //EVENTO CLIQUE ADICIONADO PARA OBTER A DATA DO DATETIMEPICKER E MANIPULAR ELA PREENCHENDO OS TEXTBOX
        private void btn_obterData_Click(object sender, EventArgs e)
        {
            //PREENCHENDO O PRIMEIRO TEXTBOX COM A DATA DO DATETIMEPICKER COMPLETA
            tb_data.Text = dtp_data.Text;

            //PEGANDO OS VALORES SEPARADOS USANDO A PROPRIEDADE Value
            //PEGANDO O DIA COM A PROPRIEDADE Day
            //COMOO RETORNO DOS VALORES DE DATA SAO DE TIPO int É NECESSARIO CONVERTER PARA STRING 
            tb_dia.Text = dtp_data.Value.Day.ToString();

            //PEGANDO O MES COM A PROPRIEDADE Month
            tb_mes.Text = dtp_data.Value.Month.ToString();

            //PEGANDO O ANO COM A PROPRIEDADE Year
            tb_ano.Text = dtp_data.Value.Year.ToString();

        }
        //EVENTO CLIQUE BOTAO SETAR
        private void btn_setarData_Click(object sender, EventArgs e)
        {
            //AGORA SERÁ FEITA A OPERAÇAO CONTRARIA DA FEITA ACIMA
            //PREENCHENDO VALORES NOS TEXTBOX DIA MES E ANO E PASSANDO ESTES VALORES PARA O DATETIMEPICKER

            //A MESMA OPERAÇAO PODE SER FEITA CRIANDO VARIAVEIS OU EM UMA UNICA LINHA

            //CRIANDO AS VARIAVEIS
            //int a,m,d;

            //a = Int32.Parse(tb_ano.Text);
            //m = Int32.Parse(tb_mes.Text);
            //d = Int32.Parse(tb_dia.Text);

            //DateTime dt = new DateTime(a,m,d);
            
            //AQUI A MESMA OPERAÇAO ESTÁ SENDO ESCRITA EM UMA UNICA LINHA SEM A CRIAÇAO DE VARIAVEIS
            DateTime dt = new DateTime(Int32.Parse(tb_ano.Text),Int32.Parse(tb_mes.Text),Int32.Parse(tb_dia.Text));

            //IMPORTANTE QUE PARA A PASSAGEM DOS VALORES PARA O DATETIMEPICKER USAMOS A PROPRIEDADE Value
            dtp_data.Value = dt;
                
                 
        }

        //EVENTO CLIQUE PARA SETAR O DIA ATUAL
        private void btn_hoje_Click(object sender, EventArgs e)
        {
            //PARA SETAR A DATA ATUAL NO DATETIMEPICKER USAMOS A PROPRIEDADE Value PEGANDO O VALOR DA CLASSE DateTime COM A PROPRIEDADE Today
            //TEMOS TAMBEM OUTRAS PROPRIEDADES DA CLASSE DATETIME PEGAR A DATA, COMO A PROPRIEDADE Now QUE PEGA A DATA ATUAL COM A HORA ATUAL
            dtp_data.Value = DateTime.Today;
        }
    }
}
