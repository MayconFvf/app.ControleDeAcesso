using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_segurança_15_01_2024
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        // estabelecendo conexao com o sql server

        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenhaLogin.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenhaLogin.UseSystemPasswordChar = true;
        }
       
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "CVVILELA" && txtSenhaLogin.Text == "katrynna")
            {
                Gerenciador tela = new Gerenciador();
                tela.Show();
                this.Hide();
                
            }
            // veririficar se tem algo escrito
            else if(txtUsuarioLogin.Text == "" || txtSenhaLogin.Text == "")
            {
                MessageBox.Show("Obrigatorio preencher os campos login e senha", "Atenção !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // abrindo conxao com o sql server
                    cn.Open();
                    // comando para conferir dados dos campos com o da tabelda sql tb_funcionario
                    cm.CommandText = "select * from tb_funcionario where ds_Login =('"+txtUsuarioLogin.Text+"') and ds_Senha =('"+txtSenhaLogin.Text+"')";
                    // chamando conexao
                    cm.Connection = cn;
                    // exucução do comando CommandText
                    dt = cm.ExecuteReader();
                    
                    if(dt.HasRows)
                    {
                        // estanciando o formsMenu
                        formMenu menu = new formMenu();
                        // abrindo a estancia
                        menu.Show();
                        // fechando o anterior
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou senha invalidos", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Limpar o texto dos campos
                        txtUsuarioLogin.Clear();
                        txtSenhaLogin.Clear();
                        txtUsuarioLogin.Focus();
                    }
                }
                catch (Exception erro)
                {
                    // mensagem de erro para identificar alguma falha ou erro no sistema
                    MessageBox.Show(erro.Message);
                    // fechando conexao
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
