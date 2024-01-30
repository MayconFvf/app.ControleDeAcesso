namespace app_segurança_15_01_2024
{
    partial class cadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtTransportadora = new System.Windows.Forms.TextBox();
            this.lblTransportadora = new System.Windows.Forms.Label();
            this.lblVisitando = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtVisitando = new System.Windows.Forms.ComboBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(62, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(179, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(284, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(179, 62);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(194, 29);
            this.txtDocumento.TabIndex = 3;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(45, 64);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(103, 23);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(65, 111);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 23);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtTransportadora
            // 
            this.txtTransportadora.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportadora.Location = new System.Drawing.Point(179, 160);
            this.txtTransportadora.Name = "txtTransportadora";
            this.txtTransportadora.Size = new System.Drawing.Size(284, 29);
            this.txtTransportadora.TabIndex = 7;
            this.txtTransportadora.Leave += new System.EventHandler(this.txtTransportadora_Leave_1);
            // 
            // lblTransportadora
            // 
            this.lblTransportadora.AutoSize = true;
            this.lblTransportadora.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportadora.Location = new System.Drawing.Point(31, 160);
            this.lblTransportadora.Name = "lblTransportadora";
            this.lblTransportadora.Size = new System.Drawing.Size(134, 23);
            this.lblTransportadora.TabIndex = 6;
            this.lblTransportadora.Text = "Transportadora:";
            // 
            // lblVisitando
            // 
            this.lblVisitando.AutoSize = true;
            this.lblVisitando.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitando.Location = new System.Drawing.Point(50, 209);
            this.lblVisitando.Name = "lblVisitando";
            this.lblVisitando.Size = new System.Drawing.Size(72, 23);
            this.lblVisitando.TabIndex = 8;
            this.lblVisitando.Text = "Acesso:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(62, 259);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(74, 23);
            this.lblEntrada.TabIndex = 10;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(305, 259);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(57, 23);
            this.lblSaida.TabIndex = 12;
            this.lblSaida.Text = "Saida:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(212, 358);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 51);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(35, 358);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(127, 51);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(387, 358);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 51);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data:";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.Location = new System.Drawing.Point(179, 302);
            this.txtDia.Mask = "00/00/0000";
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(120, 29);
            this.txtDia.TabIndex = 19;
            this.txtDia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtDia.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(179, 255);
            this.txtEntrada.Mask = "90:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(80, 29);
            this.txtEntrada.TabIndex = 20;
            this.txtEntrada.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            this.txtEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEntrada_MaskInputRejected);
            // 
            // txtSaida
            // 
            this.txtSaida.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaida.Location = new System.Drawing.Point(383, 257);
            this.txtSaida.Mask = "90:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(80, 29);
            this.txtSaida.TabIndex = 21;
            this.txtSaida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtVisitando
            // 
            this.txtVisitando.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitando.FormattingEnabled = true;
            this.txtVisitando.Items.AddRange(new object[] {
            "Pontolog",
            "Lax",
            "Agrium"});
            this.txtVisitando.Location = new System.Drawing.Point(179, 209);
            this.txtVisitando.Name = "txtVisitando";
            this.txtVisitando.Size = new System.Drawing.Size(284, 30);
            this.txtVisitando.TabIndex = 22;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(179, 116);
            this.txtPlaca.Mask = ">LLL-AAAA";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(108, 29);
            this.txtPlaca.TabIndex = 23;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaca_MaskInputRejected);
            this.txtPlaca.Click += new System.EventHandler(this.txtPlaca_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtVisitando);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblVisitando);
            this.Controls.Add(this.txtTransportadora);
            this.Controls.Add(this.lblTransportadora);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "cadastro";
            this.Size = new System.Drawing.Size(565, 450);
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtTransportadora;
        private System.Windows.Forms.Label lblTransportadora;
        private System.Windows.Forms.Label lblVisitando;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDia;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.ComboBox txtVisitando;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
    }
}
