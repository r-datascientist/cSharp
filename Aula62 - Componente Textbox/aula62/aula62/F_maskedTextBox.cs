using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AULA76 - ADICIONADO ELEMENTO MASKEDTEXTBOX, ESTE É UM TIPO DE TEXTBOX QUE PERMITE CONFIGURAÇOES DE MASCARAS EM SUAS PROPRIEDADES
//NA PROPRIEDADE Mask SAO ENCONTRADAS AS OPÇOES DE MASCARAS PARA CONFIGURAÇAO, INCLUSIVE ESTAS PROPRIAS MASCARAS JA DISPONIVEIS TAMBEM PODEM SER PERSONALIZADAS
//SEGUE LINK DA DOCUMENTAÇAO COM AS OPÇOES DE PERSONALIZAÇAO E CONFIGURAÇAO: https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.maskedtextbox.mask?view=netcore-3.1
//NA PROPRIEDADE PasswordChar PODEMOS ATRIBUIR O CARACTER QUE SERA MOSTRADO ENQUANTO O TEXTBOX É CONFIGURADO COMO UM CAMPO DE SENHA
//A PROPRIEDADE MaskFormat = ExcludePromptAndLiterals PASSA SOMENTE O CONTEUDO DIGITADO EXCLUINDO OS CARACTERES DA MASCARA DO CAMPO
//JA PROPRIEDADE MaskFormat = IncludeLiterals PASSA TODO O CONTEUDO DO CAMPO INCLUINDO OS CARACTERES DA MASCARA 

namespace aula62
{
    public partial class F_maskedTextBox : Form
    {
        public F_maskedTextBox()
        {
            InitializeComponent();
        }

        //EVENTO ADICIONADO PARA REVELAR E ESCONDER A SENHA DIGITADA
        private void cb_revelarSenha_CheckedChanged(object sender, EventArgs e)
        {
            //VALIDACAO PARA REVELAR/OCULTAR TEXTO DIGITADO NO MASKEDTEXTBOX SENHA
            if (cb_revelarSenha.Checked == true)
            {
                //IMPORTANTE!!! TIPO CHAR NAO ACEITA NULL NEM VAZIO, SENDO NECESSARIO UTILIZAR FORMATOS: '\0' OU (char)0  
                mtb_senha.PasswordChar = '\0';//(char)0;
                //MessageBox.Show("OK");
            }
            else
            {
                mtb_senha.PasswordChar = '*';
            }
        }
        //EVENTO CLIQUE ADICIONADO PARA MOSTRAR O CONTEÚDO DO MASKEDTEXTBOX
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //AGORA VALIDAÇAO PARA DETERMINAR PROPRIEDADES DOS MASKEDTEXTBOX
            if (cb_somenteTexto.Checked == true)
            {
                //PROPRIEDADE TextMaskFormat RECEBE SOMENTE OS VALORES DIGITADOS MaskFormat.ExcludePromptAndLiterals
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                //AQUI A MESMA PROPRIEDADE RECEBE TODO O CONTEUDO DO CAMPO MaskFormat.IncludeLiterals
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            //ENTAO IMPRIME OS VALORES NA TELA
            MessageBox.Show(mtb_cpf.Text);
        }
    }
}
