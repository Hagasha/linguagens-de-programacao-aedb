﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projeto_aedb1.Model;
using projeto_aedb1.Helper;

namespace projeto_aedb1
{
    public partial class FrmIdioma : Form
    {
        ToolStripMenuItem _mnu;
        ToolStripMenuItem _mnu2;
        private bool Incluir = true;

        public FrmIdioma(ToolStripMenuItem Mnu1, ToolStripMenuItem Mnu2)
        {
            InitializeComponent();
            _mnu = Mnu1;
            _mnu2 = Mnu2;
        }
        public FrmIdioma()
        {
            InitializeComponent();
        }
        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Idioma.ListarTodos();
        }

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_mnu != null)
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

        private void FrmIdioma_Activated(object sender, EventArgs e)
        {
            ((FrmMenu)this.MdiParent).LblDisplay.Text = "Cadastro de Idioma";
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
            TxtCodigo.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (Incluir)
                {
                    Idioma idioma = new Idioma
                    {
                        Nome = TxtNome.Text
                    };

                    try
                    {
                        idioma.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o idioma: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
                else
                {
                    Idioma idioma = new Idioma
                    {
                        id = int.Parse(TxtCodigo.Text),
                        Nome = TxtNome.Text
                    };
                    try
                    {
                        Idioma.Alterar(idioma);
                        CarregaGrid();
                        LimpaControles();
                        Incluir = true;
                        TxtCodigo.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o idioma: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtCodigo.Focus();
                    }
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Idioma objSelecionado = (Idioma)GrdItens.Rows[e.RowIndex].DataBoundItem;
                if (GrdItens.Columns[e.ColumnIndex].Name == "BtnAlterar")
                {
                    TxtCodigo.Text = objSelecionado.id.ToString();
                    TxtNome.Text = objSelecionado.Nome;
                    TxtCodigo.Enabled = false;
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
