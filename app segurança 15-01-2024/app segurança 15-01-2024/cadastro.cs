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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app_segurança_15_01_2024
{
    public partial class cadastro : UserControl
    {
        public cadastro()
        {
            InitializeComponent();
        }
        //criando conexao
        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        //Criando comando para desabilitar os campos nescesarios
        private void desabilitarCampus()
        {
            txtNome.Enabled = false;
            txtDocumento.Enabled = false;
            txtPlaca.Enabled = false;
            txtTransportadora.Enabled = false;
            txtVisitando.Enabled = false;
            txtEntrada.Enabled = false;
            txtSaida.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnNovo.Enabled = true;
            txtDia.Enabled = false;
        }
        // criando comando para habilitar os campos
        private void habilitaCampus()
        {
            txtNome.Enabled = true;
            txtDocumento.Enabled = true;
            txtPlaca.Enabled = true;
            txtTransportadora.Enabled = true;
            txtVisitando.Enabled = true;
            txtEntrada.Enabled = true;
            txtSaida.Enabled = true;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtDia.Enabled = true;
            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampus();
            txtDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtEntrada.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            desabilitarCampus();

        }
        // botao de limpar os texto dos campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            desabilitarCampus();
            txtNome.Clear();
            txtDocumento.Clear();
            txtPlaca.Clear();
            txtTransportadora.Clear();
            txtVisitando.Text = null;
            txtEntrada.Clear();
            txtSaida.Clear();
            txtDia.Clear();
        }
        // comando para simplificar o feito acima
        private void limparCampus()
        {
            txtNome.Clear();
            txtDocumento.Clear();
            txtPlaca.Clear();
            txtTransportadora.Clear();
            txtVisitando.Text = null;
            txtEntrada.Clear();
            txtSaida.Clear();
            txtDia.Clear();
            desabilitarCampus();
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // conferindo preenchimento de campos obrigatorios
            if (txtVisitando.Text == "" || txtPlaca.Text == "" || txtEntrada.Text == "")
            {
                MessageBox.Show("Obrigatorio informar a placa, para onde vai e o horario de entrada!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    string visitando = txtVisitando.Text;
                    string entrada = txtEntrada.Text;
                    string saida = txtSaida.Text;
                    string dia = txtDia.Text;
                    
                    // criando a variavel sql e inserindo nas tabelas os nomes das variaveis que contem o valor
                    string strSql = "insert into tb_motorista(nm_motorista,dc_motorista,pl_placa,ds_transportadora,ds_destino,hr_entrada,hr_saida,dt_data)values(@nome,@documento,@placa,@transportadora,@visitando,@entrada,@saida,@dia)";
                    // ------>>>
                    string status;
                    if (saida == "")
                    {
                        status = "SELECT * FROM tb_motorista WHERE hr_saida IS NULL AND ds_status = 1";
                    }
                    else
                    {
                        status = "SELECT * FROM tb_motorista WHERE hr_saida IS NOT NULL AND ds_status = 0";
                    }
                    cm.CommandText = status;
                    // executando o command do sql
                    cm.CommandText = strSql;
                    cm.Connection = cn;
                    
                    // mostrando ao sql o tipo dos valores informado
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@documento", SqlDbType.Char).Value = documento;
                    cm.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
                    cm.Parameters.Add("@transportadora", SqlDbType.VarChar).Value = transportadora;
                    cm.Parameters.Add("@visitando", SqlDbType.VarChar).Value = visitando;
                    cm.Parameters.Add("@entrada", SqlDbType.VarChar).Value = entrada;
                    cm.Parameters.Add("@saida", SqlDbType.VarChar).Value = saida;
                    cm.Parameters.Add("@dia", SqlDbType.VarChar).Value = dia;
                    //cm.Parameters.Add("@data", SqlDbType.VarChar).Value = DateTime.Now;
                    // abrindo conexao
                    cn.Open();
                    // inserindo nas tabela os valores acima sem retorno ao usuario
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                    //mensagem para informar que deu tudo certo
                    MessageBox.Show("Os dados foram gravados com sucesso!", "Inserção de Dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // limpar campos e dar foco no nome para iniciar novamente
                    limparCampus();
                    desabilitarCampus();
                    txtNome.Focus();

                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                 
                }
                finally
                {
                    cn.Close();
                }

            }
            
        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_Leave(object sender, EventArgs e)
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

        private void txtTransportadora_Leave_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTransportadora.Text))
            {
                txtTransportadora.Text = CapitalizeFirstLetter1(txtTransportadora.Text);
            }
        }

        private string CapitalizeFirstLetter1(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Converte o primeiro caractere para maiúsculas e mantém o restante inalterado.
            return char.ToUpper(input[0]) + input.Substring(1);
        }


        private void txtPlaca_Click(object sender, EventArgs e)
        {
            txtPlaca.Select(0, 0);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
