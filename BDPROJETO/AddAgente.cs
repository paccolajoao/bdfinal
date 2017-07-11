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
    public partial class AddAgente : Form
    {
        string str1;
        int i;

        public AddAgente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str1 = textBox2.Text.ToUpper();

            i = Convert.ToInt32(textBox1.Text);

            FbCommand comandoSQL = new FbCommand("insert into AGENTE(CodAgente, NomeAgente) values (@CodAgente, @NomeAgente);", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;

            comandoSQL.Parameters.Add("@CodAgente", i);
            comandoSQL.Parameters.Add("@NomeAgente", str1);

            if (comandoSQL.ExecuteNonQuery() > 0) // retorna o numero de linhas afetadas
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
