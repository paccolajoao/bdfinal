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
    public partial class RemCarga : Form
    {
        int i;

        public RemCarga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i = Convert.ToInt32(textBox1.Text);

            FbCommand comandoSQL = new FbCommand("delete from CARGA where NumCarga = '" + i.ToString() + "';", Database.conexao);
            FbCommand comandoSQL2 = new FbCommand("delete from EMBARQUE where NumCarga = '" + i.ToString() + "';", Database.conexao);
            comandoSQL2.CommandType = CommandType.Text;
            comandoSQL.CommandType = CommandType.Text;
            

            if ( (comandoSQL2.ExecuteNonQuery() > 0) && (comandoSQL.ExecuteNonQuery() > 0)) // retorna o numero de linhas afetadas
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
