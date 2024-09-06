using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_IMC
{
    public partial class frm35347_E2G : Form
    {
        #region Inicializar
        public frm35347_E2G()
        {
            InitializeComponent();
        }
        #endregion

        #region btnSair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region FormClosing
        private void frm35347_E2G_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "IMC", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorB.Text = "";
            txtValorC.Text = "";
            txtValorA.Text = "";
            lblResposta.Text = "";
            txtDelta.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Inicializando o Obejeto
            prj35347_E2GTotal.clsE2G E2G = new prj35347_E2GTotal.clsE2G();
            #endregion

            #region TryValorA
            try
            {
                E2G.ValorA = double.Parse(txtValorA.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com ou sem decimal no Valor A");
                return;
            }
            #endregion

            #region TryValorB
            try
            {
                E2G.ValorB = double.Parse(txtValorB.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com ou sem decimal no Valor B");
                return;
            }
            #endregion

            #region TryValorB
            try
            {
                E2G.ValorC = double.Parse(txtValorC.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números com ou sem decimal no Valor C");
                return;
            }
            #endregion

            #region Mostrar na tela
            txtDelta.Text = E2G.Delta.ToString("##.##");

            if (E2G.Delta < 0)
            {
                txtX1.Text = "";
                txtX2.Text = "";
            }
            else 
            {
                txtX1.Text = E2G.X1.ToString("##.##");
                txtX2.Text = E2G.X2.ToString("##.##");
            }

            lblResposta.Text = E2G.OBS;
            #endregion
        }
        #endregion

    }
}
