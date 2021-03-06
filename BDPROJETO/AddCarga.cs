﻿using System;
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
    public partial class AddCarga : Form
    {
        int i, j;
        double a, b;
        string str1, str2, str3;
        DateTime t1,t2;



        public AddCarga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(textBox1.Text);
            a = Convert.ToDouble(textBox2.Text); // USE SEMPRE VIRGULA, NÃO PONTO   
            j = Convert.ToInt32(textBox3.Text);
            str1 = textBox4.Text.ToUpper();
            b = Convert.ToDouble(textBox5.Text);
            str2 = textBox6.Text;
            str3 = textBox7.Text;

            DateTime.TryParseExact(str2, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out t1);
            DateTime.TryParseExact(str3, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out t2);

            dataGridView1.DataSource = null;

            FbCommand comandoSQL = new FbCommand("select CodAgente from AGENTE where CodAgente = '" + j.ToString() + "'", Database.conexao);

            DataTable dt = new DataTable();

            dt.Load(comandoSQL.ExecuteReader());

            dataGridView1.DataSource = dt;

            try
            {
                if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                {
                    dataGridView1.DataSource = null;

                    FbCommand comandoSQL2 = new FbCommand("select NomePorto from PORTO where NomePorto = '" + str1 + "'", Database.conexao);

                    DataTable dt2 = new DataTable();

                    dt2.Load(comandoSQL2.ExecuteReader());

                    dataGridView1.DataSource = dt2;

                    try
                    {

                        if (dataGridView1.Rows[0].Cells[0].Value.ToString() != null)
                        {
                            FbCommand comandoSQL3 = new FbCommand("insert into CARGA(NumCarga, Peso, CodAgente, NomePorto, TemperaturaMax, Validade, DataDesembarque) values (@NumCarga, @Peso, @CodAgente, @NomePorto, @TemperaturaMax, @Validade, @DataDesembarque);", Database.conexao);
                            comandoSQL3.CommandType = CommandType.Text;

                            comandoSQL3.Parameters.Add("@NumCarga", i);
                            comandoSQL3.Parameters.Add("@Peso", a);
                            comandoSQL3.Parameters.Add("@CodAgente", j);
                            comandoSQL3.Parameters.Add("@NomePorto", str1);
                            comandoSQL3.Parameters.Add("@TemperaturaMax", b);
                            comandoSQL3.Parameters.Add("@Validade", t1);
                            comandoSQL3.Parameters.Add("@DataDesembarque", t2);


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
