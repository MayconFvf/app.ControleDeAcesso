using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_segurança_15_01_2024
{
    public partial class atualizar : UserControl
    {
        public atualizar()
        {
            InitializeComponent();
            btnAberto.CheckedChanged += RadioButtons_CheckedChanged;
            btnFinalizado.CheckedChanged += RadioButtons_CheckedChanged;
        }
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAberto.Checked)
            {
                // Lógica para buscar os motoristas com st_status = 0
                BuscarMotoristas(0);
            }
            else if (btnFinalizado.Checked)
            {
                // Lógica para buscar os motoristas com st_status = 1
                BuscarMotoristas(1);
            }
        }

        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        public void desabilitaCampos()
        {
            btnNovo.Enabled = true;
            button3.Enabled = false;
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
            txtDocumento.Enabled = false;
            txtEntrada.Enabled = false;
            txtNome.Enabled = false;
            txtPlaca.Enabled = false;
            txtSaida.Enabled = false;
            txtTransportadora.Enabled = false;
            txtVisitado.Enabled = false;
            txtPlaca.Enabled = false;
            txtDia.Enabled = false;
            txtbPlaca.Enabled = false;
            btnAberto.Enabled = true;
            btnFinalizado.Enabled = true;
            dataGridView1.Enabled = false;


        }
        public void habilitaCampos()
        {
            btnNovo.Enabled = false;
            button3.Enabled = true;
            btnExcluir.Enabled = true;
            btnAtualizar.Enabled = true;
            txtDocumento.Enabled = true;
            txtEntrada.Enabled = true;
            txtNome.Enabled = true;
            txtPlaca.Enabled = true;
            txtSaida.Enabled = true;
            txtTransportadora.Enabled = true;
            txtVisitado.Enabled = true;
            txtPlaca.Enabled = true;
            dataGridView1.DataSource = null;
            txtDia.Enabled = true;
            txtbPlaca.Enabled = true;
            btnAberto.Enabled = false;
            btnFinalizado.Enabled = false;
            dataGridView1.Enabled = true;
            txtbPlaca.Focus();
        }
        public void limparCampos()
        {
            txtPlaca.Clear();
            txtDocumento.Clear();
            txtEntrada.Clear();
            txtNome.Clear();
            txtPlaca.Clear();
            txtSaida.Clear();
            txtTransportadora.Clear();
            txtVisitado.Clear();
            txtDia.Clear();
            lblcod.Text = "";
            dataGridView1.DataSource = null;
            txtbPlaca.Clear();
            btnFinalizado.Checked = false;
            btnAberto.Checked = false;
        }

        private void atualizar_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
            
            dataGridView1.Rows.Clear();
        }

        private void BuscarMotoristas(int status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto"))
                {
                    connection.Open();

                    string query = "SELECT * FROM tb_motorista WHERE ds_status = @status";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@status", status);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Criar um DataTable para armazenar os resultados
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // Limpar as colunas e as linhas existentes no DataGridView
                            dataGridView1.Columns.Clear();
                            dataGridView1.Rows.Clear();

                            // Adicionar as colunas ao DataGridView com base nos resultados da consulta
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                dataGridView1.Columns.Add(column.ColumnName, column.ColumnName);
                            }

                            // Verificar se há linhas no DataTable antes de preencher o DataGridView
                            if (dataTable.Rows.Count > 0)
                            {
                                // Preencher o DataGridView com os dados do DataTable
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    object[] values = row.ItemArray;
                                    dataGridView1.Rows.Add(values);
                                }
                                
                            }

                            else
                            {
                                MessageBox.Show("Nenhum motorista encontrado com o status fornecido.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar motoristas: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtbPlaca.Text != "")
            {
                dataGridView1.Columns.Clear();
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_motorista where pl_placa like ('" + txtbPlaca.Text + "%')";
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
        private void manipularDados()
        {
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
            button3.Enabled = true;
        }
        private void carregarTabela()
        {
            lblcod.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDocumento.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPlaca.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtTransportadora.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtVisitado.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEntrada.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtSaida.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtDia.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            manipularDados();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarTabela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtVisitado.Text == "" || txtPlaca.Text == "" || txtEntrada.Text == "" || txtDocumento.Text == "" || txtNome.Text == "" || txtTransportadora.Text == "" || txtSaida.Text == "")
            {
                MessageBox.Show("Obrigatorio informar todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Focus();

            }
            // ce os campos forem preenchidos vira para ca
            else
            {
                try
                {
                    // criando variaveis para dar nome aos valor digitado nas texBox
                    string nome = txtNome.Text;
                    string documento = txtDocumento.Text;
                    string placa = txtPlaca.Text;
                    string transportadora = txtTransportadora.Text;
                    string visitado = txtVisitado.Text;
                    string entrada = txtEntrada.Text;
                    string saida = txtSaida.Text;
                    int cd = Convert.ToInt32(lblcod.Text);

                    // criando a variavel sql e inserindo nas tabelas os nomes das variaveis que contem o valor
                    string strSql = "update tb_motorista set nm_motorista=@nome,dc_motorista=@documento,pl_placa=@placa,ds_transportadora=@transportadora,ds_destino=@visitado,hr_entrada=@entrada,hr_saida=@saida where cd_motorista=@cd";

                    // executando o command do sql
                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    // mostrando ao sql o tipo dos valores informado
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@documento", SqlDbType.Char).Value = documento;
                    cm.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
                    cm.Parameters.Add("@transportadora", SqlDbType.VarChar).Value = transportadora;
                    cm.Parameters.Add("@visitado", SqlDbType.VarChar).Value = visitado;
                    cm.Parameters.Add("@entrada", SqlDbType.VarChar).Value = entrada;
                    cm.Parameters.Add("@saida", SqlDbType.VarChar).Value = saida;
                    // abrindo conexao
                    cn.Open();
                    // inserindo nas tabela os valores acima sem retorno ao usuario
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    if (!string.IsNullOrEmpty(txtSaida.Text))
                    {
                        // Atualizar o valor do ds_status para 0
                        string strSqlStatus = "update tb_motorista set ds_status = 0 where cd_motorista = @cd";
                        cm.CommandText = strSqlStatus;
                        cm.Parameters.AddWithValue("@cd", cd);
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                    }
                    //mensagem para informar que deu tudo certo
                    MessageBox.Show("Os dados foram atualizados com sucesso!", "Atualização de Dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // limpar campos e dar foco no nome para iniciar novamente
                    limparCampos();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(lblcod.Text == "")
            {
                MessageBox.Show("Obrigatorio selecionar um motorista!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Focus();
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Voce tem certeza que deseja remover este registro?", "Exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lblcod.Text);
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        cn.Open();
                        //tirar duvida
                        string strSql = "delete from tb_motorista where cd_motorista=@cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados exluidos com sucesso!", "Exclusão Dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCampos();
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }


        private void btnAberto_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            txtbPlaca.Enabled = false;
            dataGridView1.Enabled = true;
            button3.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void btnFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            txtbPlaca.Enabled = false;
            dataGridView1.Enabled = true;
            txtSaida.Enabled = true;
            btnAtualizar.Enabled = true;
            txtTransportadora.Enabled = true;
            button3.Enabled = true;

        }

        private void txtSaida_Click(object sender, EventArgs e)
        {
            txtSaida.Select(0, 0);
        }

        private void txtEntrada_Click(object sender, EventArgs e)
        {
            txtEntrada.Select(0, 0);
        }

        private void txtDia_Click(object sender, EventArgs e)
        {
            txtDia.Select(0, 0);
        }
    }
}
