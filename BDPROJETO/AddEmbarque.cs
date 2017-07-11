using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace BDPROJETO
{
    public partial class AddEmbarque : Form
    {
        int i;
        string str1;
        public AddEmbarque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(textBox1.Text);
            str1 = textBox2.Text.ToUpper();

            dataGridView1.DataSource = null;

            FbCommand comandoSQL = new FbCommand("select NumCarga from CARGA where NumCarga = '" + i.ToString() + "'", Database.conexao);

            DataTable dt = new DataTable();

            dt.Load(comandoSQL.ExecuteReader());

            dataGridView1.DataSource = dt;

            try
            {
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                {
                    dataGridView1.DataSource = null;

                    FbCommand comandoSQL2 = new FbCommand("select NomeNavio from NAVIO where NomeNavio = '" + str1 + "'", Database.conexao);

                    DataTable dt2 = new DataTable();

                    dt2.Load(comandoSQL2.ExecuteReader());

                    dataGridView1.DataSource = dt2;

                    try
                    {

                        if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                        {
                            FbCommand comandoSQL3 = new FbCommand("insert into EMBARQUE(NumCarga, NomeNavio) values (@NumCarga, @NomeNavio);", Database.conexao);
                            comandoSQL3.CommandType = CommandType.Text;

                            comandoSQL3.Parameters.Add("@NumCarga", i);
                            comandoSQL3.Parameters.Add("@NomeNavio", str1);
                    

                            if (comandoSQL3.ExecuteNonQuery() > 0) // retorna o numero de linhas afetadas
                            {
                                MessageBox.Show("Linha adicionada com sucesso!");
                            }

                            else
                            {
                                MessageBox.Show("Falha em adicionar linha!");
                            }

                            this.Hide();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Falha em adicionar linha!");
                    }

                }

            }
            catch
            {
                MessageBox.Show("Falha em adicionar linha!");
            }


        }
    }
}
