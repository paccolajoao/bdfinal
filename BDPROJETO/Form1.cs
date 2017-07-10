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
    public partial class Form1 : Form
    {

        string str;

        public Form1()
        {
            InitializeComponent();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Database.Conectar())
            {
                tabelasToolStripMenuItem.Visible = true;
                adicionarToolStripMenuItem.Visible = true;
                buscasToolStripMenuItem.Visible = true;

                MessageBox.Show("Conexão com o banco bem sucedida!");
            }
            else
            {
                MessageBox.Show("Falha na conexão com o banco!");
            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Database.Desconectar())
            {

                MessageBox.Show("Desconexão com o banco bem sucedida!");
                tabelasToolStripMenuItem.Visible = false;
                adicionarToolStripMenuItem.Visible = false;
                buscasToolStripMenuItem.Visible = false;
            }
            else
            {
                MessageBox.Show("Falha na desconexão com o banco!");
            }
        }

        private void aGENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "AGENTE";
            MostraTabela();
        }

        private void cARGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "CARGA";
            MostraTabela();
        }

        private void nAVIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "NAVIO";
            MostraTabela();
        }

        private void pORTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "PORTO";
            MostraTabela();
        }

        private void tRECHOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            str = "TRECHO";
            MostraTabela();
        }

        private void MostraTabela ()
        {

            dataGridView1.DataSource = null;

            FbCommand comandoSQL = new FbCommand("select * from "+ str, Database.conexao);

            DataTable dt = new DataTable();

            dt.Load(comandoSQL.ExecuteReader());

            dataGridView1.DataSource = dt;

        }

        private void aGENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAgente add = new AddAgente();
            add.Show();

        }

        private void cARGAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCarga add = new AddCarga();
            add.Show();
        }

        private void nAVIOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddNavio add = new AddNavio();
            add.Show();
        }

        private void pORTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPorto add = new AddPorto();
            add.Show();
        }

        private void tRECHOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTrecho add = new AddTrecho();
            add.Show();
        }
    }
}
