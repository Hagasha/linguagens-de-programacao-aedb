namespace projeto_aedb1
{
    partial class FrmLivro
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GrdItens = new DataGridView();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            LblCodigo = new Label();
            TxtCodigo = new TextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            LblEditora = new Label();
            CmbEditora = new ComboBox();
            LblGenero = new Label();
            CmbGenero = new ComboBox();
            LblIdioma = new Label();
            CmbIdioma = new ComboBox();
            LblISBN = new Label();
            TxtISBN = new TextBox();
            LblDescricao = new Label();
            TxtDescricao = new TextBox();
            LblEdicao = new Label();
            TxtEdicao = new TextBox();
            LblQtdPaginas = new Label();
            TxtQtdPaginas = new TextBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.BackgroundColor = Color.LightSalmon;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Alterar, Excluir });
            GrdItens.Location = new Point(0, 207);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(801, 243);
            GrdItens.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(322, 160);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(143, 38);
            BtnSalvar.TabIndex = 1;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(508, 163);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(143, 38);
            BtnFechar.TabIndex = 2;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(17, 5);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 3;
            LblCodigo.Text = "Código";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(17, 23);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(54, 23);
            TxtCodigo.TabIndex = 4;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(99, 5);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 5;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(99, 23);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(552, 23);
            TxtNome.TabIndex = 6;
            // 
            // LblEditora
            // 
            LblEditora.AutoSize = true;
            LblEditora.Location = new Point(17, 60);
            LblEditora.Name = "LblEditora";
            LblEditora.Size = new Size(44, 15);
            LblEditora.TabIndex = 7;
            LblEditora.Text = "Editora";
            // 
            // CmbEditora
            // 
            CmbEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbEditora.FormattingEnabled = true;
            CmbEditora.Location = new Point(17, 78);
            CmbEditora.Name = "CmbEditora";
            CmbEditora.Size = new Size(200, 23);
            CmbEditora.TabIndex = 8;
            // 
            // LblGenero
            // 
            LblGenero.AutoSize = true;
            LblGenero.Location = new Point(240, 60);
            LblGenero.Name = "LblGenero";
            LblGenero.Size = new Size(45, 15);
            LblGenero.TabIndex = 9;
            LblGenero.Text = "Gênero";
            // 
            // CmbGenero
            // 
            CmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Location = new Point(240, 78);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(200, 23);
            CmbGenero.TabIndex = 10;
            // 
            // LblIdioma
            // 
            LblIdioma.AutoSize = true;
            LblIdioma.Location = new Point(460, 60);
            LblIdioma.Name = "LblIdioma";
            LblIdioma.Size = new Size(44, 15);
            LblIdioma.TabIndex = 11;
            LblIdioma.Text = "Idioma";
            // 
            // CmbIdioma
            // 
            CmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbIdioma.FormattingEnabled = true;
            CmbIdioma.Location = new Point(460, 78);
            CmbIdioma.Name = "CmbIdioma";
            CmbIdioma.Size = new Size(200, 23);
            CmbIdioma.TabIndex = 12;
            // 
            // LblISBN
            // 
            LblISBN.AutoSize = true;
            LblISBN.Location = new Point(17, 110);
            LblISBN.Name = "LblISBN";
            LblISBN.Size = new Size(32, 15);
            LblISBN.TabIndex = 13;
            LblISBN.Text = "ISBN";
            // 
            // TxtISBN
            // 
            TxtISBN.Location = new Point(17, 128);
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(143, 23);
            TxtISBN.TabIndex = 14;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(240, 110);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 15;
            LblDescricao.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(240, 128);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(552, 23);
            TxtDescricao.TabIndex = 16;
            // 
            // LblEdicao
            // 
            LblEdicao.AutoSize = true;
            LblEdicao.Location = new Point(17, 160);
            LblEdicao.Name = "LblEdicao";
            LblEdicao.Size = new Size(42, 15);
            LblEdicao.TabIndex = 17;
            LblEdicao.Text = "Edição";
            // 
            // TxtEdicao
            // 
            TxtEdicao.Location = new Point(17, 178);
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(54, 23);
            TxtEdicao.TabIndex = 18;
            // 
            // LblQtdPaginas
            // 
            LblQtdPaginas.AutoSize = true;
            LblQtdPaginas.Location = new Point(102, 160);
            LblQtdPaginas.Name = "LblQtdPaginas";
            LblQtdPaginas.Size = new Size(80, 15);
            LblQtdPaginas.TabIndex = 19;
            LblQtdPaginas.Text = "Qtde. Páginas";
            // 
            // TxtQtdPaginas
            // 
            TxtQtdPaginas.Location = new Point(102, 178);
            TxtQtdPaginas.Name = "TxtQtdPaginas";
            TxtQtdPaginas.Size = new Size(58, 23);
            TxtQtdPaginas.TabIndex = 20;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Id";
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Alterar
            // 
            Alterar.DataPropertyName = "Alterar";
            Alterar.HeaderText = "Alterar";
            Alterar.Name = "Alterar";
            // 
            // Excluir
            // 
            Excluir.DataPropertyName = "Excluir";
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            // 
            // FrmLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtQtdPaginas);
            Controls.Add(LblQtdPaginas);
            Controls.Add(TxtEdicao);
            Controls.Add(LblEdicao);
            Controls.Add(TxtDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxtISBN);
            Controls.Add(LblISBN);
            Controls.Add(CmbIdioma);
            Controls.Add(LblIdioma);
            Controls.Add(CmbGenero);
            Controls.Add(LblGenero);
            Controls.Add(CmbEditora);
            Controls.Add(LblEditora);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(TxtCodigo);
            Controls.Add(LblCodigo);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdItens);
            Name = "FrmLivro";
            Text = "FrmLivro";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnSalvar;
        private Button BtnFechar;
        private Label LblCodigo;
        private TextBox TxtCodigo;
        private Label LblNome;
        private TextBox TxtNome;
        private Label LblEditora;
        private ComboBox CmbEditora;
        private Label LblGenero;
        private ComboBox CmbGenero;
        private Label LblIdioma;
        private ComboBox CmbIdioma;
        private Label LblISBN;
        private TextBox TxtISBN;
        private Label LblDescricao;
        private TextBox TxtDescricao;
        private Label LblEdicao;
        private TextBox TxtEdicao;
        private Label LblQtdPaginas;
        private TextBox TxtQtdPaginas;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;
    }
}
