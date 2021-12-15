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
using PetCareWork.DBConnection;

namespace PetCareWork.Forms
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
            Util.ConfigDataGrid(DGVProdSearch);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPesqPedido fdPED = new FrmPesqPedido();
            fdPED.ShowDialog();
        }
        ////////////////////////////////////////////////

         private void CamposChecked() {

            foreach (DataGridViewColumn coluna in DGVProdSearch.Columns)
            {
                coluna.Visible = false;
                
            }

             ////inicio da Lista do banco de dados
            if (chkProdNome.Checked) { 
                DGVProdSearch.Columns["NOME"].Visible = true;
            }

            if (chkProdTipo.Checked)
            {
                DGVProdSearch.Columns["TIPO"].Visible = true;
            }

            if (chkPara.Checked)
            {
                DGVProdSearch.Columns["PARA"].Visible = true;
            }

            if (chkMarca.Checked)
            {
                DGVProdSearch.Columns["MARCA"].Visible = true;
            }

            if (chkUnid.Checked)
            {
                DGVProdSearch.Columns["UNIT"].Visible = true;
            }

            if (chkPeso.Checked)
            {
                DGVProdSearch.Columns["PESO"].Visible = true;
            }

            if (chkCNPJ.Checked)
            {
                DGVProdSearch.Columns["CNPJ"].Visible = true;
            }

            if (chkFabric.Checked)
            {
                DGVProdSearch.Columns["FABRIC"].Visible = true;
            }
            
            if (chkValid.Checked)
            {
                DGVProdSearch.Columns["VALIDADE"].Visible = true;
            }

              if (chkComp.Checked)
            {
                 DGVProdSearch.Columns["DTCOMP"].Visible = true;
            }

             if (chkCusto.Checked)
            {
                DGVProdSearch.Columns["CUSTO"].Visible = true;
            }

            if (chkLote.Checked)
            {
                DGVProdSearch.Columns["LOTE"].Visible = true;
            }

            if (chkCadastrante.Checked)
            {
                DGVProdSearch.Columns["CADASTRANTE"].Visible = true;
            }

            if (chkDtProdCad.Checked)
            {
                DGVProdSearch.Columns["DTPRODCAD"].Visible = true;
            }
            
            if (chkEmEst.Checked)
            {
                DGVProdSearch.Columns["qtdEstoque"].Visible = true;
            }
             
            
             if (chkTudo.Checked)
              {
                DGVProdSearch.Columns["id"].Visible = true;
                DGVProdSearch.Columns["TIPO"].Visible = true;
                DGVProdSearch.Columns["NOME"].Visible = true;
                DGVProdSearch.Columns["PARA"].Visible = true;
                DGVProdSearch.Columns["MARCA"].Visible = true;
                DGVProdSearch.Columns["UNIT"].Visible = true;
                DGVProdSearch.Columns["PESO"].Visible = true;
                DGVProdSearch.Columns["CNPJ"].Visible = true;
                DGVProdSearch.Columns["FABRIC"].Visible = true;
                DGVProdSearch.Columns["VALIDADE"].Visible = true;
                DGVProdSearch.Columns["DTCOMP"].Visible = true;
                DGVProdSearch.Columns["CUSTO"].Visible = true;
                
                DGVProdSearch.Columns["LOTE"].Visible = true;
                DGVProdSearch.Columns["CADASTRANTE"].Visible = true;
                DGVProdSearch.Columns["DTPRODCAD"].Visible = true;
                DGVProdSearch.Columns["qtdEstoque"].Visible = true;
                 }
             
             ////fim da Lista do banco de dados
            
        
        }

         private void Pesquisar()
         {
             Produto Prod = new Produto();
             // DataTableCollection res;

             try
             {
                 Prod.NOME1 = txtOption.Text.Trim();
                 DataTableCollection res = Prod.Pesquisar();
                 DGVProdSearch.DataSource = res[0];

                 CamposChecked();
                 //Como será apresentado na tela da pesquisa
                 DGVProdSearch.Columns[0].HeaderText = "Id";
                 DGVProdSearch.Columns[1].HeaderText = "Tipo";
                 DGVProdSearch.Columns[2].HeaderText = "Nome";
                 DGVProdSearch.Columns[3].HeaderText = "Para?";
                 DGVProdSearch.Columns[4].HeaderText = "Marca";
                 DGVProdSearch.Columns[5].HeaderText = "Unid";
                 DGVProdSearch.Columns[6].HeaderText = "Peso";
                 DGVProdSearch.Columns[7].HeaderText = "CNPJ";
                 DGVProdSearch.Columns[8].HeaderText = "Fabric";
                 DGVProdSearch.Columns[9].HeaderText = "Validade";
                 DGVProdSearch.Columns[10].HeaderText = "DtCompra";
                 DGVProdSearch.Columns[11].HeaderText = "ValComp";
                 DGVProdSearch.Columns[12].HeaderText = "Lote";
                 DGVProdSearch.Columns[13].HeaderText = "Cadastrante";
                 DGVProdSearch.Columns[14].HeaderText = "DTCadastro";
                 DGVProdSearch.Columns[15].HeaderText = "QuantEstq";

                 //DGVProdSearch.Columns[2].HeaderText = "Tipo";


             }
             catch (Exception Erro)
             {

                 Util.Mensagem("Erro durante a consulta\n" + Erro.Message);
             }
         }

        
        
        
        private void btnCadProd_Click(object sender, EventArgs e)
        {

           
            try
            {
                Produto ProdCad = new Produto();
                ProdCad.TIPO1 = GBoxTipoProdCad.Text;
                ProdCad.NOME1 = txtNomeProd.Text;
                ProdCad.PARA1 = GBoxParaProdCad.Text;
                ProdCad.MARCA1 = txtMarca.Text;
                ProdCad.UNIT1 = txtQuantProd.Text;
                ProdCad.PESO1 = txtPesoProd.Text;
                ProdCad.CNPJ1 = txtCNPJ.Text;
                ProdCad.FABRIC1 = txtFabricProd.Text;
                ProdCad.VALID1 = txtValProd.Text;
                ProdCad.DTCOMP1 = txtDataCompraProd.Text;
                ProdCad.CUSTO1 = txtCustoProd.Text;
                ProdCad.LOTE1 = txtLoteProd.Text;
                ProdCad.CADASTRANTE1 = txtCadResp.Text;
                ProdCad.DTCADPROD1 = Convert.ToString(txtDiaCadProd.Value);
                ProdCad.GravarProd();

            }
            catch (Exception ERRO)
            {
                MessageBox.Show("Erro durante a Inserção dos dados \n" + ERRO.Message);

                //throw;
            }

        }


    

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListBoxCadProd.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item");
            }

            else
            {
                ListBoxCadProd.Items.Remove(
                    ListBoxCadProd.Items[ListBoxCadProd.SelectedIndex]
                  );
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ListBoxCadProd.Items.Clear();
        }

        private void btnCadProdOp_Click(object sender, EventArgs e)
        {
            GBoxCheckProd.Visible = false;
            GBoxCadProd.Visible = true;
        }

        private void btnCheckProdOp_Click(object sender, EventArgs e)
        {
            GBoxCheckProd.Visible = true;
            GBoxCadProd.Visible = false;
        }

       

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

  

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        



        private void btnCadProdOp_Click_1(object sender, EventArgs e)
        {
            GBoxCheckProd.Visible = false;
            GBoxCadProd.Visible = true;
        }

        private void btnCheckProdOp_Click_1(object sender, EventArgs e)
        {
            GBoxCheckProd.Visible = true;
            GBoxCadProd.Visible = false;
        }

        private void txtOption_TextChanged(object sender, EventArgs e)
        {
            if (CHKDinamico.Checked)
            {
                Pesquisar();
            }
        }

        private void btnCadProd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFim_Click_1(object sender, EventArgs e)
        {
            ListBoxCadProd.Items.Add("Tipo :" + GBoxTipoProdCad.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Para :" + GBoxParaProdCad.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Nome :" + txtNomeProd.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Marca :" + txtMarca.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Unidades :" + txtQuantProd.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Peso :" + txtPesoProd.Text.Trim().ToUpper() + " " + CBPesoMedidaProd.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("CNPJ :" + txtCNPJ.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Data Fabric :" + txtFabricProd.Text.Trim());
            ListBoxCadProd.Items.Add("Validade :" + txtValProd.Text.Trim());

            ListBoxCadProd.Items.Add("Data Compra :" + txtDataCompraProd.Text.Trim());
            ListBoxCadProd.Items.Add("Valor :" + txtCustoProd.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Lote :" + txtLoteProd.Text.Trim().ToUpper());
            ListBoxCadProd.Items.Add("Data Cadastro :" + txtDiaCadProd.Text.Trim());
            ListBoxCadProd.Items.Add("Responsável :" + txtCadResp.Text.Trim().ToUpper());
        }

        private void btnLimparCad_Click(object sender, EventArgs e)//////////////////////////////
        {
            Limpar();
        }

        private void Limpar(){
            
            txtNomeProd.Clear();
            GBoxTipoProdCad.Text = "";
            GBoxParaProdCad.Text = "";
            txtMarca.Clear();
            txtQuantProd.Clear();
            txtPesoProd.Clear();
            txtCNPJ.Clear();
            txtFabricProd.Clear();
            txtValProd.Clear();
            txtDataCompraProd.Clear();
            txtCustoProd.Clear();
            txtLoteProd.Text = "";
            txtCadResp.Text = "";
        }

        private void btnCadProd_Click_2(object sender, EventArgs e)
        {
            try
            {
                Produto ProdCad = new Produto();


                if (GBoxTipoProdCad.Text == "")
                {
                    Util.Mensagem("Selecione um Tipo");
                    GBoxTipoProdCad.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtNomeProd.Text.Trim() == "")
                {
                    Util.Mensagem("Preencha o campo Nome");
                    txtNomeProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (GBoxParaProdCad.Text == "")
                {
                    Util.Mensagem("Selecione uma espécie");
                    GBoxParaProdCad.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtMarca.Text == "")
                {
                    Util.Mensagem("Preencha o campo Marca");
                    txtMarca.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtPesoProd.Text == "")
                {
                    Util.Mensagem("Preencha o campo Peso");
                    txtPesoProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtCNPJ.Text == "")
                {
                    Util.Mensagem("Preencha o campo CNPJ");
                    txtCNPJ.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtFabricProd.Text == "")
                {
                    Util.Mensagem("Informe a Data de Fabricação");
                    txtFabricProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtValProd.Text == "")
                {
                    Util.Mensagem("Informe a Validade");
                    txtValProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtDataCompraProd.Text == "")
                {
                    Util.Mensagem("Informe a Data da Compra");
                    txtDataCompraProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtCustoProd.Text == "")
                {
                    Util.Mensagem("Informe o Valor");
                    txtCustoProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtLoteProd.Text == "")
                {
                    Util.Mensagem("Informe o Lote");
                    txtLoteProd.BackColor = System.Drawing.Color.Pink;
                }
                else if (txtCadResp.Text == "")
                {
                    Util.Mensagem("Informe o Cadastrante");
                    txtCadResp.BackColor = System.Drawing.Color.Pink;
                }


                else
                {
                    ProdCad.TIPO1 = GBoxTipoProdCad.Text;//
                    ProdCad.NOME1 = txtNomeProd.Text;//
                    ProdCad.PARA1 = GBoxParaProdCad.Text;//
                    ProdCad.MARCA1 = txtMarca.Text;//
                    ProdCad.UNIT1 = txtQuantProd.Text;//
                    ProdCad.PESO1 = txtPesoProd.Text;//
                    ProdCad.CNPJ1 = txtCNPJ.Text;//
                    ProdCad.FABRIC1 = txtFabricProd.Text;//
                    ProdCad.VALID1 = txtValProd.Text;//
                    ProdCad.DTCOMP1 = txtDataCompraProd.Text;//
                    ProdCad.CUSTO1 = txtCustoProd.Text;//
                    ProdCad.LOTE1 = txtLoteProd.Text;//
                    ProdCad.CADASTRANTE1 = txtCadResp.Text;
                    ProdCad.DTCADPROD1 = Convert.ToString(txtDiaCadProd.Value);
                    ProdCad.GravarProd();
                    Util.Mensagem("Produto Cadastrado");

                    Limpar();
                    ListBoxCadProd.Items.Clear();
                }

            }
            catch (Exception ERRO)
            {
                MessageBox.Show("Erro durante a Inserção dos dados \n" + ERRO.Message);

                //throw;
            }
        }

        private void btnCheckProd_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

       

        private void btnDelistCheckProd_Click(object sender, EventArgs e)
        {
            if (DGVProdSearch.CurrentRow == null)
            {
                Util.Mensagem("Selecione um Produto");
                return;
            }

            string id;
            string nome;
            id = DGVProdSearch.SelectedRows[0].Cells[0].Value.ToString();
            nome = DGVProdSearch.SelectedRows[0].Cells[2].Value.ToString();

            if (Util.Pergunta("Deseja apagar o Produto " + nome + "?"))
            {
                try
                {

                    Produto DelProd = new Produto();

                    //DelProd.NOME1 = nome;
                    DelProd.ID1 = Convert.ToInt32(id);
                    DelProd.Excluir();
                    Util.Mensagem("Produto excluído com sucesso");
                    DGVProdSearch.Rows.RemoveAt(DGVProdSearch.SelectedRows[0].Index);
                }
                catch (Exception ERRO)
                {
                    Util.Mensagem("Falha durante a exclusão do Produto" + ERRO.Message);

                }
            }
        }

        public void CBOptionProd_SelectedIndexChanged(object sender, EventArgs e)
        {

            string OptionProd = Convert.ToString(CBOptionProd.SelectedIndex);
           
            
        }

        private void btnClearListCheckProd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (ListBoxCadProd.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um item");
            }

            else
            {
                ListBoxCadProd.Items.Remove(
                    ListBoxCadProd.Items[ListBoxCadProd.SelectedIndex]
                  );
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            ListBoxCadProd.Items.Clear();
        }

        private void GBoxTipoProdCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            GBoxTipoProdCad.BackColor=System.Drawing.Color.White;
        }

        private void GBoxParaProdCad_SelectedIndexChanged(object sender, EventArgs e)
        {
            GBoxParaProdCad.BackColor = System.Drawing.Color.White;
        }

        private void txtNomeProd_TextChanged(object sender, EventArgs e)
        {
            txtNomeProd.BackColor = System.Drawing.Color.White;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.BackColor = System.Drawing.Color.White;
        }

        private void txtQuantProd_TextChanged(object sender, EventArgs e)
        {
            txtQuantProd.BackColor = System.Drawing.Color.White;
        }

        private void txtPesoProd_TextChanged(object sender, EventArgs e)
        {
            txtPesoProd.BackColor = System.Drawing.Color.White;
        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            txtCNPJ.BackColor = System.Drawing.Color.White;
        }

        private void txtFabricProd_TextChanged(object sender, EventArgs e)
        {
            txtFabricProd.BackColor = System.Drawing.Color.White;
        }

        private void txtValProd_TextChanged(object sender, EventArgs e)
        {
            txtValProd.BackColor = System.Drawing.Color.White;
        }

        private void txtDataCompraProd_TextChanged(object sender, EventArgs e)
        {
            txtDataCompraProd.BackColor = System.Drawing.Color.White;
        }

        private void txtCustoProd_TextChanged(object sender, EventArgs e)
        {
            txtCustoProd.BackColor = System.Drawing.Color.White;
        }

        private void txtLoteProd_TextChanged(object sender, EventArgs e)
        {
            txtLoteProd.BackColor = System.Drawing.Color.White;
        }

        private void txtCadResp_TextChanged(object sender, EventArgs e)
        {
            txtCadResp.BackColor = System.Drawing.Color.White;
        }
    }
}
