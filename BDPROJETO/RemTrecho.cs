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
    public partial class RemTrecho : Form
    {
        DateTime t1;
        string str, str2, str3;

        public RemTrecho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = textBox2.Text.ToUpper();
            str2 = textBox3.Text.ToUpper();
            str3 = textBox1.Text;

            DateTime.TryParseExact(str3, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out t1);


            FbCommand comandoSQL = new FbCommand("delete from TRECHO where DataChegada = @DataChegada and NomePorto = '"+str+"' and NomeNavio = '"+str2+"';", Database.conexao);

            comandoSQL.CommandType = CommandType.Text;
 

            comandoSQL.Parameters.AddWithValue("@DataChegada", str3);
            


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
