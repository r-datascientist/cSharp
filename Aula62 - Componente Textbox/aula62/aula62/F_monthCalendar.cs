using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA77 ADICIONADO ELEMENTO MONTHCALENDAR 
//ALTERADA PROPRIEDADE MaxSelectionCount PARA PERMITIR A SELEÇAO DE ATRE TRINTA DIAS DE UMA VEZ

namespace aula62
{
    public partial class F_monthCalendar : Form
    {
        public F_monthCalendar()
        {
            InitializeComponent();
        }

        //EVENTO CRIADO COMO DESAFIO PARA UNIFICAR AS IMPLEMENTÇÕES ABAIXO
        private void seleData(TextBox ts, TextBox te, TextBox th)
        {
            ts.Text = mc_data.SelectionStart.ToShortDateString();
            te.Text = mc_data.SelectionEnd.ToShortDateString();
            th.Text = mc_data.TodayDate.ToShortDateString();
        }

        //EVENTO CRIADO PARA PASSAR PARA OS TEXTBOX VALORES DE DATA DO MONTHCALENDAR
        private void btn_pegarData_Click(object sender, EventArgs e)
        {
            //METODO ESPERIMENTAL
            seleData(tb_start, tb_end, tb_hoje);

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE SelectionStart E DO METDO ToShortDateString() DA DATA INICIO DO RANGE SELECIONADO  
            //tb_start.Text = mc_data.SelectionStart.ToShortDateString();//PARA STRING NO FORMATO CURTO DD/MM/AAAA

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE SelectionEnd E DO METDO ToShortDateString() DA DATA INICIO DO RANGE SELECIONADO
            //tb_end.Text = mc_data.SelectionEnd.ToShortDateString();//PARA STRING NO FORMATO CURTO DD/MM/AAAA

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE TodayDate E DO METDO ToShortDateString() DE HOJE NO FORMATO CURTO DD/MM/AAAA
            //tb_hoje.Text = mc_data.TodayDate.ToShortDateString();
        }

        //EVENTO CRIADO PARA MOSTRAR DATA AUTOMATICAMENTE COM A ALTERAÇAO DA SELEÇAO NO MONTHCALENDAR
        private void mc_data_DateChanged(object sender, DateRangeEventArgs e)
        {
            //METODO ESPERIMENTAL
            seleData(tb_startChange, tb_endChange, tb_hojeChange);

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE SelectionStart E DO METDO ToShortDateString() DA DATA INICIO DO RANGE SELECIONADO  
            //tb_startChange.Text = mc_data.SelectionStart.ToShortDateString();//PARA STRING NO FORMATO CURTO DD/MM/AAAA

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE SelectionEnd E DO METDO ToShortDateString() DA DATA INICIO DO RANGE SELECIONADO
            //tb_endChange.Text = mc_data.SelectionEnd.ToShortDateString();//PARA STRING NO FORMATO CURTO DD/MM/AAAA

            ////TEXTO DO TEXTBOX RECEBE RETORNO ATRAVES DA PROPRIEDADE TodayDate E DO METDO ToShortDateString() DE HOJE NO FORMATO CURTO DD/MM/AAAA
            //tb_hojeChange.Text = mc_data.TodayDate.ToShortDateString();
        }

    }
}
