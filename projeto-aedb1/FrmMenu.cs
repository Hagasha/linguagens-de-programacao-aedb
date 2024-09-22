﻿using projeto_aedb1.Model;
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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MnuGenero_Click(object sender, EventArgs e)
        {
            FrmGenero oFrm = new FrmGenero(MnuGenero, MnSGenero);
            oFrm.MdiParent = this;
            MnuGenero.Enabled = false;
            MnSGenero.Enabled = false;
            oFrm.Show();
        }

        private void MnSGenero_Click(object sender, EventArgs e)
        {
            MnuGenero_Click(sender, e);
        }

        private void MnuAula01_Click(object sender, EventArgs e)
        {
            FrmAula01 oFrm = new FrmAula01();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuAutor_Click(object sender, EventArgs e)
        {
            FrmAutor oFrm = new FrmAutor();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnSAutor_Click(object sender, EventArgs e)
        {
            MnuAutor_Click(sender, e);
        }

        private void MenuEditora_Click(object sender, EventArgs e)
        {
            FrmEditora oFrm = new FrmEditora();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnSEditora_Click(object sender, EventArgs e)
        {
            MenuEditora_Click(sender, e);
        }

        private void MnuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma oFrm = new FrmIdioma();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnSIdioma_Click(object sender, EventArgs e)
        {
            MnuIdioma_Click(sender, e);
        }

        private void MnuGerirUsuario_Click(object sender, EventArgs e)
        {
            FrmGerirUsuario oFrm = new FrmGerirUsuario();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnSGerirUsuario_Click(object sender, EventArgs e)
        {
            MnuGerirUsuario_Click(sender, e);
        }

        private void MnuLivro_Click(object sender, EventArgs e)
        {
            FrmLivro oFrm = new FrmLivro();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void MnuSLivro_Click(object sender, EventArgs e)
        {
            MnuLivro_Click(sender, e);
        }
    }
}
