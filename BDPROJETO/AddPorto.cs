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
using System.Globalization;

namespace BDPROJETO
{
    public partial class AddPorto : Form
    {
        string str1,str2;

       
        
        public AddPorto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            str1 = textBox2.Text.ToUpper();
          
            FbCommand comandoSQL = new FbCommand("insert into PORTO(NomePorto) values (@NomePorto);", Database.conexao);
            comandoSQL.CommandType = CommandType.Text;

            comandoSQL.Parameters.Add("@NomePorto", str1);
            
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
