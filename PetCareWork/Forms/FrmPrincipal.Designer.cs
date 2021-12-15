namespace PetCareWork.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.PictureBox();
            this.btnCaixa = new System.Windows.Forms.PictureBox();
            this.btnDates = new System.Windows.Forms.PictureBox();
            this.btnProd = new System.Windows.Forms.PictureBox();
            this.btnCli = new System.Windows.Forms.PictureBox();
            this.PbButtons = new System.Windows.Forms.PictureBox();
            this.PBoxShut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnConf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxShut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1225, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(130, 673);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 27);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Screen";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Black;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(130, 601);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(70, 27);
            this.btnUsers.TabIndex = 14;
            this.btnUsers.Text = "Usuários";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Visible = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Black;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Location = new System.Drawing.Point(206, 601);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(89, 27);
            this.btnFuncionario.TabIndex = 24;
            this.btnFuncionario.Text = "Funcionarios";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Visible = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.Transparent;
            this.btnConf.BackgroundImage = global::PetCareWork.Properties.Resources.eng;
            this.btnConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConf.Location = new System.Drawing.Point(19, 591);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(105, 109);
            this.btnConf.TabIndex = 22;
            this.btnConf.TabStop = false;
            this.btnConf.Visible = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click_1);
            this.btnConf.MouseLeave += new System.EventHandler(this.btnConf_MouseLeave);
            this.btnConf.MouseHover += new System.EventHandler(this.btnConf_MouseHover);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.Transparent;
            this.btnCaixa.BackgroundImage = global::PetCareWork.Properties.Resources.IconCoin1;
            this.btnCaixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaixa.Location = new System.Drawing.Point(19, 476);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(105, 109);
            this.btnCaixa.TabIndex = 21;
            this.btnCaixa.TabStop = false;
            this.btnCaixa.Visible = false;
            this.btnCaixa.MouseLeave += new System.EventHandler(this.btnCaixa_MouseLeave);
            this.btnCaixa.MouseHover += new System.EventHandler(this.btnCaixa_MouseHover);
            // 
            // btnDates
            // 
            this.btnDates.BackColor = System.Drawing.Color.Transparent;
            this.btnDates.BackgroundImage = global::PetCareWork.Properties.Resources.IconDates1;
            this.btnDates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDates.Location = new System.Drawing.Point(19, 361);
            this.btnDates.Name = "btnDates";
            this.btnDates.Size = new System.Drawing.Size(105, 109);
            this.btnDates.TabIndex = 20;
            this.btnDates.TabStop = false;
            this.btnDates.Visible = false;
            this.btnDates.MouseLeave += new System.EventHandler(this.btnDates_MouseLeave);
            this.btnDates.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.Color.Transparent;
            this.btnProd.BackgroundImage = global::PetCareWork.Properties.Resources.IconProd1;
            this.btnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProd.Location = new System.Drawing.Point(19, 246);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(105, 109);
            this.btnProd.TabIndex = 20;
            this.btnProd.TabStop = false;
            this.btnProd.Visible = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            this.btnProd.MouseLeave += new System.EventHandler(this.btnProd_MouseLeave);
            this.btnProd.MouseHover += new System.EventHandler(this.btnProd_MouseHover);
            // 
            // btnCli
            // 
            this.btnCli.BackColor = System.Drawing.Color.Transparent;
            this.btnCli.BackgroundImage = global::PetCareWork.Properties.Resources.IconCli1;
            this.btnCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCli.Location = new System.Drawing.Point(19, 131);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(105, 109);
            this.btnCli.TabIndex = 20;
            this.btnCli.TabStop = false;
            this.btnCli.Visible = false;
            this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
            this.btnCli.MouseLeave += new System.EventHandler(this.btnCli_MouseLeave);
            this.btnCli.MouseHover += new System.EventHandler(this.btnCli_MouseHover_1);
            // 
            // PbButtons
            // 
            this.PbButtons.BackColor = System.Drawing.Color.Transparent;
            this.PbButtons.BackgroundImage = global::PetCareWork.Properties.Resources.BigHeart;
            this.PbButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbButtons.Location = new System.Drawing.Point(19, 16);
            this.PbButtons.Name = "PbButtons";
            this.PbButtons.Size = new System.Drawing.Size(105, 109);
            this.PbButtons.TabIndex = 13;
            this.PbButtons.TabStop = false;
            this.PbButtons.MouseHover += new System.EventHandler(this.PbButtons_MouseHover);
            // 
            // PBoxShut
            // 
            this.PBoxShut.BackgroundImage = global::PetCareWork.Properties.Resources.ShutDown1;
            this.PBoxShut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxShut.Location = new System.Drawing.Point(1295, 12);
            this.PBoxShut.Name = "PBoxShut";
            this.PBoxShut.Size = new System.Drawing.Size(46, 47);
            this.PBoxShut.TabIndex = 12;
            this.PBoxShut.TabStop = false;
            this.PBoxShut.Click += new System.EventHandler(this.PBoxShut_Click);
            this.PBoxShut.MouseLeave += new System.EventHandler(this.PBoxShut_MouseLeave);
            this.PBoxShut.MouseHover += new System.EventHandler(this.PBoxShut_MouseHover);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.ControlBox = false;
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnDates);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnCli);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.PbButtons);
            this.Controls.Add(this.PBoxShut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing_1);
            this.DoubleClick += new System.EventHandler(this.FrmPrincipal_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.btnConf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxShut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBoxShut;
        private System.Windows.Forms.PictureBox PbButtons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox btnCli;
        private System.Windows.Forms.PictureBox btnProd;
        private System.Windows.Forms.PictureBox btnDates;
        private System.Windows.Forms.PictureBox btnCaixa;
        private System.Windows.Forms.PictureBox btnConf;
        private System.Windows.Forms.Button btnFuncionario;

    }
}