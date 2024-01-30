using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_segurança_15_01_2024
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            this.SizeChanged += formMenu_SizeChanged;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            login tela = new login();
            tela.Show();
            this.Hide();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pesquisar1.BringToFront();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            cadastro1.BringToFront();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizar1.BringToFront();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            cadastro1.BringToFront();
        }

        private void atualizar1_Load(object sender, EventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formMenu_Resize(object sender, EventArgs e)
        {

        }

        private void formMenu_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
