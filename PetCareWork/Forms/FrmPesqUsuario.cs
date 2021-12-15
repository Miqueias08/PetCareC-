using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetCareWork.Classes;

namespace PetCareWork.Forms
{
    public partial class FrmPesqUsuario : Form
    {
        public FrmPesqUsuario()//metodo construtor
        {
            InitializeComponent();//isso é um método 
            Util.ConfigDataGrid(dgvUsuario);
        }

        private void chkPesquisar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPesquisar.Checked)
            {
                btnPesquisar.Enabled = false;
            }
            else
            {
                btnPesquisar.Enabled = true;
            }
        }

        private void Pesquisar()
        {
            Usuario user = new Usuario();
            user.Login = txtPesquisa.Text.Trim();
            // DataTableCollection res;

            try
            {
                DataTableCollection res = user.Pesquisar();
                dgvUsuario.DataSource = res[0];

                dgvUsuario.Columns[0].HeaderText = "Cód";
                dgvUsuario.Columns[1].HeaderText = "Nome usuário";
                dgvUsuario.Columns[2].HeaderText = "Tipo";

                dgvUsuario.Columns[0].Width = 20;
                dgvUsuario.Columns[2].Width = 30;
            }
            catch (Exception Erro)
            {

                Util.Mensagem("Erro durante a consulta\n" + Erro.Message);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (chkPesquisar.Checked)
            {

                Pesquisar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {

                Util.Mensagem("Selecione um usuário");
                return;
            }

            int id;
            string nome;
            id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);
            nome = dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();

            if (nome == "admin")
            {
                Util.Mensagem("Não é possivel excluir o administrador");
                return;//sem o return ele avisa mas exclui do mesmo jeito
            }

            if (Util.Pergunta("Deseja apagar o usuário " + nome + "?"))
            {
                try
                {
                    Usuario user = new Usuario();
                    user.Id = id;
                    user.Excluir();
                    Util.Mensagem("Usuário excluído com sucesso");
                    dgvUsuario.Rows.RemoveAt(dgvUsuario.SelectedRows[0].Index);
                }
                catch (Exception ERRO)
                {
                    Util.Mensagem("Falha durante a exclusão do usuário" + ERRO.Message);

                }
            }
        }

        private void btnAlteraSenha_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {

                Util.Mensagem("Selecione um usuário para trocar a senha");
                return;
            }

            int id;

            id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);

            Usuario user = new Usuario();
            user.Id = id;

            try
            {
                user.Buscar();
                FrmCadUsuario CadUser = new FrmCadUsuario(user);
                CadUser.ShowDialog();
            }
            catch (Exception ERRO)
            {

                Util.Mensagem("Falha na consulta dos dados\n" + ERRO.Message);


            }

        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {

                Util.Mensagem("Selecione um usuário");
                return;
            }

            int id;
            string nome;
            id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);
            nome = dgvUsuario.SelectedRows[0].Cells[1].Value.ToString();

            if (nome == "admin")
            {
                Util.Mensagem("Não é possivel excluir o administrador");
                return;//sem o return ele avisa mas exclui do mesmo jeito
            }

            if (Util.Pergunta("Deseja apagar o usuário " + nome + "?"))
            {
                try
                {
                    Usuario user = new Usuario();
                    user.Id = id;
                    user.Excluir();
                    Util.Mensagem("Usuário excluído com sucesso");
                    dgvUsuario.Rows.RemoveAt(dgvUsuario.SelectedRows[0].Index);
                }
                catch (Exception ERRO)
                {
                    Util.Mensagem("Falha durante a exclusão do usuário" + ERRO.Message);

                }
            }
        }

        private void btnAlteraSenha_Click_1(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {

                Util.Mensagem("Selecione um usuário para trocar a senha");
                return;
            }

            int id;

            id = Convert.ToInt32(dgvUsuario.SelectedRows[0].Cells[0].Value);

            Usuario user = new Usuario();
            user.Id = id;

            try
            {
                user.Buscar();
                FrmCadUsuario CadUser = new FrmCadUsuario(user);
                CadUser.ShowDialog();
            }
            catch (Exception ERRO)
            {

                Util.Mensagem("Falha na consulta dos dados\n" + ERRO.Message);


            }
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            if (chkPesquisar.Checked)
            {

                Pesquisar();
            }
        }
    }
}
