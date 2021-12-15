using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetCareWork.Properties;
using PetCareWork.Classes;

namespace PetCareWork.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

      

        private void PBoxEnter_MouseHover_1(object sender, EventArgs e)
        {
            PBoxEnter.BackgroundImage = Resources.Pata2;
        }

        private void PBoxEnter_MouseLeave_1(object sender, EventArgs e)
        {
            PBoxEnter.BackgroundImage = Resources.Pata1;
        }

        private void PBoxShut_MouseHover_1(object sender, EventArgs e)
        {
            PBoxShut.BackgroundImage = Resources.ShutDown2;
        }

        private void PBoxShut_MouseLeave_1(object sender, EventArgs e)
        {
            PBoxShut.BackgroundImage = Resources.ShutDown1;
        }

        private void PBoxShut_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PBoxEnter_Click(object sender, EventArgs e)
        {
            if (!Valida.Campo(txtLogNome, "Login"))
            {

                return;//interrompe função do botão          
            }

           if (!Valida.Campo(txtLogSenha, "Senha"))
            {

                return;//interrompe função do botão          
            }
          

            Usuario Usu = new Usuario();
            Usu.Login = txtLogNome.Text.Trim();
            Usu.Senha = txtLogSenha.Text;

            try
            {
                if (Usu.ValidaLogin())
                {

                    Util.tipo_usuario = Usu.Tipo;
                    this.Dispose();
                    
              
                }
                else
                {
                    Util.Mensagem("Usuário ou Senha inválidos !");
                    Limpar();
                }



            }
            catch (Exception ERRO)
            {

                Util.Mensagem("Falha na consulta ao banco de dados !\n" + ERRO.Message);
            }


        }

        private void Limpar()
        {
            txtLogNome.Clear();
            txtLogSenha.Clear();
            txtLogNome.Focus();
        }

   

        private void FrmLogin_Shown_1(object sender, EventArgs e)
        {
            txtLogNome.Focus();
            txtLogNome.Text = "Admin";
            txtLogSenha.Text = "123";
            //Util.tipo_usuario = 1;
            //this.Dispose();

        }


    }
}
