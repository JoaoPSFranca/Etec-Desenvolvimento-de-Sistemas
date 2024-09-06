using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_RM
{
    public partial class frm35347_RM : Form
    {
        #region Inicializar
        public frm35347_RM()
        {
            InitializeComponent();
        }
        #endregion

        #region frmClosing
        private void frm35347_RM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Nome: João, Franca  RM: 35347", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNG.Text = "";
            txtRM.Text = "";
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            int X = 0;
            #endregion

            #region VerificarNúmero
            if (txtRM.Text != "")
            {
                try
                {
                    X = int.Parse(txtRM.Text);
                    cls35347_RM.NRM = X.ToString();
                }
                catch
                {
                    MessageBox.Show("Insira apenas números");
                    txtRM.Text = "";
                    return;
                }
            }
            #endregion

            #region variáveis
            int Y = cls35347_RM.Soma(cls35347_RM.NG);
            #endregion

            #region Mostrar
            txtNG.Text = cls35347_RM.NGF(Y);
            #endregion
        }
        #endregion

        #region txtRM
        private void txtRM_TextChanged(object sender, EventArgs e)
        {
            #region Verificar btnCalc
            if (txtRM.TextLength == 5)
            {
                btnCalc.Enabled = true;
            }
            else
            {
                btnCalc.Enabled = false;
            }
            #endregion  
  
            #region Verificar btnLimpar
            if (txtRM.Text != "" || txtNG.Text != "")
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }
            #endregion

            txtNG.Text = "";
        }
        #endregion
    }
}
