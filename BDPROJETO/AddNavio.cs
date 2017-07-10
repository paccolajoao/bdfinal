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
    public partial class AddNavio : Form
    {

        string str1;
        int i;

        public AddNavio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            str1 = textBox1.Text.ToUpper();
           
            i = Convert.ToInt32(textBox2.Text);

            FbCommand comandoSQL = new FbCommand("insert into NAVIO(NomeNavio, CapacidadeMaxima) values (@NomeNavio, @CapacidadeMaxima);", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;

            comandoSQL.Parameters.Add("@NomeNavio", str1);
            comandoSQL.Parameters.Add("@CapacidadeMaxima", i);

            if ( comandoSQL.ExecuteNonQuery() > 0) // retorna o numero de linhas afetadas
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
}
