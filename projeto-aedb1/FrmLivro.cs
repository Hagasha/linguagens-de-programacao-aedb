using System;
using System.Collections.Generic;
using System.Windows.Forms;
using projeto_aedb1.Model;
using projeto_aedb1.Helper;

namespace projeto_aedb1
{
    public partial class FrmLivro : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;
        private bool Incluir = true;

        public FrmLivro(ToolStripMenuItem mnu, ToolStripMenuItem mnu2)
        {
            InitializeComponent();
            _mnu = mnu;
            _mnu2 = mnu2;
        }

        public FrmLivro()
        {
            InitializeComponent();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Livro.ListarTodos();
        }

        private void CarregaComboBoxes()
        {
            
            CmbEditora.DataSource = Editora.ListarTodos();
            CmbEditora.DisplayMember = "Nome";
            CmbEditora.ValueMember = "Id";

            
            CmbGenero.DataSource = Genero.ListarTodos();
            CmbGenero.DisplayMember = "Nome";
            CmbGenero.ValueMember = "Id";

            
            CmbIdioma.DataSource = Idioma.ListarTodos();
            CmbIdioma.DisplayMember = "Nome";
            CmbIdioma.ValueMember = "Id";
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaComboBoxes();
        }

        private void FrmLivro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_mnu != null) _mnu.Enabled = true;
            if (_mnu2 != null) _mnu2.Enabled = true;
            if (this.MdiParent is FrmMenu parentMenu) parentMenu.LblDisplay.Text = "";
        }

        private void FrmLivro_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Livro";
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

            if (CmbEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma editora.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbEditora.Focus();
                return false;
            }

            if (CmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um gênero.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbGenero.Focus();
                return false;
            }

            if (CmbIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um idioma.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbIdioma.Focus();
                return false;
            }

            if (TxtISBN.Text.Trim() == "")
            {
                MessageBox.Show("O campo ISBN é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtISBN.Focus();
                return false;
            }

            if (TxtEdicao.Text.Trim() == "")
            {
                MessageBox.Show("O campo Edição é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEdicao.Focus();
                return false;
            }

            if (TxtQtdPaginas.Text.Trim() == "")
            {
                MessageBox.Show("O campo Quantidade de Páginas é de preenchimento obrigatório.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtQtdPaginas.Focus();
                return false;
            }

            
            if (!int.TryParse(TxtEdicao.Text, out _))
            {
                MessageBox.Show("O campo Edição deve ser um número inteiro.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtEdicao.Focus();
                return false;
            }

            if (!int.TryParse(TxtQtdPaginas.Text, out _))
            {
                MessageBox.Show("O campo Quantidade de Páginas deve ser um número inteiro.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtQtdPaginas.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtCodigo.Text = "";
            TxtNome.Text = "";
            CmbEditora.SelectedIndex = -1;
            CmbGenero.SelectedIndex = -1;
            CmbIdioma.SelectedIndex = -1;
            TxtISBN.Text = "";
            TxtDescricao.Text = "";
            TxtEdicao.Text = "";
            TxtQtdPaginas.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                Livro livro = new Livro
                {
                    Nome = TxtNome.Text,
                    IdEditora = (int)CmbEditora.SelectedValue,
                    IdGenero = (int)CmbGenero.SelectedValue,
                    IdIdioma = (int)CmbIdioma.SelectedValue,
                    ISBN = TxtISBN.Text,
                    Descricao = TxtDescricao.Text,
                    Edicao = int.Parse(TxtEdicao.Text),
                    QtdPaginas = int.Parse(TxtQtdPaginas.Text)
                };

                try
                {
                    if (Incluir)
                    {
                        livro.Incluir();
                    }
                    else
                    {
                        livro.Id = int.Parse(TxtCodigo.Text);
                        Livro.Alterar(livro);
                    }

                    CarregaGrid();
                    LimpaControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Um erro ocorreu ao salvar o livro: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCodigo.Focus();
                }
            }
        }
    }
}
