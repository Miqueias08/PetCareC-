using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetCareWork.Classes
{
    class Valida
    {
        public static bool Campo(TextBox txtbox, string msg)
        {
            if (string.IsNullOrEmpty(txtbox.Text.Trim()))
            {
                txtbox.BackColor = System.Drawing.Color.Yellow;
                Util.Mensagem("Campo" + msg + "Vazio ou Inválido!");
                txtbox.BackColor = System.Drawing.Color.White;
                return false;
            }
            return true;

        }

        public static bool Senha(TextBox txtsenha, TextBox txtRepSenha)
        {

            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                txtsenha.BackColor = System.Drawing.Color.Yellow;
                Util.Mensagem("Senha não informada ou Vazia");
                txtsenha.BackColor = System.Drawing.Color.White;
                return false;

            }

            if (txtsenha.Text.Length < 6)
            {
                txtsenha.BackColor = System.Drawing.Color.Yellow;
                Util.Mensagem("Senha deve conter minimo 6 caracteres ");
                txtsenha.BackColor = System.Drawing.Color.Red;
                return false;
            }

            if (txtsenha.Text != txtRepSenha.Text)
            {

                Util.Mensagem("Senhas não conferem");
                return false;

            }

            return true;

        }
    }
}
