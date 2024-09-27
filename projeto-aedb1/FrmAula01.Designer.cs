namespace projeto_aedb1
{
    partial class FrmAula01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnMensagem = new Button();
            LblMensagem = new Label();
            BtnMudarCorFundoForms = new Button();
            colorDialog1 = new ColorDialog();
            TxtMensagem = new TextBox();
            Mensagem = new Label();
            MsgBox = new Button();
            SuspendLayout();
            // 
            // BtnMensagem
            // 
            BtnMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnMensagem.BackColor = SystemColors.Highlight;
            BtnMensagem.Location = new Point(1, 50);
            BtnMensagem.Name = "BtnMensagem";
            BtnMensagem.Size = new Size(639, 51);
            BtnMensagem.TabIndex = 0;
            BtnMensagem.Text = "Minha primeira mensagem";
            BtnMensagem.UseVisualStyleBackColor = false;
            BtnMensagem.Click += BtnMensagem_Click;
            // 
            // LblMensagem
            // 
            LblMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LblMensagem.BackColor = Color.White;
            LblMensagem.BorderStyle = BorderStyle.FixedSingle;
            LblMensagem.Location = new Point(1, 15);
            LblMensagem.Name = "LblMensagem";
            LblMensagem.Size = new Size(639, 23);
            LblMensagem.TabIndex = 1;
            // 
            // BtnMudarCorFundoForms
            // 
            BtnMudarCorFundoForms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnMudarCorFundoForms.BackColor = Color.Plum;
            BtnMudarCorFundoForms.Location = new Point(1, 107);
            BtnMudarCorFundoForms.Name = "BtnMudarCorFundoForms";
            BtnMudarCorFundoForms.Size = new Size(639, 51);
            BtnMudarCorFundoForms.TabIndex = 2;
            BtnMudarCorFundoForms.Text = "Cor de fundo do formulário";
            BtnMudarCorFundoForms.UseVisualStyleBackColor = false;
            BtnMudarCorFundoForms.Click += BtnMudarCorFundoForms_Click;
            // 
            // TxtMensagem
            // 
            TxtMensagem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtMensagem.Location = new Point(1, 207);
            TxtMensagem.Multiline = true;
            TxtMensagem.Name = "TxtMensagem";
            TxtMensagem.Size = new Size(639, 23);
            TxtMensagem.TabIndex = 3;
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.Location = new Point(1, 189);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(66, 15);
            Mensagem.TabIndex = 4;
            Mensagem.Text = "Mensagem";
            // 
            // MsgBox
            // 
            MsgBox.Location = new Point(13, 247);
            MsgBox.Name = "MsgBox";
            MsgBox.Size = new Size(154, 64);
            MsgBox.TabIndex = 5;
            MsgBox.Text = "Exibir Mensagem";
            MsgBox.UseVisualStyleBackColor = true;
            MsgBox.Click += MsgBox_Click;
            // 
            // FrmAula01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(641, 450);
            Controls.Add(MsgBox);
            Controls.Add(Mensagem);
            Controls.Add(TxtMensagem);
            Controls.Add(BtnMudarCorFundoForms);
            Controls.Add(LblMensagem);
            Controls.Add(BtnMensagem);
            Name = "FrmAula01";
            Text = "Meu primeiro formulário";
            Activated += FrmAula01_Activated;
            FormClosed += FrmAula01_FormClosed;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMensagem;
        private Label LblMensagem;
        private Button BtnMudarCorFundoForms;
        private ColorDialog colorDialog1;
        private TextBox TxtMensagem;
        private Label Mensagem;
        private Button MsgBox;
    }
}
