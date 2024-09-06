using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Menus
{
    public partial class frm35347_Index : Form
    {
        #region Inicializar
        public frm35347_Index()
        {
            InitializeComponent();
        }
        #endregion

        #region Acad
        private void tsmAcad_Click(object sender, EventArgs e)
        {
            prj35347_Acad.frm35347_Acad Acad; 
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_Acad.frm35347_Acad))
                {
                    filho.Focus();
                    return;
                }
            }

            Adicionar("Academia");
            Acad = new prj35347_Acad.frm35347_Acad();
            Acad.MdiParent = this;
            Acad.Show();

        }
        #endregion

        #region Imposto
        private void tsmImposto_Click(object sender, EventArgs e)
        {
            prj35347_ImpostoRenda.frm35347_ImpostoRenda Imposto;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_ImpostoRenda.frm35347_ImpostoRenda))
                {
                    filho.Focus();
                    return;
                }
            }
            Adicionar("Imposto de Renda");
            Imposto = new prj35347_ImpostoRenda.frm35347_ImpostoRenda();
            Imposto.MdiParent = this;
            Imposto.Show();
        }
        #endregion

        #region Decimal
        private void tsmDecimal_Click(object sender, EventArgs e)
        {
            prj35347_Lista02_Ex1.frm35347_Lista02_Ex1 Decimal;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_Lista02_Ex1.frm35347_Lista02_Ex1))
                {
                    filho.Focus();
                    return;
                }
            }
            Adicionar("Decimal para Binário");
            Decimal = new prj35347_Lista02_Ex1.frm35347_Lista02_Ex1();
            Decimal.MdiParent = this;
            Decimal.Show();
        }
        #endregion

        #region Palindromo
        private void tsmPalindromo_Click(object sender, EventArgs e)
        {
            prj35347_Palindromo.frm35347_Palindromo Palindromo;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_Palindromo.frm35347_Palindromo))
                {
                    filho.Focus();
                    return;
                }
            }
            Adicionar("Palíndromo");
            Palindromo = new prj35347_Palindromo.frm35347_Palindromo();
            Palindromo.MdiParent = this;
            Palindromo.Show();

        }
        #endregion

        #region Tri
        private void tsmTri_Click(object sender, EventArgs e)
        {
            prj35347_Triangulos.frm35347_Triangulo Tri;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_Triangulos.frm35347_Triangulo))
                {
                    filho.Focus();
                    return;
                }
            }
            Adicionar("Triângulos");
            Tri= new prj35347_Triangulos.frm35347_Triangulo();
            Tri.MdiParent = this;
            Tri.Show();
        }
        #endregion

        #region Binario
        private void tsmBinario_Click(object sender, EventArgs e)
        {
            prj35347_Lista02_Ex02.frm35347_Lista02_Ex02 Binario;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.GetType() == typeof(prj35347_Lista02_Ex02.frm35347_Lista02_Ex02))
                {
                    filho.Focus();
                    return;
                }
            }
            Adicionar("Binário para Decimal");
            Binario = new prj35347_Lista02_Ex02.frm35347_Lista02_Ex02();
            Binario.MdiParent = this;
            Binario.Show();
        }
        #endregion

        #region FormClosing
        private void frm35347_Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Menus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region tsmSair
        private void tsmSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Função para adicionar na dropdown
        private void Adicionar(string nome)
        {
            tsmJanelas.DropDownItems.Add(nome);
        }
        #endregion

        #region FecharTudo
        private void tsmFecharTodas_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                filho.Close();
            }
        }
        #endregion

        #region Organizar

        #region Horizontal
        private void tsmHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion

        #region Vertical
        private void tsmVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        #region Cascata
        private void tsmCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        #endregion
    }
}
