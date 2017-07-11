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
  
    public partial class ModAgente : Form
    {

        int i;
        string str;

        public ModAgente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(textBox1.Text);
            str = textBox2.Text.ToUpper();
            FbCommand comandoSQL = new FbCommand("update AGENTE set NomeAgente = @NomeAgente where CodAgente = @CodAgente;", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;
            comandoSQL.Parameters.Add("@NomeAgente", str);
            comandoSQL.Parameters.Add("@CodAgente", i);

            if (checkBox2.Checked == true)
            {
                if (comandoSQL.ExecuteNonQuery() > 0) // retorna o numero de linhas afetadas
                {
                    MessageBox.Show("Linha alterada com sucesso!");
                }

                else
                {
                    MessageBox.Show("Falha em alterar linha!");
                }
            }

            this.Hide();

        }
    }
}
