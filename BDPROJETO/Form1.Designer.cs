namespace BDPROJETO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nAVIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pORTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRECHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGENTEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nAVIOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pORTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tRECHOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 90;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(642, 337);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.tabelasToolStripMenuItem,
            this.adicionarToolStripMenuItem,
            this.buscasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGENTEToolStripMenuItem,
            this.cARGAToolStripMenuItem,
            this.nAVIOToolStripMenuItem,
            this.pORTOToolStripMenuItem,
            this.tRECHOToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            this.tabelasToolStripMenuItem.Visible = false;
            // 
            // aGENTEToolStripMenuItem
            // 
            this.aGENTEToolStripMenuItem.Name = "aGENTEToolStripMenuItem";
            this.aGENTEToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aGENTEToolStripMenuItem.Text = "AGENTE";
            this.aGENTEToolStripMenuItem.Click += new System.EventHandler(this.aGENTEToolStripMenuItem_Click);
            // 
            // cARGAToolStripMenuItem
            // 
            this.cARGAToolStripMenuItem.Name = "cARGAToolStripMenuItem";
            this.cARGAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cARGAToolStripMenuItem.Text = "CARGA";
            this.cARGAToolStripMenuItem.Click += new System.EventHandler(this.cARGAToolStripMenuItem_Click);
            // 
            // nAVIOToolStripMenuItem
            // 
            this.nAVIOToolStripMenuItem.Name = "nAVIOToolStripMenuItem";
            this.nAVIOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nAVIOToolStripMenuItem.Text = "NAVIO";
            this.nAVIOToolStripMenuItem.Click += new System.EventHandler(this.nAVIOToolStripMenuItem_Click);
            // 
            // pORTOToolStripMenuItem
            // 
            this.pORTOToolStripMenuItem.Name = "pORTOToolStripMenuItem";
            this.pORTOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pORTOToolStripMenuItem.Text = "PORTO";
            this.pORTOToolStripMenuItem.Click += new System.EventHandler(this.pORTOToolStripMenuItem_Click);
            // 
            // tRECHOToolStripMenuItem
            // 
            this.tRECHOToolStripMenuItem.Name = "tRECHOToolStripMenuItem";
            this.tRECHOToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tRECHOToolStripMenuItem.Text = "TRECHO";
            this.tRECHOToolStripMenuItem.Click += new System.EventHandler(this.tRECHOToolStripMenuItem_Click);
            // 
            // buscasToolStripMenuItem
            // 
            this.buscasToolStripMenuItem.Name = "buscasToolStripMenuItem";
            this.buscasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.buscasToolStripMenuItem.Text = "Buscas";
            this.buscasToolStripMenuItem.Visible = false;
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGENTEToolStripMenuItem1,
            this.cARGAToolStripMenuItem1,
            this.nAVIOToolStripMenuItem1,
            this.pORTOToolStripMenuItem1,
            this.tRECHOToolStripMenuItem1});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Visible = false;
            // 
            // aGENTEToolStripMenuItem1
            // 
            this.aGENTEToolStripMenuItem1.Name = "aGENTEToolStripMenuItem1";
            this.aGENTEToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aGENTEToolStripMenuItem1.Text = "AGENTE";
            this.aGENTEToolStripMenuItem1.Click += new System.EventHandler(this.aGENTEToolStripMenuItem1_Click);
            // 
            // cARGAToolStripMenuItem1
            // 
            this.cARGAToolStripMenuItem1.Name = "cARGAToolStripMenuItem1";
            this.cARGAToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cARGAToolStripMenuItem1.Text = "CARGA";
            this.cARGAToolStripMenuItem1.Click += new System.EventHandler(this.cARGAToolStripMenuItem1_Click);
            // 
            // nAVIOToolStripMenuItem1
            // 
            this.nAVIOToolStripMenuItem1.Name = "nAVIOToolStripMenuItem1";
            this.nAVIOToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nAVIOToolStripMenuItem1.Text = "NAVIO";
            this.nAVIOToolStripMenuItem1.Click += new System.EventHandler(this.nAVIOToolStripMenuItem1_Click);
            // 
            // pORTOToolStripMenuItem1
            // 
            this.pORTOToolStripMenuItem1.Name = "pORTOToolStripMenuItem1";
            this.pORTOToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pORTOToolStripMenuItem1.Text = "PORTO";
            this.pORTOToolStripMenuItem1.Click += new System.EventHandler(this.pORTOToolStripMenuItem1_Click);
            // 
            // tRECHOToolStripMenuItem1
            // 
            this.tRECHOToolStripMenuItem1.Name = "tRECHOToolStripMenuItem1";
            this.tRECHOToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.tRECHOToolStripMenuItem1.Text = "TRECHO";
            this.tRECHOToolStripMenuItem1.Click += new System.EventHandler(this.tRECHOToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 376);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Portos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nAVIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pORTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRECHOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGENTEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cARGAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nAVIOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pORTOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tRECHOToolStripMenuItem1;
    }
}

