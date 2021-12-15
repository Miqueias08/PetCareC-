namespace PetCareWork.Forms
{
    partial class FrmLogin
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
            this.txtLogSenha = new System.Windows.Forms.TextBox();
            this.txtLogNome = new System.Windows.Forms.TextBox();
            this.PBoxShut = new System.Windows.Forms.PictureBox();
            this.PBoxEnter = new System.Windows.Forms.PictureBox();
            this.PBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxShut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogSenha
            // 
            this.txtLogSenha.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogSenha.Location = new System.Drawing.Point(395, 165);
            this.txtLogSenha.Name = "txtLogSenha";
            this.txtLogSenha.PasswordChar = '*';
            this.txtLogSenha.Size = new System.Drawing.Size(251, 32);
            this.txtLogSenha.TabIndex = 8;
            // 
            // txtLogNome
            // 
            this.txtLogNome.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogNome.Location = new System.Drawing.Point(395, 125);
            this.txtLogNome.Name = "txtLogNome";
            this.txtLogNome.Size = new System.Drawing.Size(251, 32);
            this.txtLogNome.TabIndex = 7;
            // 
            // PBoxShut
            // 
            this.PBoxShut.BackgroundImage = global::PetCareWork.Properties.Resources.ShutDown1;
            this.PBoxShut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxShut.Location = new System.Drawing.Point(691, 12);
            this.PBoxShut.Name = "PBoxShut";
            this.PBoxShut.Size = new System.Drawing.Size(46, 47);
            this.PBoxShut.TabIndex = 11;
            this.PBoxShut.TabStop = false;
            this.PBoxShut.Click += new System.EventHandler(this.PBoxShut_Click);
            this.PBoxShut.MouseLeave += new System.EventHandler(this.PBoxShut_MouseLeave_1);
            this.PBoxShut.MouseHover += new System.EventHandler(this.PBoxShut_MouseHover_1);
            // 
            // PBoxEnter
            // 
            this.PBoxEnter.BackgroundImage = global::PetCareWork.Properties.Resources.Pata1;
            this.PBoxEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxEnter.Location = new System.Drawing.Point(663, 125);
            this.PBoxEnter.Name = "PBoxEnter";
            this.PBoxEnter.Size = new System.Drawing.Size(74, 71);
            this.PBoxEnter.TabIndex = 10;
            this.PBoxEnter.TabStop = false;
            this.PBoxEnter.Click += new System.EventHandler(this.PBoxEnter_Click);
            this.PBoxEnter.MouseLeave += new System.EventHandler(this.PBoxEnter_MouseLeave_1);
            this.PBoxEnter.MouseHover += new System.EventHandler(this.PBoxEnter_MouseHover_1);
            // 
            // PBoxLogo
            // 
            this.PBoxLogo.BackgroundImage = global::PetCareWork.Properties.Resources.BigHeart2;
            this.PBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxLogo.Location = new System.Drawing.Point(29, 34);
            this.PBoxLogo.Name = "PBoxLogo";
            this.PBoxLogo.Size = new System.Drawing.Size(310, 282);
            this.PBoxLogo.TabIndex = 9;
            this.PBoxLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(766, 351);
            this.Controls.Add(this.PBoxShut);
            this.Controls.Add(this.PBoxEnter);
            this.Controls.Add(this.PBoxLogo);
            this.Controls.Add(this.txtLogSenha);
            this.Controls.Add(this.txtLogNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxShut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxEnter;
        private System.Windows.Forms.PictureBox PBoxLogo;
        private System.Windows.Forms.TextBox txtLogSenha;
        private System.Windows.Forms.TextBox txtLogNome;
        private System.Windows.Forms.PictureBox PBoxShut;
    }
}