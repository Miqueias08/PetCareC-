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
    public partial class FrmFuncionario : Form
    {
        Funcionario FUNCAD;//variável global
       // private Funcionario Func;

        public FrmFuncionario(Funcionario F = null)
        {
            InitializeComponent();
            Util.ConfigDataGrid(dgvFuncPes);

            if (F == null)
            {
                btnAlterar.Visible = true;
                GBOXCadFunc.Visible = false;
            }
            else
            {
                txtNome.Text = F.NOME1;
                txtCPF.Text = F.CPF1;
                //Convert.ToString(DtNascFunc.Value)=FuncAct.DTNsc1;
                txtCTPS.Text = F.CTPS1;
                txtTelefone.Text = F.TEL1;
                txtCEP.Text = F.CEP1;
                CmbEstado.Text = F.UF1;
                txtCidade.Text = F.CIDADE1;
                txtBairro.Text = F.BAIRRO1;
                txtEndereco.Text = F.ENDER1;

                txtConta.Text = F.CONTA1;
                txtAgencia.Text = F.AGENCIA1;
                GBOXPesFunc.Visible = false;
                GBOXCadFunc.Visible = true;
            }


            this.FUNCAD = F;
        }

      
        private void Limpar()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtCTPS.Clear();
            txtAgencia.Clear();
            txtConta.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            CmbEstado.Text = "";
            DtNascFunc.Text = "";

        }
        private void CamposChecked()
        {

            foreach (DataGridViewColumn coluna in dgvFuncPes.Columns)
            {
                coluna.Visible = false;

            }

            if (chkNome.Checked)
            {
                dgvFuncPes.Columns["nome"].Visible = true;
            }

            if (chkEndereco.Checked)
            {
                dgvFuncPes.Columns["endereco"].Visible = true;
            }

            if (chkBairro.Checked)
            {
                dgvFuncPes.Columns["bairro"].Visible = true;
            }

            if (chkCidade.Checked)
            {
                dgvFuncPes.Columns["Cidade"].Visible = true;
            }

            if (chkEstado.Checked)
            {
                dgvFuncPes.Columns["UF"].Visible = true;
            }

            if (chkCep.Checked)
            {
                dgvFuncPes.Columns["CEP"].Visible = true;
            }

            if (chkCPF.Checked)
            {
                dgvFuncPes.Columns["CPF"].Visible = true;
            }

            if (chkTel.Checked)
            {
                dgvFuncPes.Columns["telefone"].Visible = true;
            }

            if (chkDtNasc.Checked)
            {
                dgvFuncPes.Columns["dataNasc"].Visible = true;
            }

            if (chkCTPS.Checked)
            {
                dgvFuncPes.Columns["CTPS"].Visible = true;
            }
            
            if (chkAgencia.Checked)
            {
                dgvFuncPes.Columns["Agência"].Visible = true;
            }
            if (chkConta.Checked)
            {
                dgvFuncPes.Columns["Conta"].Visible = true;
            }



            if (chkTudo.Checked)
            {
                dgvFuncPes.Columns["id"].Visible = true;
                dgvFuncPes.Columns["nome"].Visible = true;
                dgvFuncPes.Columns["endereco"].Visible = true;
                dgvFuncPes.Columns["bairro"].Visible = true;
                dgvFuncPes.Columns["cidade"].Visible = true;
                dgvFuncPes.Columns["UF"].Visible = true;
                dgvFuncPes.Columns["CEP"].Visible = true;
                dgvFuncPes.Columns["CPF"].Visible = true;
                dgvFuncPes.Columns["telefone"].Visible = true;
                dgvFuncPes.Columns["dataNasc"].Visible = true;
                dgvFuncPes.Columns["CTPS"].Visible = true;
                dgvFuncPes.Columns["Agencia"].Visible = true;
                dgvFuncPes.Columns["Conta"].Visible = true;
            }



        }

        private void Pesquisar()
        {
            Funcionario Func = new Funcionario();
            // DataTableCollection res;

            try
            {
                Func.NOME1 = txtOption.Text.Trim();
                DataTableCollection res = Func.Pesquisar();
                dgvFuncPes.DataSource = res[0];

                CamposChecked();

                dgvFuncPes.Columns[0].HeaderText = "Cód";
                dgvFuncPes.Columns[1].HeaderText = "Nome";
                dgvFuncPes.Columns[2].HeaderText = "Telefone";
                dgvFuncPes.Columns[3].HeaderText = "CPF";
                dgvFuncPes.Columns[4].HeaderText = "CTPS";
                dgvFuncPes.Columns[5].HeaderText = "Agencia";
                dgvFuncPes.Columns[6].HeaderText = "Conta";
                dgvFuncPes.Columns[7].HeaderText = "Endereço";
                dgvFuncPes.Columns[8].HeaderText = "Bairro";
                dgvFuncPes.Columns[9].HeaderText = "Cidade";
                dgvFuncPes.Columns[10].HeaderText = "UF";
                dgvFuncPes.Columns[11].HeaderText = "Cep";
                dgvFuncPes.Columns[12].HeaderText = "Data de Nascimento";
                //dgvFuncPes.Columns[2].HeaderText = "Tipo";

                dgvFuncPes.Columns[0].Width = 50;
                dgvFuncPes.Columns[1].Width = 200;
                dgvFuncPes.Columns[2].Width = 100;
                dgvFuncPes.Columns[3].Width = 100;
                dgvFuncPes.Columns[4].Width = 100;
                dgvFuncPes.Columns[5].Width = 80;
                dgvFuncPes.Columns[6].Width = 100;
                dgvFuncPes.Columns[7].Width = 200;
                dgvFuncPes.Columns[8].Width = 150;
                dgvFuncPes.Columns[9].Width = 150;
                dgvFuncPes.Columns[10].Width = 50;
                dgvFuncPes.Columns[11].Width = 100;
                dgvFuncPes.Columns[12].Width = 100;
            }
            catch (Exception Erro)
            {

                Util.Mensagem("Erro durante a consulta\n" + Erro.Message);
            }

        }

        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            GBOXPesFunc.Visible = false;
            GBOXCadFunc.Visible = true;
            btnAlterar.Visible = false;

            btnCadastrar.Visible = true;
            GBoxListar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnPesquisaFunc_Click(object sender, EventArgs e)
        {
            GBOXCadFunc.Visible = false;
            GBOXPesFunc.Visible = true;

            GBoxListar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncPes.CurrentRow == null)
            {
                Util.Mensagem("Selecione um Funcionário");
                return;
            }

            string id;
            string nome;
            id = dgvFuncPes.SelectedRows[0].Cells[0].Value.ToString();//erro  indice fora de intervalo
            nome = dgvFuncPes.SelectedRows[0].Cells[1].Value.ToString();

            if (Util.Pergunta("Deseja apagar o Funcionário " + nome + "?"))
            {
                try
                {

                    Funcionario Func = new Funcionario();

                    Func.ID1 = id;
                    Func.Excluir();
                    Util.Mensagem("Funcionário excluído com sucesso");
                    dgvFuncPes.Rows.RemoveAt(dgvFuncPes.SelectedRows[0].Index);
                }
                catch (Exception ERRO)
                {
                    Util.Mensagem("Falha durante a exclusão do Funcionário" + ERRO.Message);

                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try //tabtab
            {
                Funcionario FUNCAD = new Funcionario();


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
                else if (txtCTPS.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo CTPS");
                    txtCTPS.BackColor = System.Drawing.Color.Pink;
                }

                else if (txtAgencia.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Agencia");
                    txtAgencia.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtConta.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha campo Conta");
                    txtConta.BackColor = System.Drawing.Color.Pink;
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

                    FUNCAD.NOME1 = txtNome.Text;
                    FUNCAD.CPF1 = txtCPF.Text;
                    FUNCAD.DTNsc1 = DtNascFunc.Value;
                    FUNCAD.CTPS1 = txtCTPS.Text;
                    FUNCAD.TEL1 = txtTelefone.Text;
                    FUNCAD.CEP1 = txtCEP.Text;
                    FUNCAD.UF1 = CmbEstado.Text;
                    FUNCAD.CIDADE1 = txtCidade.Text;
                    FUNCAD.BAIRRO1 = txtBairro.Text;
                    FUNCAD.ENDER1 = txtEndereco.Text;
                    FUNCAD.CONTA1 = txtConta.Text;
                    FUNCAD.AGENCIA1 = txtAgencia.Text;


                    FUNCAD.Cadastro();
                    Util.Mensagem("Funcionário Cadastrado");

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

        private void btnLimparCad_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
            txtCTPS.Clear();
            txtAgencia.Clear();
            txtConta.Clear();
            txtCEP.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            CmbEstado.Text = "";
            DtNascFunc.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnCadastroFunc.Enabled = false;
            try
            {

                FUNCAD.NOME1 = txtNome.Text;
                FUNCAD.CPF1 = txtCPF.Text;
                FUNCAD.DTNsc1 = DtNascFunc.Value;
                FUNCAD.CTPS1 = txtCTPS.Text;
                FUNCAD.TEL1 = txtTelefone.Text;
                FUNCAD.CEP1 = txtCEP.Text;
                FUNCAD.UF1 = CmbEstado.Text;//verificar
                FUNCAD.CIDADE1 = txtCidade.Text;
                FUNCAD.BAIRRO1 = txtBairro.Text;
                FUNCAD.ENDER1 = txtEndereco.Text;

                FUNCAD.CONTA1 = txtConta.Text;
                FUNCAD.AGENCIA1 = txtAgencia.Text;

                FUNCAD.Atualizar();
                Util.Mensagem("Dados alterados com sucesso");
                this.Dispose();
            }
            catch (Exception ERRO)
            {

                Util.Mensagem("Falha na gravação dos dados. " + ERRO.Message);
            }
        }

        private void txtOption_TextChanged(object sender, EventArgs e)
        {
            if (CHKDinamico.Checked)
            {
                Pesquisar();
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          
           
            
            if (dgvFuncPes.CurrentRow == null)
            {
                GBOXPesFunc.Visible = true;

                Util.Mensagem("Selecione um funcionário para atualizar");
                return;
            }

            string id;

            id = dgvFuncPes.SelectedRows[0].Cells[0].Value.ToString();

            Funcionario Func = new Funcionario();
            Func.ID1 = id;

            try
            {
                Func.Buscar();
                FrmFuncionario CadFunc = new FrmFuncionario(Func);
                CadFunc.ShowDialog();
               /* btnCadastrar.Visible = false;
                btnAlterar.Visible = true;
                GBOXCadFunc.Text = "Atualizar Funcionário";
                GBoxListar.Visible = false;
                btnExcluir.Visible = false;*/
                
            }
            catch (Exception ERRO)
            {
                Util.Mensagem("Falha na consulta dos dados\n" + ERRO.Message);
            }
            
        }
    }
}
