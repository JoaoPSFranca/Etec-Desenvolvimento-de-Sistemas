using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_TituloEleitor
{
    public partial class frm35347_TituloEleitor : Form
    {

        #region Inicializar
        public frm35347_TituloEleitor()
        {
            InitializeComponent();
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCD.Text = "";
            txtLocal.Text = "";
            txtValidade.Text = "";
            txtCD.Focus();
        }
        #endregion

        #region txtCD
        private void txtCD_TextChanged(object sender, EventArgs e)
        {
            #region LimparOutros
            txtLocal.Text = "";
            txtValidade.Text = "";
            #endregion

            #region btnLimpar
            if (txtCD.TextLength > 0)
            {
                btnLimpar.Enabled = true;
            }
            #endregion

            #region btnCalc
            if (txtCD.TextLength > 9)
            {
                btnCalc.Enabled = true;
            }
            #endregion
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region TryCD
            try
            {
                double X = double.Parse(txtCD.Text);
            }
            catch
            {
                MessageBox.Show("Favor inserir apenas números");
                txtCD.Text = "";
                txtCD.Focus();
                return;
            }
            #endregion

            #region length12
            string cd = txtCD.Text;
            while (cd.Length != 12)
            {
                cd = "0" + cd;
            }
            #endregion

            cls35347_TituloEleitor.NCD = cd;
            cd = cls35347_TituloEleitor.NCD;
            txtCD.Text = cd;

            string resposta = cls35347_TituloEleitor.VerificarUF;

            if (resposta == "Número Inválido")
            {
                txtValidade.Text = resposta;
            }
            else
            {
                string validade = cls35347_TituloEleitor.VerificarDV(cd.Substring(0, 8), cd.Substring(8, 4));
                txtValidade.Text = validade;

                if (validade != "Número Inválido")
                {
                    txtLocal.Text = resposta;
                }
            }
        }
        #endregion

        #region formClosing
        private void frm35347_TituloEleitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Calcular TE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
