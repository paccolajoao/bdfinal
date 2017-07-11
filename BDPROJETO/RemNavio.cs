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
    public partial class RemNavio : Form
    {
        string str;

        public RemNavio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox1.Text.ToUpper();

            FbCommand comandoSQL = new FbCommand("delete from NAVIO where NomeNavio = '" + str + "';", Database.conexao);
            FbCommand comandoSQL2 = new FbCommand("delete from EMBARQUE where NomeNavio = '" + str + "';", Database.conexao);
            FbCommand comandoSQL3 = new FbCommand("delete from TRECHO where NomeNavio = '" + str + "';", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;
            comandoSQL2.CommandType = CommandType.Text;
            comandoSQL3.CommandType = CommandType.Text;
            comandoSQL2.ExecuteNonQuery();
            comandoSQL3.ExecuteNonQuery();

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
