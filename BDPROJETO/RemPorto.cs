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
    public partial class RemPorto : Form
    {
        string str;

        public RemPorto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.ToUpper();

            FbCommand comandoSQL = new FbCommand("delete from PORTO where NomePorto = '" + str + "';", Database.conexao);
            FbCommand comandoSQL2 = new FbCommand("delete from TRECHO where NomePorto = '" + str + "';", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;
            comandoSQL2.CommandType = CommandType.Text;
            comandoSQL2.ExecuteNonQuery();

            if (comandoSQL.ExecuteNonQuery() > 0) // retorna o numero de linhas afetadas
            {
                MessageBox.Show("Linha removida com sucesso!");
            }

            else
            {
                MessageBox.Show("Falha em remover linha!");
            }

            this.Hide();


        }
    }
}
