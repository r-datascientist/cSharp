using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA73 ADICIONADO ELEMENTO LISTVIEW, QUE FUNCIONA COMO UMA TABELA, COM LINHAS E COLUNAS

//EM PROPRIDEDADES FOI ALTERADO, FullRowSelect = true, PARA QUANDO CLICADA A LINHA SER TOTALMENTE SELECIONADA
//TAMBEM EM PROPRIEDADES FOI ALTERADADO, MultiSelect = false, PARA PERMITIR SOMENTE A SELEÇAO DE UMA UNICA LINHA

//PARA ADICIONAR OS ITENS E AS COLUNAS DO LISTVIEW FOI ACIONADA A FLECHINHA PARA ABRIR SUAS OPÇOES E Edit Columns
//COMEÇANDO PELAS COLUNAS, QUE É O CABEÇALHO DO LISTVIEW, ADICIONANDO UMA NOVA, DA MESMA FORMA QUE OS DEMAIS ELEMENTOS
//NAS SUAS PROPRIEDADES FORAM PREENCHIDOS NO CAMPO Name O NOME DO ELEMENTO PARA REFERENCIA NA PROGRAMAÇAO DAS SUAS FUNCIONALIDADES
//E NO CAMPO Text O NOME PARA SER IMPRESSO NO FORMULARIO PARA VISUALIZAÇAO DO USUARIO
//PARA PERSONALIZAR O TAMANHO DAS COLUNAS DEVE SER ALTERADO O CAMPO Width
//PARA A EXIBIÇAO DAS COLUNAS NO LISTVIEW, NAS OPÇOES A OPÇAO View DEVE SER ALTERADA PARA Details

//PARA ADICIONAR ITENS DO LISTVIEW, TAMBEM EM OPÇOES, E Edit Items

//IMPORTANTE QUE AS LINHAS DO LISTVIEW, OU SEJA, OS ITENS, SEGUEM UMA LÓGICA SEMELANTE A MENU E SUBMENU
//ONDE ADICIONANDO UM ITEM SE ESTA ADICIONANDO UM VALOR NA PRIMEIRA COLUNA, 
//E ADICIONANDO SUBITENS SE ESTÁ ADICIONANDO VALORES NAS DEMAIS COLUNAS DO LISTVIEW
//TAMBÉM DEVE SE USAR O CAMPO TEXT PARA ADICIONAR O VALOR 

//AULA75 ADICIONADO NO LISTVIEW EVENTO SelectedIndexChanged QUE É DISPARADO A CADA VEZ QUE A SELEÇAO ENTRE OS SUBITENS É ALTERADA DE UM PARA OUTRO

namespace aula62
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        //METODO CRIADO PARA EXECUTAR A LIMPEZA DOS TEXTBOX E NAO SER NECESSARIO REPITIR TODO O BLOCO DE COMANDOS
        private void lt()
        {
            //LIMPANDO O TEXTOS DOS TEXTBOX E RETORNANDO O CURSOR PARA O PRIMEIRO
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        //CRIADO METODO COM A MESMA IMPLEMENTAÇAO FEITA NO METODO PARA O BOTAO OBTER
        //SEGUINDO A MESMA LOGICA DE AO REPETIR BLOCOS DE CODIGOS COM A MESMA ESCRITA, MAS UTILIZANDO METODOS PARA ISSO
        private void obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }


        //EVENTO CLIQUE ADICIONADO PARA BOTAO ADICIONAR
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //VALIDA SE O CAMPO ESTÁ VAZIO, RETORNA O CURSOR PARA O CAMPO, E DA UM RETURN PARA SAIR DO METODO
            if(tb_id.Text == "")
            {
                MessageBox.Show("Adicione o ID!");
                tb_id.Focus();
                return;
            }
            //VALIDA SE O CAMPO ESTÁ VAZIO, RETORNA O CURSOR PARA O CAMPO, E DA UM RETURN PARA SAIR DO METODO
            if (tb_produto.Text == "")
            {
                MessageBox.Show("Adicione o Produto!");
                tb_produto.Focus();
                return;
            }            //VALIDA SE O CAMPO ESTÁ VAZIO, RETORNA O CURSOR PARA O CAMPO, E DA UM RETURN PARA SAIR DO METODO
            if (tb_qtde.Text == "")
            {
                MessageBox.Show("Adicione a Quantidade!");
                tb_qtde.Focus();
                return;
            }            //VALIDA SE O CAMPO ESTÁ VAZIO, RETORNA O CURSOR PARA O CAMPO, E DA UM RETURN PARA SAIR DO METODO
            if (tb_preco.Text == "")
            {
                MessageBox.Show("Adicione o Preço!");
                tb_preco.Focus();
                return;
            }
                //PARA EXECUTAR A ADIÇAO DE VALORES NO LISTVIEW PRIMEIRAMENTE É NECESSÁRIO CRIAR UMA COLEÇAO, NO CASO UM ARRAY
                string[] produtos = new string[4];

                //ENTAO ADICIONAR OS VALORES NESTE ARRAY
                produtos[0] = tb_id.Text;
                produtos[1] = tb_produto.Text;
                produtos[2] = tb_qtde.Text;
                produtos[3] = tb_preco.Text;

                //ASSIM CRIAR UM OBJETO DO TIPO LISTVIEWITEM PARA RECEBER A COLEÇAO CRIADA NO ARRAY NO TIPO DE UMA LINHA DO LISTVIEW
                ListViewItem lvi = new ListViewItem(produtos);

                //JÁ A ADIÇAO É FEITA NA PROPRIEDADE items DO PROPRIO LISTVIEW PASSANDO O OBJETO DO TIPO LISTVIEWITEM
                lv_produtos.Items.Add(lvi);

                //E OS TEXTBOX SAO LIMPOS COMO METODO CRIADO ACIMA
                lt();
        }

        //METODO DE EVENTO CLIQUE ADICIONADO PARA EXECUTAR A REMOÇAO DE ITEM DO LISTVIEW COM O BOTAO REMOVER
        private void btn_remover_Click(object sender, EventArgs e)
        {
            //PARA A REMOÇAO DE UM ITEM DO LISTVIEW USAMOS A PROPRIEDADE Items DO PROPRIO LISTVIEW
            //AÍ ENTAO O METODO RemoveAt() QUE REMOVE UM ITEM ESPECIFICO
            //PASSAMOS PARA O METODO NOVAMENTE O PROPRIO LISTVIEW UTILIANDO A COLEÇAO SelectedIndices[] 
            //QUE PRECISA RECEBER A POSIÇAO NO INDICE DO ELEMENTO PARA REMOÇAO
            //COMO O LISTVIEW ESTA CONFIGURADO PARA PERMITIR A SELEÇAO DE SOMENTE UMA LINHA A POSIÇAO PASSADA É 0
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        //METODO ADICIONADO PARA OBTER OS SUBITENS DO LISTVIEW E PASSAR ELES PARA O TEXTO DOS TEXTBOX
        private void btn_obter_Click(object sender, EventArgs e)
        {
            //JÁ PARA OBTER OS SUBITENS DO LISTVIEW DA MESMA FORMA PASSAMOS PARA A COLEÇAO SelectedItems[0]
            //MAS ALEM DISSO PASSAMOS PARA A COLEÇAO SubItems[] O VALOR DO INDICE DE CADA SUBITEM QUE SERÁ OBTIDO NO LISTVIEW
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }


        //EVENTO ADICIONADO PARA MOSTRAR NO TEXTBOX OS VALORES DO SUBITEM A VADA VEZ QUE A SELEÇAO ENTRE ELES SEJA ALTERADA NO LISTVIEW
        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FOI NECESSÁRIO FAZER ESTE IF POIS NA SEGUNDA SELEÇAO NOS SUBITENS, ELE ESTA DANDO CONFLITO E GERANDO ERRO
            //PROVAVELMENTE PORQUE É PASSADO SubItems[0] E NA SEGUNDA SELEÇAO RECEBEMOS SubItems[1], NAO FOI ESCLARECIDO
            if (lv_produtos.SelectedItems.Count > 0)
            {
                obter();
            }
        }
    }
}
