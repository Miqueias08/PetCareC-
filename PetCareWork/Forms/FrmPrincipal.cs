using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PetCareWork.Classes;
using PetCareWork.Properties;

namespace PetCareWork.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            if (Util.tipo_usuario == 1)
            {
               // cadasroToolStripmenuItemEnabled = true;
                AtivarModoAdministrador();
                label1.Text = "Administrador";
            }
            else {
                //cadasroToolStripmenuItemEnabled = false;
                AtivarModoUsuario();
                label1.Text = "Oreia Seca";
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AtivarModoAdministrador() {

            //CadUsuarioToolStripMenuItem.Enabled = true;
           // CadFuncionarioToolStripMenuItem.Enabled = true;
            //PesqFuncionarioToolStripMenuItem.Enabled = true;
            //PesqFuncionarioToolStripMenuItem.Enabled = true;
            this.ForeColor = System.Drawing.Color.Red;
        }
        private void AtivarModoUsuario()
        {

        }


        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Util.Pergunta("Deseja sair do sistema?"))
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void PBoxShut_MouseHover(object sender, EventArgs e)
        {
            PBoxShut.BackgroundImage = Resources.ShutDown2;
        }

        private void PBoxShut_MouseLeave(object sender, EventArgs e)
        {
            PBoxShut.BackgroundImage = Resources.ShutDown1;
        }

        private void PBoxShut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbButtons_MouseHover(object sender, EventArgs e)
        {
            if ((btnCli.Visible == false) && (btnProd.Visible == false) && (btnDates.Visible == false) && (btnCaixa.Visible == false) && (btnConf.Visible == false))
            {
                
                btnCli.Visible = true;
                btnProd.Visible = true;
                btnDates.Visible = true;
                btnCaixa.Visible = true;
                btnConf.Visible = true;


            }
            else
            {
               
                btnCli.Visible = false;
                btnProd.Visible = false;
                btnDates.Visible = false;
                btnCaixa.Visible = false;
                btnConf.Visible = false;
            }

            if (btnConf.Visible == false) {

                btnUsers.Visible = false;
                btnFuncionario.Visible = false;
              
                btnClear.Visible = false;
            }
        }

    

       

        private void PbButtons_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void btnCli_MouseHover_1(object sender, EventArgs e)
        {
            btnCli.BackgroundImage = Resources.IconCli2;
        }

        private void btnCli_MouseLeave(object sender, EventArgs e)
        {
            btnCli.BackgroundImage = Resources.IconCli1;
        }

        private void btnProd_MouseHover(object sender, EventArgs e)
        {
            btnProd.BackgroundImage = Resources.IconProd2;
        }

        private void btnProd_MouseLeave(object sender, EventArgs e)
        {
            btnProd.BackgroundImage = Resources.IconProd1;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnDates.BackgroundImage = Resources.IconDates2;
            
        }

        private void btnDates_MouseLeave(object sender, EventArgs e)
        {
            btnDates.BackgroundImage = Resources.IconDates1;
        }

        private void btnCaixa_MouseHover(object sender, EventArgs e)
        {
            btnCaixa.BackgroundImage = Resources.IconCoin2;
        }

        private void btnCaixa_MouseLeave(object sender, EventArgs e)
        {
            btnCaixa.BackgroundImage = Resources.IconCoin1;
        }

        private void btnConf_MouseHover(object sender, EventArgs e)
        {
            btnConf.BackgroundImage = Resources.eng2;
        }

        private void btnConf_MouseLeave(object sender, EventArgs e)
        {
            btnConf.BackgroundImage = Resources.eng;
        }

        private void btnConf_Click_1(object sender, EventArgs e)
        {
            if ( btnClear.Visible == false)
            {
                btnUsers.Visible = true;
               
                btnClear.Visible = true;
                btnFuncionario.Visible = true;
               
            }
            else
            {
               
                btnClear.Visible = false;
                btnUsers.Visible = false;
                btnFuncionario.Visible = false;
            }

        }

        private void FrmPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (Util.Pergunta("Deseja sair do sistema?"))
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPesqPedido fdPED = new FrmPesqPedido();
            fdPED.ShowDialog();
        }


        private void btnCli_Click(object sender, EventArgs e)
        {
            FrmCliente Cli = new FrmCliente ();
            Cli.ShowDialog();
            
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario CadFunc = new FrmFuncionario();
            CadFunc.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FrmCadUsuario CadUser = new FrmCadUsuario();
            CadUser.ShowDialog();
        }

        private void btnWPaper_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Selecione uma foto";
            open.Filter = "Arquivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {

                this.BackgroundImage = new Bitmap(open.FileName);

            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            FrmProduto Fprod = new FrmProduto();
            Fprod.Show();
        }

        private void FrmPrincipal_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Selecione uma foto";
            open.Filter = "Arquivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {

                this.BackgroundImage = new Bitmap(open.FileName);

            }

        }

    

        }

    }

