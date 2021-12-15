namespace PetCareWork.Forms
{
    partial class FrmCliente
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
            this.btnCadCli = new System.Windows.Forms.Button();
            this.DtNasc = new System.Windows.Forms.DateTimePicker();
            this.btnPesqCli = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.GBOXCadCli = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimparCad = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.GBOXDtNasc = new System.Windows.Forms.GroupBox();
            this.GBOXCep = new System.Windows.Forms.GroupBox();
            this.GBOXEstado = new System.Windows.Forms.GroupBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.GBOXCidade = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.GBOXBairro = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.GBOXEndereco = new System.Windows.Forms.GroupBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.GBOXCTPS = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.GBOXCPF = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.GBOXTelefone = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.GBOXNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.GBOXPesCli = new System.Windows.Forms.GroupBox();
            this.dgvPesCli = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.CBOption = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.CHKDinamico = new System.Windows.Forms.CheckBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.chkNome = new System.Windows.Forms.CheckBox();
            this.chkTel = new System.Windows.Forms.CheckBox();
            this.chkCPF = new System.Windows.Forms.CheckBox();
            this.GBoxListar = new System.Windows.Forms.GroupBox();
            this.chkSexo = new System.Windows.Forms.CheckBox();
            this.chkTudo = new System.Windows.Forms.CheckBox();
            this.chkDtNasc = new System.Windows.Forms.CheckBox();
            this.chkCep = new System.Windows.Forms.CheckBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.chkCidade = new System.Windows.Forms.CheckBox();
            this.chkBairro = new System.Windows.Forms.CheckBox();
            this.chkEndereco = new System.Windows.Forms.CheckBox();
            this.GBOXCadCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBOXDtNasc.SuspendLayout();
            this.GBOXCep.SuspendLayout();
            this.GBOXEstado.SuspendLayout();
            this.GBOXCidade.SuspendLayout();
            this.GBOXBairro.SuspendLayout();
            this.GBOXEndereco.SuspendLayout();
            this.GBOXCTPS.SuspendLayout();
            this.GBOXCPF.SuspendLayout();
            this.GBOXTelefone.SuspendLayout();
            this.GBOXNome.SuspendLayout();
            this.GBOXPesCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesCli)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.GBoxListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCli
            // 
            this.btnCadCli.Location = new System.Drawing.Point(21, 27);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(75, 23);
            this.btnCadCli.TabIndex = 72;
            this.btnCadCli.Text = "Cadasto";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // DtNasc
            // 
            this.DtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtNasc.Location = new System.Drawing.Point(6, 17);
            this.DtNasc.Name = "DtNasc";
            this.DtNasc.Size = new System.Drawing.Size(143, 22);
            this.DtNasc.TabIndex = 0;
            // 
            // btnPesqCli
            // 
            this.btnPesqCli.Location = new System.Drawing.Point(105, 27);
            this.btnPesqCli.Name = "btnPesqCli";
            this.btnPesqCli.Size = new System.Drawing.Size(75, 23);
            this.btnPesqCli.TabIndex = 73;
            this.btnPesqCli.Text = "Pesquisa";
            this.btnPesqCli.UseVisualStyleBackColor = true;
            this.btnPesqCli.Click += new System.EventHandler(this.btnPesqCli_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(600, 198);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 41);
            this.btnAlterar.TabIndex = 41;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(54, 382);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 71;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 16);
            this.txtCEP.MaxLength = 8;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(195, 22);
            this.txtCEP.TabIndex = 0;
            // 
            // GBOXCadCli
            // 
            this.GBOXCadCli.Controls.Add(this.pictureBox1);
            this.GBOXCadCli.Controls.Add(this.button1);
            this.GBOXCadCli.Controls.Add(this.btnAlterar);
            this.GBOXCadCli.Controls.Add(this.btnLimparCad);
            this.GBOXCadCli.Controls.Add(this.btnCadastrar);
            this.GBOXCadCli.Controls.Add(this.GBOXDtNasc);
            this.GBOXCadCli.Controls.Add(this.GBOXCep);
            this.GBOXCadCli.Controls.Add(this.GBOXEstado);
            this.GBOXCadCli.Controls.Add(this.GBOXCidade);
            this.GBOXCadCli.Controls.Add(this.GBOXBairro);
            this.GBOXCadCli.Controls.Add(this.GBOXEndereco);
            this.GBOXCadCli.Controls.Add(this.GBOXCTPS);
            this.GBOXCadCli.Controls.Add(this.GBOXCPF);
            this.GBOXCadCli.Controls.Add(this.GBOXTelefone);
            this.GBOXCadCli.Controls.Add(this.GBOXNome);
            this.GBOXCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXCadCli.Location = new System.Drawing.Point(203, 10);
            this.GBOXCadCli.Name = "GBOXCadCli";
            this.GBOXCadCli.Size = new System.Drawing.Size(718, 437);
            this.GBOXCadCli.TabIndex = 75;
            this.GBOXCadCli.TabStop = false;
            this.GBOXCadCli.Text = "Cadastrar Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Location = new System.Drawing.Point(92, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 127);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimparCad
            // 
            this.btnLimparCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCad.Location = new System.Drawing.Point(610, 390);
            this.btnLimparCad.Name = "btnLimparCad";
            this.btnLimparCad.Size = new System.Drawing.Size(97, 41);
            this.btnLimparCad.TabIndex = 40;
            this.btnLimparCad.Text = "Limpar";
            this.btnLimparCad.UseVisualStyleBackColor = true;
            this.btnLimparCad.Click += new System.EventHandler(this.btnLimparCad_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(600, 198);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 41);
            this.btnCadastrar.TabIndex = 39;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // GBOXDtNasc
            // 
            this.GBOXDtNasc.Controls.Add(this.DtNasc);
            this.GBOXDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXDtNasc.Location = new System.Drawing.Point(233, 91);
            this.GBOXDtNasc.Name = "GBOXDtNasc";
            this.GBOXDtNasc.Size = new System.Drawing.Size(155, 45);
            this.GBOXDtNasc.TabIndex = 35;
            this.GBOXDtNasc.TabStop = false;
            this.GBOXDtNasc.Text = "Data de nascimento";
            // 
            // GBOXCep
            // 
            this.GBOXCep.Controls.Add(this.txtCEP);
            this.GBOXCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXCep.Location = new System.Drawing.Point(21, 194);
            this.GBOXCep.Name = "GBOXCep";
            this.GBOXCep.Size = new System.Drawing.Size(207, 45);
            this.GBOXCep.TabIndex = 37;
            this.GBOXCep.TabStop = false;
            this.GBOXCep.Text = "CEP";
            // 
            // GBOXEstado
            // 
            this.GBOXEstado.Controls.Add(this.CmbEstado);
            this.GBOXEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXEstado.Location = new System.Drawing.Point(233, 194);
            this.GBOXEstado.Name = "GBOXEstado";
            this.GBOXEstado.Size = new System.Drawing.Size(90, 45);
            this.GBOXEstado.TabIndex = 38;
            this.GBOXEstado.TabStop = false;
            this.GBOXEstado.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CmbEstado.Location = new System.Drawing.Point(7, 16);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(77, 24);
            this.CmbEstado.TabIndex = 0;
            // 
            // GBOXCidade
            // 
            this.GBOXCidade.Controls.Add(this.txtCidade);
            this.GBOXCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXCidade.Location = new System.Drawing.Point(394, 142);
            this.GBOXCidade.Name = "GBOXCidade";
            this.GBOXCidade.Size = new System.Drawing.Size(303, 45);
            this.GBOXCidade.TabIndex = 36;
            this.GBOXCidade.TabStop = false;
            this.GBOXCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 16);
            this.txtCidade.MaxLength = 45;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(291, 22);
            this.txtCidade.TabIndex = 0;
            // 
            // GBOXBairro
            // 
            this.GBOXBairro.Controls.Add(this.txtBairro);
            this.GBOXBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXBairro.Location = new System.Drawing.Point(394, 91);
            this.GBOXBairro.Name = "GBOXBairro";
            this.GBOXBairro.Size = new System.Drawing.Size(303, 45);
            this.GBOXBairro.TabIndex = 34;
            this.GBOXBairro.TabStop = false;
            this.GBOXBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 16);
            this.txtBairro.MaxLength = 45;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(291, 22);
            this.txtBairro.TabIndex = 0;
            // 
            // GBOXEndereco
            // 
            this.GBOXEndereco.Controls.Add(this.txtEndereco);
            this.GBOXEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXEndereco.Location = new System.Drawing.Point(394, 40);
            this.GBOXEndereco.Name = "GBOXEndereco";
            this.GBOXEndereco.Size = new System.Drawing.Size(303, 45);
            this.GBOXEndereco.TabIndex = 33;
            this.GBOXEndereco.TabStop = false;
            this.GBOXEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 16);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(292, 22);
            this.txtEndereco.TabIndex = 0;
            // 
            // GBOXCTPS
            // 
            this.GBOXCTPS.Controls.Add(this.txtSexo);
            this.GBOXCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXCTPS.Location = new System.Drawing.Point(233, 142);
            this.GBOXCTPS.Name = "GBOXCTPS";
            this.GBOXCTPS.Size = new System.Drawing.Size(155, 45);
            this.GBOXCTPS.TabIndex = 30;
            this.GBOXCTPS.TabStop = false;
            this.GBOXCTPS.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(6, 16);
            this.txtSexo.MaxLength = 1;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(143, 22);
            this.txtSexo.TabIndex = 0;
            // 
            // GBOXCPF
            // 
            this.GBOXCPF.Controls.Add(this.txtCPF);
            this.GBOXCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXCPF.Location = new System.Drawing.Point(21, 91);
            this.GBOXCPF.Name = "GBOXCPF";
            this.GBOXCPF.Size = new System.Drawing.Size(206, 45);
            this.GBOXCPF.TabIndex = 32;
            this.GBOXCPF.TabStop = false;
            this.GBOXCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(6, 16);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(194, 22);
            this.txtCPF.TabIndex = 0;
            // 
            // GBOXTelefone
            // 
            this.GBOXTelefone.Controls.Add(this.txtTelefone);
            this.GBOXTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXTelefone.Location = new System.Drawing.Point(21, 142);
            this.GBOXTelefone.Name = "GBOXTelefone";
            this.GBOXTelefone.Size = new System.Drawing.Size(206, 45);
            this.GBOXTelefone.TabIndex = 31;
            this.GBOXTelefone.TabStop = false;
            this.GBOXTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 16);
            this.txtTelefone.MaxLength = 11;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(194, 22);
            this.txtTelefone.TabIndex = 0;
            // 
            // GBOXNome
            // 
            this.GBOXNome.Controls.Add(this.txtNome);
            this.GBOXNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXNome.Location = new System.Drawing.Point(21, 40);
            this.GBOXNome.Name = "GBOXNome";
            this.GBOXNome.Size = new System.Drawing.Size(367, 45);
            this.GBOXNome.TabIndex = 27;
            this.GBOXNome.TabStop = false;
            this.GBOXNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 16);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 22);
            this.txtNome.TabIndex = 0;
            // 
            // GBOXPesCli
            // 
            this.GBOXPesCli.Controls.Add(this.dgvPesCli);
            this.GBOXPesCli.Controls.Add(this.groupBox3);
            this.GBOXPesCli.Controls.Add(this.btnAtualizar);
            this.GBOXPesCli.Controls.Add(this.CHKDinamico);
            this.GBOXPesCli.Controls.Add(this.btnPesquisa);
            this.GBOXPesCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOXPesCli.Location = new System.Drawing.Point(203, 11);
            this.GBOXPesCli.Name = "GBOXPesCli";
            this.GBOXPesCli.Size = new System.Drawing.Size(718, 436);
            this.GBOXPesCli.TabIndex = 74;
            this.GBOXPesCli.TabStop = false;
            this.GBOXPesCli.Text = "Pesquisar Cliente";
            // 
            // dgvPesCli
            // 
            this.dgvPesCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesCli.Location = new System.Drawing.Point(6, 96);
            this.dgvPesCli.Name = "dgvPesCli";
            this.dgvPesCli.Size = new System.Drawing.Size(706, 334);
            this.dgvPesCli.TabIndex = 43;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOption);
            this.groupBox3.Controls.Add(this.CBOption);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 48);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por...";
            // 
            // txtOption
            // 
            this.txtOption.Location = new System.Drawing.Point(122, 17);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(362, 22);
            this.txtOption.TabIndex = 45;
            this.txtOption.TextChanged += new System.EventHandler(this.txtOption_TextChanged);
            // 
            // CBOption
            // 
            this.CBOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOption.FormattingEnabled = true;
            this.CBOption.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "CEP",
            "ID",
            "Sexo",
            "DataNasc"});
            this.CBOption.Location = new System.Drawing.Point(6, 17);
            this.CBOption.Name = "CBOption";
            this.CBOption.Size = new System.Drawing.Size(105, 24);
            this.CBOption.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(610, 46);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 41);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // CHKDinamico
            // 
            this.CHKDinamico.AutoSize = true;
            this.CHKDinamico.Location = new System.Drawing.Point(507, 19);
            this.CHKDinamico.Name = "CHKDinamico";
            this.CHKDinamico.Size = new System.Drawing.Size(92, 20);
            this.CHKDinamico.TabIndex = 41;
            this.CHKDinamico.Text = "Dinâmico";
            this.CHKDinamico.UseVisualStyleBackColor = true;
            this.CHKDinamico.CheckedChanged += new System.EventHandler(this.CHKDinamico_CheckedChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(507, 46);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(97, 41);
            this.btnPesquisa.TabIndex = 39;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // chkNome
            // 
            this.chkNome.AutoSize = true;
            this.chkNome.Checked = true;
            this.chkNome.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNome.Location = new System.Drawing.Point(15, 31);
            this.chkNome.Name = "chkNome";
            this.chkNome.Size = new System.Drawing.Size(68, 20);
            this.chkNome.TabIndex = 64;
            this.chkNome.Text = "Nome";
            this.chkNome.UseVisualStyleBackColor = true;
            // 
            // chkTel
            // 
            this.chkTel.AutoSize = true;
            this.chkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTel.Location = new System.Drawing.Point(15, 51);
            this.chkTel.Name = "chkTel";
            this.chkTel.Size = new System.Drawing.Size(89, 20);
            this.chkTel.TabIndex = 65;
            this.chkTel.Text = "Telefone";
            this.chkTel.UseVisualStyleBackColor = true;
            // 
            // chkCPF
            // 
            this.chkCPF.AutoSize = true;
            this.chkCPF.Checked = true;
            this.chkCPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCPF.Location = new System.Drawing.Point(15, 71);
            this.chkCPF.Name = "chkCPF";
            this.chkCPF.Size = new System.Drawing.Size(56, 20);
            this.chkCPF.TabIndex = 66;
            this.chkCPF.Text = "CPF";
            this.chkCPF.UseVisualStyleBackColor = true;
            // 
            // GBoxListar
            // 
            this.GBoxListar.Controls.Add(this.chkSexo);
            this.GBoxListar.Controls.Add(this.chkTudo);
            this.GBoxListar.Controls.Add(this.chkDtNasc);
            this.GBoxListar.Controls.Add(this.chkCep);
            this.GBoxListar.Controls.Add(this.chkEstado);
            this.GBoxListar.Controls.Add(this.chkCidade);
            this.GBoxListar.Controls.Add(this.chkBairro);
            this.GBoxListar.Controls.Add(this.chkEndereco);
            this.GBoxListar.Controls.Add(this.chkCPF);
            this.GBoxListar.Controls.Add(this.chkTel);
            this.GBoxListar.Controls.Add(this.chkNome);
            this.GBoxListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxListar.Location = new System.Drawing.Point(20, 67);
            this.GBoxListar.Name = "GBoxListar";
            this.GBoxListar.Size = new System.Drawing.Size(159, 282);
            this.GBoxListar.TabIndex = 76;
            this.GBoxListar.TabStop = false;
            this.GBoxListar.Text = "Listar";
            // 
            // chkSexo
            // 
            this.chkSexo.AutoSize = true;
            this.chkSexo.Checked = true;
            this.chkSexo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSexo.Location = new System.Drawing.Point(15, 216);
            this.chkSexo.Name = "chkSexo";
            this.chkSexo.Size = new System.Drawing.Size(62, 20);
            this.chkSexo.TabIndex = 77;
            this.chkSexo.Text = "Sexo";
            this.chkSexo.UseVisualStyleBackColor = true;
            // 
            // chkTudo
            // 
            this.chkTudo.AutoSize = true;
            this.chkTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTudo.Location = new System.Drawing.Point(15, 242);
            this.chkTudo.Name = "chkTudo";
            this.chkTudo.Size = new System.Drawing.Size(63, 20);
            this.chkTudo.TabIndex = 76;
            this.chkTudo.Text = "Tudo";
            this.chkTudo.UseVisualStyleBackColor = true;
            // 
            // chkDtNasc
            // 
            this.chkDtNasc.AutoSize = true;
            this.chkDtNasc.Checked = true;
            this.chkDtNasc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDtNasc.Location = new System.Drawing.Point(15, 195);
            this.chkDtNasc.Name = "chkDtNasc";
            this.chkDtNasc.Size = new System.Drawing.Size(128, 20);
            this.chkDtNasc.TabIndex = 75;
            this.chkDtNasc.Text = "Dt Nascimento";
            this.chkDtNasc.UseVisualStyleBackColor = true;
            // 
            // chkCep
            // 
            this.chkCep.AutoSize = true;
            this.chkCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCep.Location = new System.Drawing.Point(15, 175);
            this.chkCep.Name = "chkCep";
            this.chkCep.Size = new System.Drawing.Size(55, 20);
            this.chkCep.TabIndex = 74;
            this.chkCep.Text = "Cep";
            this.chkCep.UseVisualStyleBackColor = true;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(15, 155);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(76, 20);
            this.chkEstado.TabIndex = 73;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // chkCidade
            // 
            this.chkCidade.AutoSize = true;
            this.chkCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCidade.Location = new System.Drawing.Point(15, 135);
            this.chkCidade.Name = "chkCidade";
            this.chkCidade.Size = new System.Drawing.Size(77, 20);
            this.chkCidade.TabIndex = 72;
            this.chkCidade.Text = "Cidade";
            this.chkCidade.UseVisualStyleBackColor = true;
            // 
            // chkBairro
            // 
            this.chkBairro.AutoSize = true;
            this.chkBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBairro.Location = new System.Drawing.Point(15, 114);
            this.chkBairro.Name = "chkBairro";
            this.chkBairro.Size = new System.Drawing.Size(69, 20);
            this.chkBairro.TabIndex = 71;
            this.chkBairro.Text = "Bairro";
            this.chkBairro.UseVisualStyleBackColor = true;
            // 
            // chkEndereco
            // 
            this.chkEndereco.AutoSize = true;
            this.chkEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEndereco.Location = new System.Drawing.Point(15, 94);
            this.chkEndereco.Name = "chkEndereco";
            this.chkEndereco.Size = new System.Drawing.Size(94, 20);
            this.chkEndereco.TabIndex = 70;
            this.chkEndereco.Text = "Endereço";
            this.chkEndereco.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(941, 448);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.btnPesqCli);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.GBoxListar);
            this.Controls.Add(this.GBOXCadCli);
            this.Controls.Add(this.GBOXPesCli);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.GBOXCadCli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBOXDtNasc.ResumeLayout(false);
            this.GBOXCep.ResumeLayout(false);
            this.GBOXCep.PerformLayout();
            this.GBOXEstado.ResumeLayout(false);
            this.GBOXCidade.ResumeLayout(false);
            this.GBOXCidade.PerformLayout();
            this.GBOXBairro.ResumeLayout(false);
            this.GBOXBairro.PerformLayout();
            this.GBOXEndereco.ResumeLayout(false);
            this.GBOXEndereco.PerformLayout();
            this.GBOXCTPS.ResumeLayout(false);
            this.GBOXCTPS.PerformLayout();
            this.GBOXCPF.ResumeLayout(false);
            this.GBOXCPF.PerformLayout();
            this.GBOXTelefone.ResumeLayout(false);
            this.GBOXTelefone.PerformLayout();
            this.GBOXNome.ResumeLayout(false);
            this.GBOXNome.PerformLayout();
            this.GBOXPesCli.ResumeLayout(false);
            this.GBOXPesCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesCli)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GBoxListar.ResumeLayout(false);
            this.GBoxListar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.DateTimePicker DtNasc;
        private System.Windows.Forms.Button btnPesqCli;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.GroupBox GBOXCadCli;
        private System.Windows.Forms.Button btnLimparCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox GBOXDtNasc;
        private System.Windows.Forms.GroupBox GBOXCep;
        private System.Windows.Forms.GroupBox GBOXEstado;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.GroupBox GBOXCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox GBOXBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.GroupBox GBOXEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox GBOXCTPS;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.GroupBox GBOXCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.GroupBox GBOXTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.GroupBox GBOXNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox GBOXPesCli;
        private System.Windows.Forms.DataGridView dgvPesCli;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOption;
        private System.Windows.Forms.ComboBox CBOption;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.CheckBox CHKDinamico;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.CheckBox chkNome;
        private System.Windows.Forms.CheckBox chkTel;
        private System.Windows.Forms.CheckBox chkCPF;
        private System.Windows.Forms.GroupBox GBoxListar;
        private System.Windows.Forms.CheckBox chkTudo;
        private System.Windows.Forms.CheckBox chkDtNasc;
        private System.Windows.Forms.CheckBox chkCep;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.CheckBox chkCidade;
        private System.Windows.Forms.CheckBox chkBairro;
        private System.Windows.Forms.CheckBox chkEndereco;
        private System.Windows.Forms.CheckBox chkSexo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}