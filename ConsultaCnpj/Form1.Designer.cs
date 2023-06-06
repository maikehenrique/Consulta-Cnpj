namespace ConsultaCnpj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.lblDataAbertura = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtMunicípio = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtTipoLogradouro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblTipoLogradouro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCnaePDescricao = new System.Windows.Forms.TextBox();
            this.txtCnaePCodigo = new System.Windows.Forms.TextBox();
            this.lblCnae = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputCnpj
            // 
            this.inputCnpj.Location = new System.Drawing.Point(12, 12);
            this.inputCnpj.Mask = "00,000,000/0000-00";
            this.inputCnpj.Name = "inputCnpj";
            this.inputCnpj.Size = new System.Drawing.Size(255, 23);
            this.inputCnpj.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(273, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 24);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Buscar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.txtDataAbertura);
            this.groupBox1.Controls.Add(this.lblDataAbertura);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtMunicípio);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.lblMunicipio);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblLogradouro);
            this.groupBox1.Controls.Add(this.txtTipoLogradouro);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.lblTipoLogradouro);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtDdd);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.txtCnaePDescricao);
            this.groupBox1.Controls.Add(this.txtCnaePCodigo);
            this.groupBox1.Controls.Add(this.lblCnae);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.lblRazaoSocial);
            this.groupBox1.Controls.Add(this.lblNomeFantasia);
            this.groupBox1.Controls.Add(this.txtNomeFantasia);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Empresa";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(331, 389);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(47, 25);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Enabled = false;
            this.txtDataAbertura.Location = new System.Drawing.Point(6, 389);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(151, 23);
            this.txtDataAbertura.TabIndex = 31;
            // 
            // lblDataAbertura
            // 
            this.lblDataAbertura.AutoSize = true;
            this.lblDataAbertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataAbertura.Location = new System.Drawing.Point(6, 371);
            this.lblDataAbertura.Name = "lblDataAbertura";
            this.lblDataAbertura.Size = new System.Drawing.Size(96, 15);
            this.lblDataAbertura.TabIndex = 30;
            this.lblDataAbertura.Text = "Data de Abertura";
            this.lblDataAbertura.Click += new System.EventHandler(this.lblDataAbertura_Click);
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(310, 345);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(68, 23);
            this.txtUF.TabIndex = 29;
            // 
            // txtMunicípio
            // 
            this.txtMunicípio.Enabled = false;
            this.txtMunicípio.Location = new System.Drawing.Point(163, 345);
            this.txtMunicípio.Name = "txtMunicípio";
            this.txtMunicípio.Size = new System.Drawing.Size(141, 23);
            this.txtMunicípio.TabIndex = 28;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(6, 345);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(151, 23);
            this.txtBairro.TabIndex = 27;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUF.Location = new System.Drawing.Point(310, 327);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 15);
            this.lblUF.TabIndex = 26;
            this.lblUF.Text = "UF";
            this.lblUF.Click += new System.EventHandler(this.lblUF_Click);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMunicipio.Location = new System.Drawing.Point(163, 327);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(61, 15);
            this.lblMunicipio.TabIndex = 25;
            this.lblMunicipio.Text = "Município";
            this.lblMunicipio.Click += new System.EventHandler(this.lblMunicipio_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(6, 327);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(38, 15);
            this.lblBairro.TabIndex = 24;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(310, 301);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 23);
            this.txtNumero.TabIndex = 23;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(6, 301);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(298, 23);
            this.txtLogradouro.TabIndex = 22;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.Location = new System.Drawing.Point(310, 283);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogradouro.Location = new System.Drawing.Point(6, 283);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(69, 15);
            this.lblLogradouro.TabIndex = 20;
            this.lblLogradouro.Text = "Logradouro";
            this.lblLogradouro.Click += new System.EventHandler(this.lblLogradouro_Click);
            // 
            // txtTipoLogradouro
            // 
            this.txtTipoLogradouro.Enabled = false;
            this.txtTipoLogradouro.Location = new System.Drawing.Point(174, 257);
            this.txtTipoLogradouro.Name = "txtTipoLogradouro";
            this.txtTipoLogradouro.Size = new System.Drawing.Size(205, 23);
            this.txtTipoLogradouro.TabIndex = 19;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(6, 257);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(162, 23);
            this.txtCep.TabIndex = 18;
            // 
            // lblTipoLogradouro
            // 
            this.lblTipoLogradouro.AutoSize = true;
            this.lblTipoLogradouro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoLogradouro.Location = new System.Drawing.Point(174, 239);
            this.lblTipoLogradouro.Name = "lblTipoLogradouro";
            this.lblTipoLogradouro.Size = new System.Drawing.Size(95, 15);
            this.lblTipoLogradouro.TabIndex = 17;
            this.lblTipoLogradouro.Text = "Tipo Logradouro";
            this.lblTipoLogradouro.Click += new System.EventHandler(this.lblTipoLogradouro_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.Location = new System.Drawing.Point(6, 239);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 15);
            this.lblCep.TabIndex = 16;
            this.lblCep.Text = "Cep";
            this.lblCep.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(174, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(174, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(44, 213);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(124, 23);
            this.txtTelefone.TabIndex = 13;
            // 
            // txtDdd
            // 
            this.txtDdd.Enabled = false;
            this.txtDdd.Location = new System.Drawing.Point(6, 213);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(32, 23);
            this.txtDdd.TabIndex = 12;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(6, 195);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // txtCnaePDescricao
            // 
            this.txtCnaePDescricao.Enabled = false;
            this.txtCnaePDescricao.Location = new System.Drawing.Point(84, 169);
            this.txtCnaePDescricao.Name = "txtCnaePDescricao";
            this.txtCnaePDescricao.Size = new System.Drawing.Size(295, 23);
            this.txtCnaePDescricao.TabIndex = 10;
            // 
            // txtCnaePCodigo
            // 
            this.txtCnaePCodigo.Enabled = false;
            this.txtCnaePCodigo.Location = new System.Drawing.Point(6, 169);
            this.txtCnaePCodigo.Name = "txtCnaePCodigo";
            this.txtCnaePCodigo.Size = new System.Drawing.Size(72, 23);
            this.txtCnaePCodigo.TabIndex = 9;
            // 
            // lblCnae
            // 
            this.lblCnae.AutoSize = true;
            this.lblCnae.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnae.Location = new System.Drawing.Point(6, 151);
            this.lblCnae.Name = "lblCnae";
            this.lblCnae.Size = new System.Drawing.Size(83, 15);
            this.lblCnae.TabIndex = 8;
            this.lblCnae.Text = "Cnae principal";
            this.lblCnae.Click += new System.EventHandler(this.lblCnae_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(204, 125);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(175, 23);
            this.txtStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(204, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Location = new System.Drawing.Point(6, 125);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(192, 23);
            this.txtCnpj.TabIndex = 5;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnpj.Location = new System.Drawing.Point(6, 107);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(32, 15);
            this.lblCnpj.TabIndex = 4;
            this.lblCnpj.Text = "Cnpj";
            this.lblCnpj.Click += new System.EventHandler(this.lblCnpj_Click);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Enabled = false;
            this.txtRazaoSocial.Location = new System.Drawing.Point(6, 81);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(373, 23);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRazaoSocial.Location = new System.Drawing.Point(6, 63);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(72, 15);
            this.lblRazaoSocial.TabIndex = 2;
            this.lblRazaoSocial.Text = "Razão Social";
            this.lblRazaoSocial.Click += new System.EventHandler(this.lblRazaoSocial_Click);
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeFantasia.Location = new System.Drawing.Point(6, 19);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(86, 15);
            this.lblNomeFantasia.TabIndex = 1;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            this.lblNomeFantasia.Click += new System.EventHandler(this.lblNomeFantasia_Click);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Enabled = false;
            this.txtNomeFantasia.Location = new System.Drawing.Point(6, 37);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(373, 23);
            this.txtNomeFantasia.TabIndex = 0;
            this.txtNomeFantasia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNomeFantasia_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(364, 12);
            this.button1.MinimumSize = new System.Drawing.Size(29, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 24);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.inputCnpj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cnpj";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox inputCnpj;
        private Button btnPesquisar;
        private GroupBox groupBox1;
        private TextBox txtNomeFantasia;
        private Label lblNomeFantasia;
        private TextBox txtRazaoSocial;
        private Label lblRazaoSocial;
        private Label lblTelefone;
        private TextBox txtCnaePDescricao;
        private TextBox txtCnaePCodigo;
        private Label lblCnae;
        private TextBox txtStatus;
        private Label lblStatus;
        private TextBox txtCnpj;
        private Label lblCnpj;
        private TextBox txtDataAbertura;
        private Label lblDataAbertura;
        private TextBox txtUF;
        private TextBox txtMunicípio;
        private TextBox txtBairro;
        private Label lblUF;
        private Label lblMunicipio;
        private Label lblBairro;
        private TextBox txtNumero;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private Label lblLogradouro;
        private TextBox txtTipoLogradouro;
        private TextBox txtCep;
        private Label lblTipoLogradouro;
        private Label lblCep;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtDdd;
        private Button button1;
        private Button btnImprimir;
    }
}