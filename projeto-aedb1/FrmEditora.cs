using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_aedb1.Model;

namespace projeto_aedb1.Model
{
    public partial class FrmEditora : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;
        public FrmEditora(ToolStripMenuItem Mnu1, ToolStripMenuItem Mnu2)
        {
            InitializeComponent();
            _mnu = Mnu1;
            _mnu2 = Mnu2;
        }

        public FrmEditora()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdEditora.AutoGenerateColumns = false;
            GrdEditora.DataSource = Editora.ListarTodos();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmEditora_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Editora";
        }

        private void FrmEditora_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_mnu != null)
    {
                _mnu.Enabled = true;
            }

            if (_mnu2 != null)
            {
                _mnu2.Enabled = true;
            }

            if (this.MdiParent is FrmMenu parentMenu)
            {
                parentMenu.LblDisplay.Text = "";
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidaControles()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    Editora editora = new Editora
                    {
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        editora.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }
                }
                else
                {
                    Editora editora = new Editora
                    {
                        id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Editora.Alterar(editora);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtId.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar a editora: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }
                }

            }
        }

        private void GrdEditora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdEditora.Rows[e.RowIndex].DataBoundItem != null)
            {
                Editora objSelecionado = (Editora)GrdEditora.Rows[e.RowIndex].DataBoundItem;
                if (GrdEditora.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtId.Text = objSelecionado.id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtId.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdEditora.Columns[e.ColumnIndex].Name == "BtnExcluir")
                {
                    if (MessageBox.Show("Confirme a exclusão.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }
    }
}
