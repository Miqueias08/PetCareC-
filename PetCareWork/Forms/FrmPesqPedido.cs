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
    public partial class FrmPesqPedido : Form
    {
        public FrmPesqPedido()
        {
            InitializeComponent();
            BuscaCliente();
            Util.ConfigDataGrid(dgvPedido);
            Util.ConfigDataGrid(dgvItensPedido);
        }

        private void BuscaCliente()
        {

            try
            {
                Cliente cli = new Cliente();
                DataTableCollection res = cli.Pesquisar();

                BindingSource bsRes = new BindingSource();

                bsRes.DataSource = res[0];
                bsRes.Sort = "nome ASC";

                DataRow novalinha = res[0].NewRow();
                novalinha["id"] = 0;//criando linha para pro non comboBox
                novalinha["Nome"] = " Selecione um Cliente...";

                res[0].Rows.InsertAt(novalinha, 0);

                CBOCliente.DataSource = res[0];
                CBOCliente.ValueMember = "id";    //pega o valor d ID
                CBOCliente.DisplayMember = "nome";//exibe o valor no combo dos de seleção
            }
            catch (Exception ERRO)
            {
                Util.Mensagem("Falha da consulta de cliente\n" + ERRO);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBOCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (CBOCliente.SelectedIndex < 1)
            {
                return;
            }
            dgvItensPedido.DataSource = null;
            lblValorTotal.Text = "          ";

            try
            {
                int idCliente = Convert.ToInt32(CBOCliente.SelectedValue);

                Pedido ped = new Pedido();
                DataTableCollection res = ped.Pesquisar(idCliente);
                dgvPedido.DataSource = res[0];

                dgvPedido.Columns["frete"].DefaultCellStyle.Format = "c";
            }
            catch (Exception ERRO)
            {

                Util.Mensagem(" Falha na consulda dos pedidos\n" + ERRO.Message);
            }
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedido.CurrentRow == null)
            {

                Util.Mensagem("Selecione um pedido");
            }
            try
            {
                int idPedido = Convert.ToInt32(dgvPedido.SelectedRows[0].Cells[0].Value);
                ItensPedido itens = new ItensPedido();
                DataTableCollection res = itens.Pesquisar(idPedido);

                dgvItensPedido.DataSource = res[0];
                dgvItensPedido.Columns["preco"].DefaultCellStyle.Format = "c";
                dgvItensPedido.Columns["desconto"].DefaultCellStyle.Format = "c";
                dgvItensPedido.Columns["Total"].DefaultCellStyle.Format = "c";
                double valorTotal = 0;

                foreach (DataGridViewRow linha in dgvItensPedido.Rows)//tabtab
                {
                    valorTotal += Convert.ToDouble(linha.Cells["Total"].Value);
                }

                lblValorTotal.Text = valorTotal.ToString("c");

                {

                }
            }
            catch (Exception ERRO)
            {
                Util.Mensagem("Falha na consulta de itens\n" + ERRO);

            }
        }
    }
}
