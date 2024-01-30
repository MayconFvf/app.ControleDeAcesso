namespace app_segurança_15_01_2024
{
    partial class pesquisar
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblVisitado = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbPlaca = new System.Windows.Forms.TextBox();
            this.txtbVisitado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbDia = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.btnHabiliar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(25, 77);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(56, 23);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblVisitado
            // 
            this.lblVisitado.AutoSize = true;
            this.lblVisitado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitado.Location = new System.Drawing.Point(25, 131);
            this.lblVisitado.Name = "lblVisitado";
            this.lblVisitado.Size = new System.Drawing.Size(72, 23);
            this.lblVisitado.TabIndex = 2;
            this.lblVisitado.Text = "Acesso:";
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(120, 21);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(343, 29);
            this.txtbNome.TabIndex = 3;
            this.txtbNome.TextChanged += new System.EventHandler(this.txtbNome_TextChanged);
            // 
            // txtbPlaca
            // 
            this.txtbPlaca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPlaca.Location = new System.Drawing.Point(120, 75);
            this.txtbPlaca.Name = "txtbPlaca";
            this.txtbPlaca.Size = new System.Drawing.Size(343, 29);
            this.txtbPlaca.TabIndex = 4;
            this.txtbPlaca.TextChanged += new System.EventHandler(this.txtbPlaca_TextChanged);
            // 
            // txtbVisitado
            // 
            this.txtbVisitado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVisitado.Location = new System.Drawing.Point(120, 129);
            this.txtbVisitado.Name = "txtbVisitado";
            this.txtbVisitado.Size = new System.Drawing.Size(343, 29);
            this.txtbVisitado.TabIndex = 5;
            this.txtbVisitado.TextChanged += new System.EventHandler(this.txtbVisitado_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 297);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 124);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtbDia
            // 
            this.txtbDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDia.Location = new System.Drawing.Point(120, 183);
            this.txtbDia.Name = "txtbDia";
            this.txtbDia.Size = new System.Drawing.Size(343, 29);
            this.txtbDia.TabIndex = 9;
            this.txtbDia.TextChanged += new System.EventHandler(this.txtbDia_TextChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(25, 185);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(39, 23);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "Dia:";
            // 
            // btnHabiliar
            // 
            this.btnHabiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabiliar.Image = global::app_segurança_15_01_2024.Properties.Resources.cadastro__1_;
            this.btnHabiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabiliar.Location = new System.Drawing.Point(15, 250);
            this.btnHabiliar.Name = "btnHabiliar";
            this.btnHabiliar.Size = new System.Drawing.Size(131, 41);
            this.btnHabiliar.TabIndex = 10;
            this.btnHabiliar.Text = "Nova Busca";
            this.btnHabiliar.UseVisualStyleBackColor = true;
            this.btnHabiliar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::app_segurança_15_01_2024.Properties.Resources.vassoura;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(173, 250);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 41);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::app_segurança_15_01_2024.Properties.Resources.impressora;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(452, 237);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 54);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnHabiliar);
            this.Controls.Add(this.txtbDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbVisitado);
            this.Controls.Add(this.txtbPlaca);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblVisitado);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblNome);
            this.Name = "pesquisar";
            this.Size = new System.Drawing.Size(565, 450);
            this.Load += new System.EventHandler(this.pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblVisitado;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbPlaca;
        private System.Windows.Forms.TextBox txtbVisitado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnHabiliar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}
