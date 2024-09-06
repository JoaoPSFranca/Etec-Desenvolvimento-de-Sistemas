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
    public partial class frm35347_IMC : Form
    {
        #region Inicializar
        public frm35347_IMC()
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
        private void frm35347_IMC_FormClosing(object sender, FormClosingEventArgs e)
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
            txtAltura.Text = "";
            txtIMC.Text = "";
            txtPeso.Text = "";
            lblResposta.Text = "";
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            clsIMC IMC = new clsIMC();
            IMC.Altura = double.Parse(txtAltura.Text);
            IMC.Peso = double.Parse(txtPeso.Text);
            txtIMC.Text = IMC.imc.ToString("#0.00");
            lblResposta.Text = IMC.Resultado;
        }
        #endregion

    }
}
