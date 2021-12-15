using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetCareWork.Classes;
using MySql.Data.MySqlClient;

namespace PetCareWork.Forms
{
    public partial class FrmCadUsuario : Form
    {
        Usuario user;//variável global

        public FrmCadUsuario(Usuario u = null)//construtor
        {
            InitializeComponent();

            if (u == null)
            {
                lblTitulo.Text = "Cadastro de usuário";
                btnAltSenha.Enabled = false;
                btnGravar.Enabled = true;
            }
            else
            {
                lblTitulo.Text = " Alterar senha[" + u.Login + "]";
                btnAltSenha.Enabled = true;
                btnGravar.Enabled = false;
                txtLogin.Enabled = false;
                ChkBxAdimin.Enabled = false;
                txtLogin.Text = u.Login;

                if (u.Tipo == 1)
                {
                    ChkBxAdimin.Checked = true;
                }
                else
                {
                    ChkBxAdimin.Checked = true;

                }
                // ChkBxAdimin.Checked = (u.Tipo == 1) ? true : false; ternário               
            }
            this.user = u;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            /* if (!Valida.Campo(txtLogin, "Login"))
             {

                 return;
             }

             if (txtSenha != txtRepSenha)
             {
                 Util.Mensagem("Senhas não conferem");
                 return;
             }*/


            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;



            if (ChkBxAdimin.Checked)
            {
                user.Tipo = 1;
            }
            else
            {
                user.Tipo = 2;
            }

            //user.Tipo=(ChkBxAdimin.Checked) ? 1 : 2;

            try
            {
                user.Cadastro();
                Util.Mensagem("Cadastrado");
                Limpar();
            }
            catch (MySqlException ERRO)
            {
                string msgerro;
                switch (ERRO.Number)
                {
                    case 1062:
                        msgerro = "Este login já existe";
                        break;
                    case 1054:
                        msgerro = "Campo desconhecido no cadastro ";
                        break;
                    default:
                        msgerro = "Erro no Cadastro:\n" + ERRO.Message;
                        break;

                }

                Util.Mensagem(msgerro);
            }


        }

        public void Limpar()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtRepSenha.Clear();
            ChkBxAdimin.Checked = false;
            txtLogin.Focus();
        }

        private void btnAltSenha_Click(object sender, EventArgs e)
        {
            if (!Valida.Senha(txtSenha, txtRepSenha))
            {
                return;
            }
            try
            {
                user.Senha = txtSenha.Text;
                user.Atualizar();
                Util.Mensagem("Senha alterada com sucesso");
                this.Dispose();
            }
            catch (Exception ERRO)
            {
                Util.Mensagem("Falha na gravação dos dados" + ERRO.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPesqUsuario fpesUsuario = new FrmPesqUsuario();
            fpesUsuario.ShowDialog();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            /* if (!Valida.Campo(txtLogin, "Login"))
            {

                return;
            }

            if (txtSenha != txtRepSenha)
            {
                Util.Mensagem("Senhas não conferem");
                return;
            }*/


            Usuario user = new Usuario();
            user.Login = txtLogin.Text;
            user.Senha = txtSenha.Text;



            if (ChkBxAdimin.Checked)
            {
                user.Tipo = 1;
            }
            else
            {
                user.Tipo = 2;
            }

            //user.Tipo=(ChkBxAdimin.Checked) ? 1 : 2;

            try
            {
                user.Cadastro();
                Util.Mensagem("Cadastrado");
                Limpar();
            }
            catch (MySqlException ERRO)
            {
                string msgerro;
                switch (ERRO.Number)
                {
                    case 1062:
                        msgerro = "Este login já existe";
                        break;
                    case 1054:
                        msgerro = "Campo desconhecido no cadastro ";
                        break;
                    default:
                        msgerro = "Erro no Cadastro:\n" + ERRO.Message;
                        break;

                }

                Util.Mensagem(msgerro);
            }
        }

        private void btnAltSenha_Click_1(object sender, EventArgs e)
        {
            if(!Valida.Senha(txtSenha,txtRepSenha)){
            return;
            }
            try 
	        {	        
		      user.Senha =txtSenha.Text;
              user.Atualizar();
              Util.Mensagem("Senha alterada com sucesso");
              this.Dispose();
	        }
	        catch (Exception ERRO)
	        {
		
		        Util.Mensagem("Falha na gravação dos dados"+ERRO.Message);
	        }
                }
        }
    }

