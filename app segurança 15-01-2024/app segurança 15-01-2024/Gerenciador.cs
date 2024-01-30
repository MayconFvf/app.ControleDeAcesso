using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_segurança_15_01_2024
{
    public partial class Gerenciador : Form
    {
        public Gerenciador()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void desabilitarCampus()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = false;
            btnNovo.Enabled = true;
            txtbNome.Enabled = true;
        }
        // criando comando para habilitar os campos
        private void habilitaCampus()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtbNome.Enabled = false;
            txtNome.Focus();
        }

        private void limparCampus()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtbNome.Clear();
            dataGridView1.DataSource = null;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatorio informar Nome, Loguin e Senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();

            }
            // ce os campos forem preenchidos vira para ca
            else
            {
                try
                {
                    // criando variaveis para dar nome aos valor digitado nas texBox

                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;

                    // criando a variavel sql e inserindo nas tabelas os nomes das variaveis que contem o valor
                    string strSql = "insert into tb_funcionario(ds_Login,ds_Senha,nm_Funcionario)values(@login,@senha,@nome)";
                    // ------>>>
                    // executando o command do sql
                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    // mostrando ao sql o tipo dos valores informado
                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    // abrindo conexao
                    cn.Open();
                    // inserindo nas tabela os valores acima sem retorno ao usuario
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                    //mensagem para informar que deu tudo certo
                    MessageBox.Show("Os dados foram gravados com sucesso!", "Inserção de Dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // limpar campos e dar foco no nome para iniciar novamente
                    limparCampus();
                    txtNome.Focus();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);

                }
                finally
                {
                    cn.Close();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampus();
            desabilitarCampus();
        }

        private void txtbNome_TextChanged(object sender, EventArgs e)
        {
            if (txtbNome.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_funcionario where nm_funcionario like ('" + txtbNome.Text + "%')";
                    cm.Connection = cn;
                    // recebe as informação de uma tabela apos o select
                    SqlDataAdapter da = new SqlDataAdapter();
                    // o objeto datatable pode representar uma ou mais tabelas de dados as quais elas permanecer alocadas em memoria
                    DataTable dt = new DataTable();
                    // recebendo os dados das instrução select
                    da.SelectCommand = cm;
                    // preenchendo a tabela do app
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampus();
            txtNome.Focus();
        }

        private void Gerenciador_Load(object sender, EventArgs e)
        {
            desabilitarCampus();
            txtbNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            login tela = new login();
            tela.Show();
            this.Hide();

        }

        private void txtNome_Leave_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.Text = CapitalizeFirstLetter(txtNome.Text);
            }
        }

        private string CapitalizeFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Converte o primeiro caractere para maiúsculas e mantém o restante inalterado.
            return char.ToUpper(input[0]) + input.Substring(1);
        }

      
    }
}
    

