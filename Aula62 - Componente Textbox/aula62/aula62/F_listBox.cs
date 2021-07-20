using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA72 ADICIONADO ELEMENTO ListBox QUE SERÁ ASSOCIADO A UM DataSource QUE APONTARA PARA UM List<>

namespace aula62
{
    public partial class F_listBox : Form
    {
        List<string> carros = new List<string>();
        public F_listBox()
        {
            InitializeComponent();

            //NO CONSTRUTOR DA CLASSE ADICIONANDO VALORES AO List<>
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            //AGORA ASSOCIANDO O LISTBOX AO DATASOURCE QUE TEM A ELE ATRIBUIDA A LISTA
            lb_carros.DataSource = carros;
        }

        //METODO CRIADO PARA ATUALIZAR O DATASOURCE E EVITAR QUE ESTE CODIGO DE ATUALIZAÇAO FOSSE REPETIDO VARIAS VEZES
        private void atualData()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = carros;
        }

        //CASO HOUVESSEM VARIOS LISTBOX OU ELEMENTOS DIFERENTES QUE EXIGISSE ATUALIZAR O DATASOURCE PARA DIVERSOS ELEMENTOS
        //ESTE PODERIA SER O METODO UTILIZADO, PASSANDO PARA ELE COMO PARAMETROS NESTE CASO QUAL O LISTBOX E QUAL O LIST 
        //private void atualData(ListBox lb, List<string> l)
        //{
        //    lb.DataSource = null;
        //    lb.DataSource = l;
        //}

        //EVENDO CLIQUE PARA ADICIONAR NOVOS VALORES AO List<> CONSEGUENTEMENTE AO DATASOURCE E AO LISTBOX
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //VALIDANDO SE O TEXTBOX ESTA VAZIO
            if (tb_carro.Text == "")
            {
                //PODERIA SIMPLESMENTE EXECUTAR return PARA SAIR
                //return;

                //OU ENTAR TOMAR UMA DECISAO OU EMITIR UMA MENSAGEM
                MessageBox.Show("Digite um carro!");

                //RETORNA O CURSOR PARA O TEXTBOX
                tb_carro.Focus();
            }
            else
            {
                //ENTAO ADICIONANDO O NOVO VALOR AO List<>
                carros.Add(tb_carro.Text);

                //POREM PARA QUE O DATASOURCE SEJA ATUALIZADO 
                //É NECESSARIO PRIMEIRO APAGAR SEUS REGISTROS E AI SIM DEPOIS ATRIBUIR A ELE A LISTA NOVAMENTE
                lb_carros.DataSource = null;
                lb_carros.DataSource = carros;

                //LIMANDO O TEXTBOX
                tb_carro.Clear();
            }
        }

        //EVENTO CLIQUE ADICIONADO PARA REMOVER VALORES DO LISTBOX
        private void btn_remover_Click(object sender, EventArgs e)
        {
            //REMOVENDO VALOR ESPEFICO DO LISTBOX UTILIZANDO O METODO RemoveAt()
            //ONDE ESTA SENDO PASSADO PARA O METODO O VALOR DO INDICE DO VALOR NO LISTBOX
            //QUE É O MESMO INDICE DESTE VALOR NO List<> UMA VEZ QUE O LISTBOX ESTÁ MOSTRANDO OS ELEMENTOS NA ORDEM DO PROPRIO List<>
            carros.RemoveAt(lb_carros.SelectedIndex);

            //METODO CRIADO PARA ATUALIZARO DATASOURCE
            atualData();
        }

        //EVENTO CLIQUE PARA ATRIBUIR O ELEMENTO SELECIONADO NO LISTBOX AO TEXTO DO TEXTBOX
        private void btn_obter_Click(object sender, EventArgs e)
        {
            //TEXTBOX RECEBE O VALOR DO List<> COM O INDICE DO VALOR NO LISTBOX
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();

            //METODO CRIADO PARA ATUALIZARO DATASOURCE
            atualData();
        }
    }
}
