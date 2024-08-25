namespace projeto_aedb1
{
    public partial class FrmAula01 : Form
    {
        public FrmAula01()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {
            if (LblMensagem.Text.Trim() == "")
            {
                LblMensagem.Text = "Oi Mundo!";
                LblMensagem.BackColor = Color.Blue;
            }
            else
            {
                LblMensagem.Text = "";
                LblMensagem.BackColor = Color.White;
            }
        }

        private void BtnMudarCorFundoForms_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }

        }

        private void MsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtMensagem.Text, "Minha Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void FrmAula01_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Primeira Aula";
        }

        private void FrmAula01_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "";
        }
    }
}
