using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//NECESSÁRIO ADICIONAR BILBLIOTECA IO PARA TRABALHAR COM ENTRADA E SAÍDA DE ARQUIVOS
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //VARIAVEL PARA FAZER A LEITURA DO ARQUIVO DE TEXTO
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        //CRIADOS METODOS PARA SEREM CHAMADOS NOS EVENTOS, SEM TER NECESSIDADE DE REPETIR A IMPLEMENTAÇAO NOS EVENTOS DE MENUSTRIPE E TOOLSTRIP
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Salvar()
        {
            try
            {
                //SETANDO ANTES DO IF POIS O BLOCO IF SERÁ EXECUTADO SOMENTE APOS O OK DO USUÁRIO, Filter: (*.CFB)|*.CFB, PARA PERMITIR APENAS ARQUIVOS DESTE TIPO
                saveFileDialog1.Filter = "(*.CFB)|*.CFB";

                //SE AO MOSTAR A JANELA DE SALVAMENTO AO USUÁRIO, RETORNAR OK, EXECUTA A CRIAÇÃO DO ARQUIVO 
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //CRIANDO UM ARQUIVO PASSANDO PARA O CONSTRUTOR DA CLASSE FILESTREAM
                    //O NOME DO ARQUIVO PEGO NA JANELA saveFileDialog1.FileName
                    //O MODO DO ARQUIVO FileMode.OpenOrCreate SE JÁ EXISTIR ELE ABRE E SE NÃO EXISTIR ELE CRIA
                    //E O TIPO DE ACESSO AO ARQUIVO FileAccess.Write (ESCRITA)
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    //IMPORTANTE EXECUTAR O CLOSE() POIS SOMENTE COM O FECHAMENTO QUE 
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na criação do arquivo" + ex.Message, "VISH...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abrir()
        {
            //SETANDO PROPRIEDADE MULTISELECT COMO FALSE, PARA QUE NAO SEJA POSSIVEL SELECIONAR MAIS DE UM ARQUIVO
            //AMBAS PODENDO TAMBEM SER FEITA ESTA ALTERAÇAO NA JANELA PROPRIEDADES DO ELEMENTO openFileDialog1
            this.openFileDialog1.Multiselect = false;
            //SETANDO PRPRIEDADE TITLE
            this.openFileDialog1.Title = "Abrir Arquivos";

            //AGORA DEFININDO PROPRIEDADE InitialDirectory PARA DETERMINAR O DIRETORIO INICIAL PARA ABERTURA DE ARQUIVOS
            //IMPORTANTE IMPLEMENTAR O @ ANTES DA STRING PARA NAO CAUSAREM ERROS OS CARACTERES ESPECIAIS
            openFileDialog1.InitialDirectory = @"C:\Users\116906\Desktop\cursoCsharp\materia\Aula83 - Criando um Editor de Texto P1";

            //PROPRIEDADE Filter PARA SELECIONAR OS TIPOS DE ARQUIVOS QUE SERAO ACEITOS PARA ABERTURA
            openFileDialog1.Filter = "(*.CFB)|*.CFB";//PERMITINDO SOMENTE ARQUIVOS DA EXTENSAO .CFB
            //openFileDialog1.Filter = "(*.CFB)|*.CFB"+"Todos Arquivos(*.*)|*.*";//PERMITINDO TAMBEM TODAS AS EXTENSOES DE ARQUIVOS 

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //DIFERENTEMENETE DO METODO SALVAR ESTA IMPLEMENTAÇAO FOI ESCRITA UTILIZANDO UMA VARIAVEL PARA ARMAZENAR O RESULTADO DE OK
                DialogResult dr = this.openFileDialog1.ShowDialog();

                //ENTAO A VALIDAÇAO DO OK É FEITA NO IF PELA VARIAVEL
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    //DA MESMA FORMA FOI UTILIZADO O TRATAMENTO DE ERRO COM TRY CATCH
                    try
                    {
                        //DA MESMA FORMA O OBJETO arquivo É ESTANCIADO A PARTIR DA CLASSE FileStream
                        //POREM AGORA OS PARAMETROS DIFERENTES PASSADOS NO SEU CONSTRUTOR SAO:
                        //FileMode.Open = PARA ABERTURA DO ARQUIVO
                        //FileAccess.Read = PARA LEITURA DO ARQUIVO
                        FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                        
                        //AGORA ESTAMOS USANDO A CLASSE StreamReader PARA PASSAR O OBJETO
                        StreamReader cfb_streamReader = new StreamReader(arquivo);

                        //PARA A PARTIR DO INICIO
                        cfb_streamReader.BaseStream.Seek(0,SeekOrigin.Begin);

                        //LIMPANDO richTextBox1 COM O TEXTO ANTERIOR
                        richTextBox1.Clear();

                        //VARIAVEL LINHA RECEBE O RETORNO DO OBJETO COM A PRIMEIRA LINHA LIDA
                        string linha = cfb_streamReader.ReadLine();

                        //EXECUTA UM LOOP LER LINHA POR LINHA ENQUANTO linha TIVER CONTEUDO
                        //E CONCATENA CADA LINHA COM QUEBRA DE LINHA NO ELEMENTO DE TEXTO richTextBox1
                        while (linha != null)
                        {
                            this.richTextBox1.Text += linha + "\n";
                            linha = cfb_streamReader.ReadLine();
                        }
                        //EXECUTA O FECHAMENTO PARA CONCLUIR O PROCESSO
                        cfb_streamReader.Close();
                    }
                    catch (Exception ex)
                    {
                        //RETORNO DE MENSAGEM DE ERRO
                        MessageBox.Show("Erro na leitura: "+ex.Message,"VISH...",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        //EVENTO CLIQUE PARA BOTAO SALVAR ARQUIVO
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void Copiar()
        {
            //PROPRIEDADE SelectionLength OBTEM OU DEFINE O NUMERO DE CARACTERES SELECIONADOS
            //VALIDACAO IF PARA SE HOUVER MAIS DO ZERO DE CARACTERES SELECIONADOS 
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            //richTextBox1.Paste();
            //PROPRIEDADE SelectionLength OBTEM OU DEFINE O NUMERO DE CARACTERES SELECIONADOS
            //VALIDACAO IF PARA SE HOUVER MAIS DO ZERO DE CARACTERES SELECIONADOS 
            richTextBox1.Paste();
        }

        private void Negrito()
        {
            //VARIAVEL PARA RECEBER O NOME DA FONTE SELECIONADA INICIADA COMO NULL
            string nome_da_fonte = null;

            //VARIAVEL PARA RECEBER O TAMANHO DA FONTE SELECIONADA INICIADA COMO NULL
            float tamanho_da_fonte = 0;

            //VARIAVEIS PARA VALIDACOES
            bool n,i,s = false;

            //PEGA O NOME DA FONTE
            nome_da_fonte = richTextBox1.Font.Name;

            //PEGA O TAMANHO DA FONTE
            tamanho_da_fonte = richTextBox1.Font.Size;

            //DEFINE ESTILO DE FONTE NAS VARIAVEIS PARA VALIDACAO
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            //NESTE PONTO DEFINE A FONTE DO TEXTO PARA REGULAR
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            //VALIDAÇOES SE O TEXTO NAO ESTIVER NEGRITO
            if (n == false)
            {   
                if(i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if(i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if(i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if(i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
            //SENAO SE O TEXTO ESTIVER NEGRITO
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }

        private void Italico()
        {
            //VARIAVEL PARA RECEBER O NOME DA FONTE SELECIONADA INICIADA COMO NULL
            string nome_da_fonte = null;

            //VARIAVEL PARA RECEBER O TAMANHO DA FONTE SELECIONADA INICIADA COMO NULL
            float tamanho_da_fonte = 0;

            //VARIAVEIS PARA VALIDACOES
            bool n, i, s = false;

            //PEGA O NOME DA FONTE
            nome_da_fonte = richTextBox1.Font.Name;

            //PEGA O TAMANHO DA FONTE
            tamanho_da_fonte = richTextBox1.Font.Size;

            //DEFINE ESTILO DE FONTE NAS VARIAVEIS PARA VALIDACAO
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            //NESTE PONTO DEFINE A FONTE DO TEXTO PARA REGULAR
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            //VALIDAÇOES SE O TEXTO NAO ESTIVER ITALICO
            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
            //SENAO SE O TEXTO ESTIVER ITALICO
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        private void Sublinhado()
        {
            //VARIAVEL PARA RECEBER O NOME DA FONTE SELECIONADA INICIADA COMO NULL
            string nome_da_fonte = null;

            //VARIAVEL PARA RECEBER O TAMANHO DA FONTE SELECIONADA INICIADA COMO NULL
            float tamanho_da_fonte = 0;

            //VARIAVEIS PARA VALIDACOES
            bool n, i, s = false;

            //PEGA O NOME DA FONTE
            nome_da_fonte = richTextBox1.Font.Name;

            //PEGA O TAMANHO DA FONTE
            tamanho_da_fonte = richTextBox1.Font.Size;

            //DEFINE ESTILO DE FONTE NAS VARIAVEIS PARA VALIDACAO
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            //NESTE PONTO DEFINE A FONTE DO TEXTO PARA REGULAR
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            //VALIDAÇOES SE O TEXTO NAO ESTIVER ITALICO
            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
            }
            //SENAO SE O TEXTO ESTIVER ITALICO
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        //METODO ALINHAMENTO ESQUERDA
        private void alinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        //METODO ALINHAMENTO DIREITA
        private void alinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        //ALINHAMENTO CENTRO
        private void alinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        //METODO IMPRIMIR
        private void Imprimir()
        {
            //DEFINE PARA O DOCUMENTO DA JANELA DE IMPRESSAO O ELEMENTO printDocument1
            printDialog1.Document = printDocument1;

            //PEGA O TEXTO ESCRITO E PASSA PARA A VARIAVEL texto
            string texto = this.richTextBox1.Text;

            //PASSA A VARIAVEL TEXTO PARA O METODO LEITOR (DEFINIDO NO INICIO DO CÓDIGO)
            leitura = new StringReader(texto);

            //CHAMA A JANELA DE IMPRESSAO E SE RETORNAR OK IMPRIME
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                //CHAMA A IMPRESSAO PARA O ELEMENTO PRINTDOCUMENT
                this.printDocument1.Print();
            }
        }


        #region eventos


        //EVENTO CLIQUE PARA BOTAO NOVO ARQUIVO
        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        //EVENTO CLIQUE PARA MENU NOVO ARQUIVO
        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        //EVENTO CLIQUE PARA MENU ABRIR ARQUIVO
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        //EVENTO CLIQUE PARA BOTAO ABRIR ARQUIVO
        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        //EVENTO CLIQUE PARA MENU SALVAR ARQUIVO
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        //EVENTO CLIQUE PARA MENU COPIAR ARQUIVO
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        //EVENTO CLIQUE PARA BOTAO COPIAR ARQUIVO
        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        //EVENTO CLIQUE PARA MENU COLAR ARQUIVO
        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        //EVENTO CLIQUE PARA BOTAO COLAR ARQUIVO
        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        //EVENTO CLIQUE PARA MENU NEGRITO
        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        //EVENTO CLIQUE PARA BOTAO NEGRITO
        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        //EVENTO CLIQUE PARA MENU ITALICO
        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        //EVENTO CLIQUE PARA BOTAO ITALICO
        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        //EVENTO CLIQUE PARA MENU SUBLINHADO
        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        //EVENTO CLIQUE PARA BOTAO SUBLINHADO
        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        //EVENTO CLIQUE PARA ALINHAR A ESQUERDA
        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        //EVENTO CLIQUE PARA ALINHAR A ESQUERDA
        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            alinharEsquerda();
        }

        //EVENTO CLIQUE PARA ALINHAR A DIREITA
        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        //EVENTO CLIQUE PARA BOTAO ALINHAR A DIREITA
        private void btn_direita_Click(object sender, EventArgs e)
        {
            alinharDireita();
        }

        //EVENTO CLIQUE PARA MENU CENTRALIZAR
        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        //EVENTO CLIQUE PARA BOTAO CENTRALIZAR
        private void btn_centro_Click(object sender, EventArgs e)
        {
            alinharCentro();
        }

        

        //EVENTO CLIQUE MENU IMPRIMIR
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        //EVENTO PRINTPAGE CRIADO PARA O ELEMENTO PRINTDOCUMENT PARA IMPRESSAO DE DOCUMENTO COM O TEXTO DIGITADO
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //COM ACIONAMENTO DO EVENTO PRINTPAGE SAO DEFINIDAS AS MARGENS PARA DEFINIR AS IMPRESSOES
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if(margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            //VARIAVEL PARA RECEBER AS LINHAS PARA IMPRESSAO
            string linha = null;

            //DEFINI FONT PARA IMPRESSAO
            Font fonte = this.richTextBox1.Font;

            //DEFINE PINCEL
            SolidBrush pincel = new SolidBrush(Color.Black);
            
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);

            //PEGA AS LINHAS QUE ESTAO VINDO DO METODO LEITOR
            linha = leitura.ReadLine();

            //LOOP PARA IMPRIMIR LINHA POR LINHA DETERMINANDO A POSIÇÃO DE CADA LINHA 
            while(cont < linhasPagina)
            {
                PosY = (margemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte,pincel, margemEsquerda, PosY,new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }

            //SE AINDA HOUVER LINHAS CRIA UMA NOVA PAGINA
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        #endregion
    }
}
