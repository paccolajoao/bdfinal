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
    public partial class BuscasForm : Form
    {

        string str;

        public BuscasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.ToUpper();

            FbCommand comandoSQL = new FbCommand(str, Database.conexao);

            comandoSQL.CommandType = CommandType.Text;

            try
            {

            comandoSQL.ExecuteNonQuery();
            MessageBox.Show("Comando executado com sucesso!");

            }
            catch
             {
                MessageBox.Show("Falha em executar comando!");
            }

            
            try
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();

                dt.Load(comandoSQL.ExecuteReader());

                dataGridView1.DataSource = dt;
            }
            catch
            {

            }


        }
    }
}
