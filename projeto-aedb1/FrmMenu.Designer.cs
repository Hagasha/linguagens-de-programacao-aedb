namespace projeto_aedb1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            MnuAutor = new ToolStripMenuItem();
            MenuEditora = new ToolStripMenuItem();
            MnuGenero = new ToolStripMenuItem();
            MnuGerirUsuario = new ToolStripMenuItem();
            MnuIdioma = new ToolStripMenuItem();
            MnuLivro = new ToolStripMenuItem();
            MnuSair = new ToolStripMenuItem();
            MnuAulas = new ToolStripMenuItem();
            MnuAula01 = new ToolStripMenuItem();
            MnuSuspenso = new ContextMenuStrip(components);
            MnSAutor = new ToolStripMenuItem();
            MnSEditora = new ToolStripMenuItem();
            MnSGenero = new ToolStripMenuItem();
            MnSGerirUsuario = new ToolStripMenuItem();
            MnSIdioma = new ToolStripMenuItem();
            MnSLivro = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            MnuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SlateGray;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, MnuAulas });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuAutor, MenuEditora, MnuGenero, MnuGerirUsuario, MnuIdioma, MnuLivro, MnuSair });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(147, 22);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // MenuEditora
            // 
            MenuEditora.Name = "MenuEditora";
            MenuEditora.Size = new Size(147, 22);
            MenuEditora.Text = "&Editora";
            MenuEditora.Click += MenuEditora_Click;
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(147, 22);
            MnuGenero.Text = "&Gênero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // MnuGerirUsuario
            // 
            MnuGerirUsuario.Name = "MnuGerirUsuario";
            MnuGerirUsuario.Size = new Size(147, 22);
            MnuGerirUsuario.Text = "&Gerir &Usuários";
            MnuGerirUsuario.Click += MnuGerirUsuario_Click;
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(147, 22);
            MnuIdioma.Text = "&Idioma";
            MnuIdioma.Click += MnuIdioma_Click;
            // 
            // MnuLivro
            // 
            MnuLivro.Name = "MnuLivro";
            MnuLivro.Size = new Size(147, 22);
            MnuLivro.Text = "&Livros";
            MnuLivro.Click += MnuLivro_Click;
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(147, 22);
            MnuSair.Text = "Sai&r";
            MnuSair.Click += MnuSair_Click;
            // 
            // MnuAulas
            // 
            MnuAulas.DropDownItems.AddRange(new ToolStripItem[] { MnuAula01 });
            MnuAulas.Name = "MnuAulas";
            MnuAulas.Size = new Size(48, 20);
            MnuAulas.Text = "&Aulas";
            // 
            // MnuAula01
            // 
            MnuAula01.Name = "MnuAula01";
            MnuAula01.Size = new Size(110, 22);
            MnuAula01.Text = "Aula01";
            MnuAula01.Click += MnuAula01_Click;
            // 
            // MnuSuspenso
            // 
            MnuSuspenso.BackColor = Color.Azure;
            MnuSuspenso.Items.AddRange(new ToolStripItem[] { MnSAutor, MnSEditora, MnSGenero, MnSGerirUsuario, MnSIdioma, MnSLivro });
            MnuSuspenso.Name = "MnuSuspenso";
            MnuSuspenso.Size = new Size(148, 136);
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(147, 22);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
            // 
            // MnSEditora
            // 
            MnSEditora.Name = "MnSEditora";
            MnSEditora.Size = new Size(147, 22);
            MnSEditora.Text = "&Editora";
            MnSEditora.Click += MnSEditora_Click;
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(147, 22);
            MnSGenero.Text = "&Genero";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // MnSGerirUsuario
            // 
            MnSGerirUsuario.Name = "MnSGerirUsuario";
            MnSGerirUsuario.Size = new Size(147, 22);
            MnSGerirUsuario.Text = "&Gerir &Usuários";
            MnSGerirUsuario.Click += MnSGerirUsuario_Click;
            // 
            // MnSIdioma
            // 
            MnSIdioma.Name = "MnSIdioma";
            MnSIdioma.Size = new Size(147, 22);
            MnSIdioma.Text = "&Idioma";
            MnSIdioma.Click += MnSIdioma_Click;
            // 
            // MnSLivro
            // 
            MnSLivro.Name = "MnSLivro";
            MnSLivro.Size = new Size(147, 22);
            MnSLivro.Text = "&Livros";
            MnSLivro.Click += MnSLivro_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Azure;
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 17);
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = MnuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Sistema de Biblioteca";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MnuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem MnuSair;
        public MenuStrip menuStrip1;
        public ContextMenuStrip MnuSuspenso;
        public ToolStripMenuItem MnuGenero;
        public ToolStripMenuItem MnSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripMenuItem MnuAulas;
        private ToolStripMenuItem MnuAula01;
        private ToolStripMenuItem MnuAutor;
        private ToolStripMenuItem MnSAutor;
        private ToolStripMenuItem MenuEditora;
        private ToolStripMenuItem MnSEditora;
        private ToolStripMenuItem MnuIdioma;
        private ToolStripMenuItem MnSIdioma;
        private ToolStripMenuItem MnuGerirUsuario;
        private ToolStripMenuItem MnSGerirUsuario;
        private ToolStripMenuItem MnuLivro;
        private ToolStripMenuItem MnSLivro;
    }
}