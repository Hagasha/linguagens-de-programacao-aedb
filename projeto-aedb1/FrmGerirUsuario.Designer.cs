namespace projeto_aedb1
{
    partial class FrmGerirUsuario
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
            BtnSalvar = new Button();
            LblCodigo = new Label();
            TxtCodigo = new TextBox();
            LblNome = new Label();
            TxtNome = new TextBox();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.BackgroundColor = Color.Linen;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(0, 118);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(640, 332);
            GrdItens.TabIndex = 0;
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Código
            // 
            Código.DataPropertyName = "Id";
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
            // 
            // BtnExcluir
            // 
            BtnExcluir.DataPropertyName = "Excluir";
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 61);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(152, 41);
            BtnSalvar.TabIndex = 1;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(25, 4);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(46, 15);
            LblCodigo.TabIndex = 2;
            LblCodigo.Text = "Código";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(25, 22);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(51, 23);
            TxtCodigo.TabIndex = 3;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(101, 4);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 4;
            LblNome.Text = "Nome";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(101, 22);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(590, 23);
            TxtNome.TabIndex = 5;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(170, 61);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(165, 41);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // FrmGerirUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(641, 450);
            Controls.Add(BtnFechar);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(TxtCodigo);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
            Controls.Add(GrdItens);
            Name = "FrmGerirUsuario";
            Text = "Gerenciamento de Usuário";
            Activated += FrmGerirUsuario_Activated;
            FormClosed += FrmGerirUsuario_FormClosed;
            Load += FrmGerirUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdItens;
        private Button BtnSalvar;
        private Label LblCodigo;
        private TextBox TxtCodigo;
        private Label LblNome;
        private TextBox TxtNome;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}