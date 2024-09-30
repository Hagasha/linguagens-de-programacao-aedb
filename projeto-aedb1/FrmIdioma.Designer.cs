namespace projeto_aedb1
{
    partial class FrmIdioma
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
            GrdItens = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            LblCodigo = new Label();
            TxtCodigo = new TextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            BtnSalvar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.BackgroundColor = Color.PaleTurquoise;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            GrdItens.GridColor = SystemColors.ControlDark;
            GrdItens.Location = new Point(-5, 128);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(727, 324);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Código
            // 
            Código.DataPropertyName = "id";
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // BtnAlterar
            // 
            BtnAlterar.DataPropertyName = "Alterar";
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Resizable = DataGridViewTriState.True;
            BtnAlterar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // BtnExcluir
            // 
            BtnExcluir.DataPropertyName = "Excluir";
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(12, 9);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Código";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(13, 27);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(46, 23);
            TxtCodigo.TabIndex = 2;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(82, 9);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 3;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(82, 27);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(577, 23);
            TxtNome.TabIndex = 4;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(13, 79);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(144, 39);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(163, 79);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(143, 39);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // FrmIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(722, 450);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(TxtCodigo);
            Controls.Add(LblCodigo);
            Controls.Add(GrdItens);
            Name = "FrmIdioma";
            Text = "Cadastro de Idioma";
            Activated += FrmIdioma_Activated;
            FormClosed += FrmIdioma_FormClosed;
            Load += FrmIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Label LblCodigo;
        private TextBox TxtCodigo;
        private Label LblNome;
        private TextBox TxtNome;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}