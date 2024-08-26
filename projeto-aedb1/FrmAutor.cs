using projeto_aedb1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_aedb1
{
    public partial class FrmAutor : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;

        private bool Incluir = true;
        public FrmAutor(ToolStripMenuItem Mnu1, ToolStripMenuItem Mnu2)
        {
            InitializeComponent();
            _mnu = Mnu1;
            _mnu2 = Mnu2;
        }

        public FrmAutor()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Autor.ListarTodos();
        }
        private void FrmAutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_mnu != null)
            {
                _mnu.Enabled = true;
            }
            if (_mnu2 != null)
            {
                _mnu2.Enabled = true;
            }
            if (this.MdiParent is FrmMenu parent)
            {
                parent.LblDisplay.Text = "";
            }
        }

        private void FrmAutor_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Autores";
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidaCampos()
        {
            int id;
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome do Autor é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }

            else if (TxtId.Text.Trim() == "")
            {
                MessageBox.Show("Código do Autor é obrigatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return false;
            }
            else if (int.TryParse(TxtId.Text, out id) == false)
            {
                MessageBox.Show("Código do Autor deve ser um número", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtId.Focus();
                return false;
            }
            return true;
        }

        private void LimpaCampos()
        {
            TxtId.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (Incluir)
                {
                    Autor autor = new Autor
                    {
                        id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        autor.Incluir();
                        CarregaGrid();
                        LimpaCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }
                }
                else
                {
                    Autor autor = new Autor
                    {
                        id = int.Parse(TxtId.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Autor.Alterar(autor);
                        CarregaGrid();
                        LimpaCampos();
                        Incluir = true;
                        TxtId.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o autor: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtId.Focus();
                    }
                }
            }

        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Autor objSelecionado = (Autor)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtId.Text = objSelecionado.id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtId.Enabled = false;
                    TxtNome.Focus();
                    Incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "BtnExcluir")
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
