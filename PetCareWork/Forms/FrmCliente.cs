using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetCareWork.Classes;
using System.IO;

namespace PetCareWork.Forms
{
    public partial class FrmCliente : Form
    {
        Cliente CLICAD;//variável global
      

        public FrmCliente (Cliente C = null)
        {
            InitializeComponent();
            Util.ConfigDataGrid(dgvPesCli);

            if (C == null)
            {
                btnAlterar.Visible = true;
                GBOXCadCli.Visible = false;
            }
            else
            {

                txtNome.Text = C.Nome;
                txtCPF.Text = C.Cpf;
                DtNasc.Value = C.DataNasc;
                txtSexo.Text = C.Sexo;
                txtTelefone.Text = C.Telefone;
                txtCEP.Text = C.Cep;
                CmbEstado.Text = C.Uf;
                txtCidade.Text = C.Cidade;
                txtBairro.Text = C.Bairro;
                txtEndereco.Text = C.Endereco;

          
                GBOXPesCli.Visible = false;
                GBOXCadCli.Visible = true;
            }


            this.CLICAD = C;
        }

      
        private void Limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtSexo.Clear();
           
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            CmbEstado.Text = "";
            DtNasc.Text = "";

        }
        
        private void btnPesqCli_Click(object sender, EventArgs e)
        {
            GBOXCadCli.Visible = false;
            GBOXPesCli.Visible = true;
            GBoxListar.Visible = true;
            btnCadastrar.Visible = false;
            btnExcluir.Visible = true;
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            btnExcluir.Visible = false;
            GBOXPesCli.Visible = false;
            GBOXCadCli.Visible = true;
            btnAlterar.Visible = false;
            btnCadastrar.Visible = true;
            GBoxListar.Visible = false;
        }

        private void CamposChecked() {

            foreach (DataGridViewColumn coluna in dgvPesCli.Columns)
            {
                coluna.Visible = false;
                
            }

            if (chkNome.Checked) { 
                dgvPesCli.Columns["nome"].Visible = true;
            }

            if (chkEndereco.Checked)
            {
                dgvPesCli.Columns["endereco"].Visible = true;
            }

            if (chkBairro.Checked)
            {
                dgvPesCli.Columns["bairro"].Visible = true;
            }

            if (chkCidade.Checked)
            {
                dgvPesCli.Columns["Cidade"].Visible = true;
            }

            if (chkEstado.Checked)
            {
                dgvPesCli.Columns["UF"].Visible = true;
            }

            if (chkCep.Checked)
            {
                dgvPesCli.Columns["CEP"].Visible = true;
            }

            if (chkCPF.Checked)
            {
                dgvPesCli.Columns["CPF"].Visible = true;
            }

            if (chkTel.Checked)
            {
                dgvPesCli.Columns["telefone"].Visible = true;
            }
            
            if (chkDtNasc.Checked)
            {
                dgvPesCli.Columns["dataNasc"].Visible = true;
            }

              if (chkSexo.Checked)
            {
                 dgvPesCli.Columns["Sexo"].Visible = true;
            }

             

              if (chkTudo.Checked)
              {
                dgvPesCli.Columns["id"].Visible = true;
                dgvPesCli.Columns["nome"].Visible = true;
                dgvPesCli.Columns["endereco"].Visible = true;
                dgvPesCli.Columns["bairro"].Visible = true;
                dgvPesCli.Columns["cidade"].Visible = true;
                dgvPesCli.Columns["UF"].Visible = true;
                dgvPesCli.Columns["CEP"].Visible = true;
                dgvPesCli.Columns["CPF"].Visible = true;
                dgvPesCli.Columns["telefone"].Visible = true;
                dgvPesCli.Columns["dataNasc"].Visible = true;
                dgvPesCli.Columns["Sexo"].Visible = true;
                 }

            
        
        }
        
        private void Pesquisar()
        {
            Cliente Cli = new Cliente();
            // DataTableCollection res;

            try
            {
                Cli.Nome = txtOption.Text.Trim();
                DataTableCollection res = Cli.Pesquisar();
                dgvPesCli.DataSource = res[0];

                CamposChecked();

                dgvPesCli.Columns[0].HeaderText = "Cód";
                dgvPesCli.Columns[1].HeaderText = "Nome";
                dgvPesCli.Columns[2].HeaderText = "Endereço";
                dgvPesCli.Columns[3].HeaderText = "Bairro";
                dgvPesCli.Columns[4].HeaderText = "Cidade";
                dgvPesCli.Columns[5].HeaderText = "UF";
                dgvPesCli.Columns[6].HeaderText = "CEP";
                dgvPesCli.Columns[7].HeaderText = "CPF";
                dgvPesCli.Columns[8].HeaderText = "TEL";
                dgvPesCli.Columns[9].HeaderText = "DT Nasc";
                dgvPesCli.Columns[10].HeaderText = "Sexo";
                
                
                
                //dgvFuncPes.Columns[2].HeaderText = "Tipo";

                dgvPesCli.Columns[0].Width = 50;
                dgvPesCli.Columns[1].Width = 200;
                dgvPesCli.Columns[2].Width = 100;
                dgvPesCli.Columns[3].Width = 100;
                dgvPesCli.Columns[4].Width = 100;
                dgvPesCli.Columns[5].Width = 80;
                dgvPesCli.Columns[6].Width = 100;
                dgvPesCli.Columns[7].Width = 200;
                dgvPesCli.Columns[8].Width = 150;
                dgvPesCli.Columns[9].Width = 150;
                dgvPesCli.Columns[10].Width = 50;
              
            }
            catch (Exception Erro)
            {

                Util.Mensagem("Erro durante a consulta\n" + Erro.Message);
            }

        }
        
        //////////////////////////////////////////////////////////////////////////////////////////
        
        private void txtOption_TextChanged(object sender, EventArgs e)
        {
            if (CHKDinamico.Checked)
            {
                Pesquisar();
            }
        }

        private void CHKDinamico_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKDinamico.Checked)
            {
                Pesquisar();
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            
           
            

            if (dgvPesCli.CurrentRow == null)
            {
                GBOXPesCli.Visible = true;

                Util.Mensagem("Selecione um Cliente para atualizar");
                return;
            }

            string id;

            id = dgvPesCli.SelectedRows[0].Cells[0].Value.ToString();//erro indice fora do intervalo

            Cliente Cli = new Cliente();
            Cli.ID1 = id;

            try
            {
                Cli.Buscar();
                FrmCliente CadCli = new FrmCliente(Cli);//(CadCli)
                CadCli.ShowDialog();
                btnCadastrar.Visible = false;
                GBoxListar.Visible = false;
               
                
            }
            catch (Exception ERRO)
            {
                Util.Mensagem("Falha na consulta dos dados\n" + ERRO.Message);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dgvPesCli.CurrentRow == null)
            {
                Util.Mensagem("Selecione um Cliente");
                return;
            }

            string id;
            string nome;
            id = dgvPesCli.SelectedRows[0].Cells[0].Value.ToString();//erro  indice fora de intervalo
            nome = dgvPesCli.SelectedRows[0].Cells[1].Value.ToString();

            if (Util.Pergunta("Deseja apagar o Cliente " + nome + "?"))
            {
                try
                {

                    Cliente Cli = new Cliente();

                    Cli.ID1 = id;
                    Cli.Excluir();
                    Util.Mensagem("Cliente excluído com sucesso");
                    dgvPesCli.Rows.RemoveAt(dgvPesCli.SelectedRows[0].Index);
                }
                catch (Exception ERRO)
                {
                    Util.Mensagem("Falha durante a exclusão do Cliente" + ERRO.Message);

                }
            }

        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            Pesquisar();

        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            btnCadCli.Enabled = false;
            try
            {

                CLICAD.Nome = txtNome.Text;
                CLICAD.Cpf = txtCPF.Text;
                CLICAD.DataNasc = DtNasc.Value;

                CLICAD.Telefone = txtTelefone.Text;
                CLICAD.Cep = txtCEP.Text;
                CLICAD.Uf = CmbEstado.Text;//verificar
                CLICAD.Cidade = txtCidade.Text;
                CLICAD.Bairro = txtBairro.Text;
                CLICAD.Endereco = txtEndereco.Text;
                CLICAD.Sexo = txtSexo.Text;

                CLICAD.Atualizar();
                Util.Mensagem("Dados alterados com sucesso");
                this.Dispose();
            }
            catch (Exception ERRO)
            {

                Util.Mensagem("Falha na gravação dos dados. " + ERRO.Message);
            }

        }

        private void btnLimparCad_Click_1(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();

            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            CmbEstado.Text = "";
            DtNasc.Text = "";

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try //tabtab
            {
                Cliente CLICAD = new Cliente();


                if (txtNome.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha o campo Nome");
                    txtNome.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtCPF.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha o campo CPF");
                    txtCPF.BackColor = System.Drawing.Color.Pink;
                }
                //else if(DtNascFunc.Text.Trim() == DateTime.Now){ Util.Mensagem("Preencha o campo Data Nascimento");}

                else if (txtTelefone.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Telefone");
                    txtTelefone.BackColor = System.Drawing.Color.Pink;
                }

                else if (txtSexo.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Sexo");
                    txtSexo.BackColor = System.Drawing.Color.Pink;
                }

                else if (txtCEP.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo CEP");
                    txtCEP.BackColor = System.Drawing.Color.Pink;
                }
                else if (CmbEstado.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Estado");
                    CmbEstado.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtEndereco.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Endereço");
                    txtEndereco.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtBairro.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Bairro");
                    txtBairro.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtCidade.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Cidade");
                    txtCidade.BackColor = System.Drawing.Color.Pink;
                }

                else
                {

                    CLICAD.Nome = txtNome.Text;
                    CLICAD.Cpf = txtCPF.Text;
                    CLICAD.DataNasc = DtNasc.Value;
                    CLICAD.Telefone = txtTelefone.Text;
                    CLICAD.Cep = txtCEP.Text;
                    CLICAD.Uf = CmbEstado.Text;
                    CLICAD.Cidade = txtCidade.Text;
                    CLICAD.Bairro = txtBairro.Text;
                    CLICAD.Endereco = txtEndereco.Text;
                    CLICAD.Sexo = txtSexo.Text;
                    
                    CLICAD.Cadastro();

                    Util.Mensagem("Cliente Cadastrado");

                    Limpar();

                }

            }
            catch (Exception ERRO)
            {
                MessageBox.Show("Erro durante a inserção dos dados \n" + ERRO.Message);
                // Util.Mensagem("ERRO : " + Erro.Message);
                //throw;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destino = Environment.GetEnvironmentVariable("homedrive");
            destino += Environment.GetEnvironmentVariable("homepath");
            destino += @"\Desktop\testevisual";

            if (!Directory.Exists(destino)) {

                MessageBox.Show("Pasta de destino não existe");            
            }
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult resp = ofd.ShowDialog();

            if (resp == DialogResult.OK) {

                File.Copy(ofd.FileName, destino + @"\imagem.jpg");
                pictureBox1.Load(ofd.FileName);
            }

            MessageBox.Show(destino);
        }
    }
}
