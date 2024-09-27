namespace projeto_aedb1.Model
{
    partial class FrmEditora
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
            GrdEditora = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            LblId = new Label();
            TxtNome = new TextBox();
            TxtId = new TextBox();
            LblNome = new Label();
            BtnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdEditora).BeginInit();
            SuspendLayout();
            // 
            // GrdEditora
            // 
            GrdEditora.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GrdEditora.BackgroundColor = Color.PapayaWhip;
            GrdEditora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdEditora.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            GrdEditora.Location = new Point(-3, 107);
            GrdEditora.Name = "GrdEditora";
            GrdEditora.Size = new Size(648, 347);
            GrdEditora.TabIndex = 6;
            GrdEditora.CellContentClick += GrdEditora_CellContentClick;
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
            // 
            // BtnExcluir
            // 
            BtnExcluir.DataPropertyName = "Excluir";
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.Name = "BtnExcluir";
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(154, 57);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(125, 34);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "Fe&char";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.ForeColor = SystemColors.Control;
            LblId.Location = new Point(12, 10);
            LblId.Name = "LblId";
            LblId.Size = new Size(46, 15);
            LblId.TabIndex = 0;
            LblId.Text = "Código";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(76, 30);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(656, 23);
            TxtNome.TabIndex = 3;
            // 
            // TxtId
            // 
            TxtId.Enabled = false;
            TxtId.Location = new Point(15, 30);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(42, 23);
            TxtId.TabIndex = 1;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.ForeColor = SystemColors.Control;
            LblNome.Location = new Point(76, 10);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 2;
            LblNome.Text = "Nome";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(15, 59);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(120, 32);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // FrmEditora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(641, 450);
            Controls.Add(BtnSalvar);
            Controls.Add(LblNome);
            Controls.Add(TxtId);
            Controls.Add(TxtNome);
            Controls.Add(LblId);
            Controls.Add(BtnFechar);
            Controls.Add(GrdEditora);
            Name = "FrmEditora";
            Text = "Cadastro de Editora";
            Activated += FrmEditora_Activated;
            FormClosed += FrmEditora_FormClosed;
            Load += FrmEditora_Load;
            ((System.ComponentModel.ISupportInitialize)GrdEditora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GrdEditora;
        private Button BtnFechar;
        private Label LblId;
        private TextBox TxtNome;
        private TextBox TxtId;
        private Label LblNome;
        private Button BtnSalvar;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}