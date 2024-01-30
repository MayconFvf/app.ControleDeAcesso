using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace app_segurança_15_01_2024
{
    public partial class pesquisar : UserControl
    {
        private PrintDocument printDocument;
        public pesquisar()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        SqlConnection cn = new SqlConnection(@"Data Source=CRISTIANEVILELA;integrated security=SSPI;initial Catalog=db_Moto");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;


        private void desabiitaCampos()
        {
            txtbNome.Enabled = false;
            txtbPlaca.Enabled = false;
            txtbVisitado.Enabled = false;
            txtbDia.Enabled = false;
            btnLimpar.Enabled = false;
            btnHabiliar.Enabled = true;
            btnImprimir.Enabled = false;

        }
        private void habilitaCampos()
        {
            txtbNome.Enabled = true;
            txtbPlaca.Enabled = true;
            txtbVisitado.Enabled = true;
            txtbDia.Enabled = true;
            btnLimpar.Enabled = true;
            txtbNome.Focus();
            btnHabiliar.Enabled = false;
            btnImprimir.Enabled = true;
        }

        private void pesquisar_Load(object sender, EventArgs e)
        {
            desabiitaCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }
        private void limparCampos()
        {
            txtbNome.Clear();
            txtbPlaca.Clear();
            txtbVisitado.Clear();
            txtbDia.Clear();
            
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabiitaCampos();
        }

        private void txtbNome_TextChanged(object sender, EventArgs e)
        {
            if (txtbNome.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_motorista where nm_motorista like ('" + txtbNome.Text + "%')";
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

        private void txtbPlaca_TextChanged(object sender, EventArgs e)
        {
            if (txtbPlaca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_motorista where pl_placa like ('" + txtbPlaca.Text + "%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
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

        private void txtbVisitado_TextChanged(object sender, EventArgs e)
        {
            if (txtbVisitado.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_motorista where ds_destino like ('" + txtbVisitado.Text + "%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
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
        private void carregaMotorista()
        {
            txtbNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtbPlaca.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtbVisitado.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txtbDia_TextChanged(object sender, EventArgs e)
        {
            if (txtbDia.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tb_motorista where dt_data like ('" + txtbDia.Text + "%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cm;
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int rowHeight = dataGridView1.RowTemplate.Height;
            int numRowsPerPage = e.MarginBounds.Height / rowHeight;

            // Obtém o DataTable associado ao DataGridView
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Calcula o número total de páginas necessárias
            int totalRows = dataTable.Rows.Count;
            int totalPages = (int)Math.Ceiling((double)totalRows / numRowsPerPage);

            // Configura o índice inicial para a página atual
            int startIndex = 0;

            for (int currentPage = 1; currentPage <= totalPages; currentPage++)
            {
                // Desenha as linhas visíveis na página atual
                for (int i = startIndex; i < startIndex + numRowsPerPage && i < totalRows; i++)
                {
                    DataRow row = dataTable.Rows[i];

                    // Desenha as colunas conforme necessário, ajustando as coordenadas conforme necessário
                    e.Graphics.DrawString(row["nm_motorista"].ToString(), Font, Brushes.Black, new PointF(25, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["dc_motorista"].ToString(), Font, Brushes.Black, new PointF(125, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["pl_placa"].ToString(), Font, Brushes.Black, new PointF(225, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["ds_transportadora"].ToString(), Font, Brushes.Black, new PointF(325, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["ds_destino"].ToString(), Font, Brushes.Black, new PointF(425, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["hr_entrada"].ToString(), Font, Brushes.Black, new PointF(525, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["hr_saida"].ToString(), Font, Brushes.Black, new PointF(625, 100 + (i - startIndex) * rowHeight));
                    e.Graphics.DrawString(row["dt_data"].ToString(), Font, Brushes.Black, new PointF(725, 100 + (i - startIndex) * rowHeight));
                    
                }

                // Atualiza o índice inicial para a próxima página
                startIndex += numRowsPerPage;

                // Se houver mais páginas, sinaliza que mais páginas precisam ser impressas
                e.HasMorePages = currentPage < totalPages;
            }

        }
    }
}
