namespace projeto_aedb1
{
    partial class FrmAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutor));
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtId = new TextBox();
            Lblid = new Label();
            LblNome = new Label();
            TxtNome = new TextBox();
            toolTip1 = new ToolTip(components);
            GrdItens = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewTextBoxColumn();
            BtnExcluir = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(BtnSalvar, "BtnSalvar");
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            resources.ApplyResources(BtnFechar, "BtnFechar");
            BtnFechar.Name = "BtnFechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtId
            // 
            resources.ApplyResources(TxtId, "TxtId");
            TxtId.Name = "TxtId";
            // 
            // Lblid
            // 
            resources.ApplyResources(Lblid, "Lblid");
            Lblid.Name = "Lblid";
            // 
            // LblNome
            // 
            resources.ApplyResources(LblNome, "LblNome");
            LblNome.Name = "LblNome";
            // 
            // TxtNome
            // 
            resources.ApplyResources(TxtNome, "TxtNome");
            TxtNome.Name = "TxtNome";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.BackgroundColor = Color.Ivory;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, BtnAlterar, BtnExcluir });
            resources.ApplyResources(GrdItens, "GrdItens");
            GrdItens.Name = "GrdItens";
            GrdItens.CellClick += GrdItens_CellClick;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "id";
            resources.ApplyResources(Codigo, "Codigo");
            Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            resources.ApplyResources(Nome, "Nome");
            Nome.Name = "Nome";
            // 
            // BtnAlterar
            // 
            BtnAlterar.DataPropertyName = "Alterar";
            resources.ApplyResources(BtnAlterar, "BtnAlterar");
            BtnAlterar.Name = "BtnAlterar";
            // 
            // BtnExcluir
            // 
            BtnExcluir.DataPropertyName = "Excluir";
            resources.ApplyResources(BtnExcluir, "BtnExcluir");
            BtnExcluir.Name = "BtnExcluir";
            // 
            // FrmAutor
            // 
            AcceptButton = BtnSalvar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            CancelButton = BtnFechar;
            Controls.Add(GrdItens);
            Controls.Add(TxtNome);
            Controls.Add(LblNome);
            Controls.Add(Lblid);
            Controls.Add(TxtId);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmAutor";
            Activated += FrmAutor_Activated;
            FormClosed += FrmAutor_FormClosed;
            Load += FrmAutor_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtId;
        private Label Lblid;
        private Label LblNome;
        private TextBox TxtNome;
        private ToolTip toolTip1;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn BtnAlterar;
        private DataGridViewTextBoxColumn BtnExcluir;
    }
}