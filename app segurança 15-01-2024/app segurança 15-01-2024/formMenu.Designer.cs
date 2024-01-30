namespace app_segurança_15_01_2024
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atualizar1 = new app_segurança_15_01_2024.atualizar();
            this.cadastro1 = new app_segurança_15_01_2024.cadastro();
            this.pesquisar1 = new app_segurança_15_01_2024.pesquisar();
            this.principal1 = new app_segurança_15_01_2024.principal();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Controls.Add(this.pictureBox3);
            this.pnMenu.Controls.Add(this.pictureBox2);
            this.pnMenu.Controls.Add(this.btnSair);
            this.pnMenu.Controls.Add(this.btnAtualizar);
            this.pnMenu.Controls.Add(this.btnCadastro);
            this.pnMenu.Controls.Add(this.btnPesquisa);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(230, 450);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::app_segurança_15_01_2024.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(230, 33);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::app_segurança_15_01_2024.Properties.Resources.atualizar__1_;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 166);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(230, 33);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = global::app_segurança_15_01_2024.Properties.Resources.cadastro__1_;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(0, 133);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(230, 33);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = global::app_segurança_15_01_2024.Properties.Resources.lupa__1_;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(0, 100);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(230, 33);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.White;
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(230, 100);
            this.pnLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // atualizar1
            // 
            this.atualizar1.AutoSize = true;
            this.atualizar1.Location = new System.Drawing.Point(236, 0);
            this.atualizar1.Name = "atualizar1";
            this.atualizar1.Size = new System.Drawing.Size(565, 450);
            this.atualizar1.TabIndex = 4;
            this.atualizar1.Load += new System.EventHandler(this.atualizar1_Load);
            // 
            // cadastro1
            // 
            this.cadastro1.Location = new System.Drawing.Point(236, 0);
            this.cadastro1.Name = "cadastro1";
            this.cadastro1.Size = new System.Drawing.Size(565, 450);
            this.cadastro1.TabIndex = 3;
            // 
            // pesquisar1
            // 
            this.pesquisar1.Location = new System.Drawing.Point(236, 0);
            this.pesquisar1.Name = "pesquisar1";
            this.pesquisar1.Size = new System.Drawing.Size(565, 450);
            this.pesquisar1.TabIndex = 2;
            // 
            // principal1
            // 
            this.principal1.Location = new System.Drawing.Point(236, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(565, 450);
            this.principal1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "(19) 99624-5008";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::app_segurança_15_01_2024.Properties.Resources.whatsapp;
            this.pictureBox3.Location = new System.Drawing.Point(23, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atualizar1);
            this.Controls.Add(this.cadastro1);
            this.Controls.Add(this.pesquisar1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.pnMenu);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMenu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.SizeChanged += new System.EventHandler(this.formMenu_SizeChanged);
            this.Resize += new System.EventHandler(this.formMenu_Resize);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private principal principal1;
        private pesquisar pesquisar1;
        private cadastro cadastro1;
        private atualizar atualizar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}