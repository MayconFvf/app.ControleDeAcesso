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
    public partial class principal : UserControl
    {
        public principal()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void pictureBoxPrincipal_Click(object sender, EventArgs e)
        {

        }
        private void limparCampus()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
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
                    cm.Parameters.Add("@loguin", SqlDbType.VarChar).Value = login;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

