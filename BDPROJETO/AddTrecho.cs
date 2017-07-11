using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using FirebirdSql.Data.FirebirdClient;

namespace BDPROJETO
{
    public partial class AddTrecho : Form
    {
        string str1, str2, str3;

        DateTime t1;

        public AddTrecho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text;
           
            str2 = textBox2.Text.ToUpper();

            str3 = textBox3.Text.ToUpper();

            DateTime.TryParseExact(str1, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out t1);

            dataGridView1.DataSource = null;

            FbCommand comandoSQL = new FbCommand("select NomePorto from PORTO where NomePorto = '"+str2+"'", Database.conexao);

            DataTable dt = new DataTable();

            dt.Load(comandoSQL.ExecuteReader());

            dataGridView1.DataSource = dt;

            try
            {
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                {

                    dataGridView1.DataSource = null;

                    FbCommand comandoSQL2 = new FbCommand("select NomeNavio from NAVIO where NomeNavio = '" + str3 + "'", Database.conexao);

                    DataTable dt2 = new DataTable();

                    dt2.Load(comandoSQL2.ExecuteReader());

                    dataGridView1.DataSource = dt2;

                    try
                    {

                        if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                        {
                            FbCommand comandoSQL3 = new FbCommand("insert into TRECHO(DataChegada, NomePorto, NomeNavio) values (@DataChegada, @NomePorto, @NomeNavio);", Database.conexao);
                            comandoSQL3.CommandType = CommandType.Text;

                            comandoSQL3.Parameters.AddWithValue("@DataChegada", t1);
                            comandoSQL3.Parameters.Add("@NomePorto", str2);
                            comandoSQL3.Parameters.Add("@NomeNavio", str3);

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
