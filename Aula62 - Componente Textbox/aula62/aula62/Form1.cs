using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EM PROPRIEDADES
//StartPosition: CenterScreen -> PARA O FORMULARIO ABRIR SEMPRE NO CENTRO DA TELA
//FormBorderStyle: FixdDialog -> PARA A JANELA NAO SER REDIMENSIONAVEL PELO USUARIO
//MaximezeBox: False -> PARA OCULTAR A OPCAO DE MAXIMAR A JANELA
//tb_listaVeiculos ReadOnly: True -> PARA SOMENTE MOSTRAR O TEXTO E NAO PERMITIR A ESCRITA
//tb_listaVeiculos Multiline True -> PARA PERMITIR NOVAS LINHAS

//AULA64 tb_listaVeiculos Modifiers: Public -> ALTERADA OPÇAO DE VISUALIZAÇAO DO TEXTBOX DE PRIVATE PARA PUBLIC PARA ELE SER ACESSADO NO FORMULARIO FILHO

//AULA65 ADICIONADO ELEMENTO MenuStrip DA ToolBox, MENU Componentes, SUBMENU CheckBox, DUPLO CLIQUE EM SUBMENU CheckBox O METODO DO EVENTO checkboxToolStripMenuItem_Click()

//AULA78 ADICIONADO ELEMENTOS NotifyIcon PARA GERAR UM ÍCONE NA BANDEJA DO SISTEMA E ContextMenuStrip PARA ASSOCIAR UM MENU A ESTE ICONE
//AMBOS ELEMENTOS NAO SAO VISIVEIS NO FORMULARIO MAS FORAM CRIADOS NO FORMULARIO PRINCIPAL
//NAS PROPRIEDADES DE NotifyIcon DEVE SER CONFIGURADO UM ICONE E NA PROPRIEDADE Visible DEVE ESTAR COMO True
//EM TEXT REPRESENTA O TEXTO QUE SERIA O HOVER DO ICONE
//JÁ NA PROPRIEDADE ContextMenuStrip DO PROPRIO NotifyIcon OS DOIS ELEMENTOS SAO ASSOCIADOS SELECIONANDO O MENUSTRIP COORRESPONDENTE
//AGORA EM ContextMenuStripe
//NA FLECHINHA DE OPÇOES OU NA PROPRIEDADE ITEMS SAO ADICIONADOS OS MenuItem QUE SAO OS ITENS QUE TERA O MENU
//DA MESMA FORMA EM NAME O MENUITEM É IDENTIFICADO PARA PROGRAMAÇAO E EM TEXT O VALOR PARA O IDENTIFICACAO DO USUARIO
//EM EVENTS UTILIZAMOS O ItemClicked PARA VERIFICAR QUAL ITEM DO CONTEXTMENUSTRIP FOI CLICADO PARA SELECIONAR A AÇAO A SER EXECUTADA

//EM PROPRIEDADES DO FORMULÁRIO PRINCIPAL EM WindowState PODEMOS DEFINIR COMO SERÁ INICIALIZADO O PROGRAMA, NORMAL, MAXIMIZADO OU MINIMIZADO



namespace aula62
{
    public partial class F_Principal : Form
    {

        //AULA64 CRIANDO UMA VARIAVEL PARA RECEBER VALORES A PARTIR DO FORMULARIO FILHO
        public int num;

        public F_Principal()
        {
            InitializeComponent();

            //VARIAVEL É INICIADA NO CONSTRUTOR DA CLASSE
            num = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //VALIDACAO PARA NAO ADICIONAR TEXTO AO TEXTBOX LISTA SE O TEXTBOX ESTIVER VAZIO
            if(tb_veiculo.Text == "")
            {
                //SE O TEXTBOX ESTIVER VAZIO SERÁ EXIBIDA A MENSAGEM ABAIXO
                MessageBox.Show("Digite um Veículo!");
                //APOS EXIBIR A MENSAGEM O CURSOR RETORNA O FOCO PARA O TEXTBOX
                tb_veiculo.Focus();
                //return PARA SAIR E PARA A EXECUÇAO
                return;
            }
            //DESTA FORMA O TEXTO DO TEXTBOX SERIA ADICIONADO O TEXTBOX LISTA MAS SEMPRE SOBRESCREVERIA O VALOR QUE JÁ EXISTISSE
            //tb_listaVeiculos.Text = tb_veiculo.Text;

            //ESTA SERIA UMA FORMA DE CONCATENAÇAO SIMPLES SEM ESPAÇOS
            //tb_listaVeiculos.Text = tb_listaVeiculos.Text + tb_veiculo.Text;

            //ESTA É A FORMA CONTRAIDA E JÁCOM ESPAÇO E VIRGULA
            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";

            //LIMPA O TEXTBOX APOS A ADICAO
            tb_veiculo.Clear();
            //RETORNA O CURSOR PARA O TEXT BOX
            tb_veiculo.Focus();
        }

        //CLIQUE DUPLO NO BOTAO LIMPAR PARA ADICIONAR AUTOMATICAMENTE ESTE EVENTO DE CLIQUE NO BOTAO
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            //BOTAO LIMPAR LIMPANDO O TEXT BOX LISTA O TEXTBOX E RETORNANDO O CURSOR PARA O TEXT BOX
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        //EVENTO CLIQUE DO BOTAO Mostrar Veiculos PARA CHAMAR O SEGUNDO FORMULARIO F_Veiculos
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO UM OBJETO A PARTIR DA CLASSE DO SEGUNDO FORMULARIO
            //TAMBEM PASSANDO COMO PARAMETRO PARAO CONSTRUTOR DA CLASSE DO FORMULARIO O TEXTO DA TEXTBOX LISTA
            //AULA64 PASSANDO NOVO PARAMETRO DE ENTRADA PARA O CONSTRUTOR DA CLASSE DO FORMULARIO FILHO
            //PASSANDO SOMENTE this POIS ESTÁ PASSANDO A PROPRIA CLASSE F_Principal
            F_Veiculos obj_form_2 = new F_Veiculos(tb_listaVeiculos.Text,this);

            //OBJETO SENDO MOSTRADO COM ShowDialog() PARA NAO PERMITIR A NAVEGACAO ENTRE OS FORMULARIOS
            //DIFERENTEMENTE DO Show() QUE PERMITIRIA A NAVEGACAO
            obj_form_2.ShowDialog();
        }

        //CLIQUE DUPLO NO BOTAO PARA ADICIONAR EVENTO DE CLIQUE
        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        //!!!!!!!!!!!! IMPORTANTE !!!!!!!!!!!!!!!
        //ABAIXO ADICIONADO NOVOS SUBMENUS, 
        //DUPLO CLIQUE NO PROPRIO ITEM CRIADO NO MENU PARA CRIACAO DE METODO DE EVENTO CLIQUE PARA CHAMADA DE NOVO FORMULARIO CRIADO

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO OBJETO DE UM NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_CheckBox obj_form_3 = new F_CheckBox();

            //MOSTRANDO O NOVO FORMULARIO CRIADO
            obj_form_3.ShowDialog();

        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_CheckedListBox obj_form_4 = new F_CheckedListBox();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_4.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_ComboBox obj_form_5 = new F_ComboBox();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_5.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_DateTimePicker obj_form_6 = new F_DateTimePicker();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_6.ShowDialog();
        }

        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_LinkLabel obj_form_7 = new F_LinkLabel();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_7.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_listBox obj_form_8 = new F_listBox();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_8.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_ListView obj_form_9 = new F_ListView();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_9.ShowDialog();
        }

        //EVENTO CLIQUE ADICINADO DIRETAMENTE NO MENU CRIADO PARA MASKEDTEXTBOX
        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_maskedTextBox obj_form_10 = new F_maskedTextBox();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_10.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_monthCalendar obj_form_11 = new F_monthCalendar();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_11.ShowDialog();
        }

        //EVENTO CLIQUE CRIADO PARA IDENTIFICAR QUAL MENUITEM DO CONTEXTMENUSTRIP FOI CLICADO PELO USUARIO
        private void cms_MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //PARA VERIFICAR QUAL ITEM FOI CLICADO UTILIZAMOS O PARAMETRO DE ENTRADA e QUE É DO TIPO ToolStripItemClickedEventArgs E RECEBE O ITEM CLICADO
            if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                //this PARA REFERENCIAR O PROPRIO FORMULARIO PRINCIPAL E METODO CLOSE PARA FECHAR O FORMULARIO
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                //AGORA PONDO EM PRIMEIRO PLANO O FORMULARIO PRINCIPAL
                this.WindowState = FormWindowState.Normal;
            }
            else if(e.ClickedItem.Name.ToString() == "tsmi_mensagem")
            {
                MessageBox.Show("CFB Cursos");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_NumericUpDown obj_form_12 = new F_NumericUpDown();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_12.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_pictureBox obj_form_13 = new F_pictureBox();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_13.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTANCIANDO NOVO OBJETO PARA O NOVO FORMULARIO FILHO CRIADO NO PROJETO
            F_progressBar obj_form_14 = new F_progressBar();

            //MOSTRANDO NOVO FORMULARIO CRIADO
            obj_form_14.ShowDialog();
        }
    }
}
