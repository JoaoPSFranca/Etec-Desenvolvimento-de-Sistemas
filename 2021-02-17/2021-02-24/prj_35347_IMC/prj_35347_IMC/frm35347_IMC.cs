using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_35347_IMC
{
    public partial class frm35347_IMC : Form
    {
        #region Inicializar
        public frm35347_IMC()
        {
            InitializeComponent();
        }
        #endregion

        #region Fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Cálculo Índice da Massa Corporal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Método Limpar
        private void Limpar()
        {
            txtAltura.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            lblResp.Text = "";
            txtPeso.Focus();
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Peso = 0;
            double Altura = 0;
            double Altura2 = 0;
            double IMC = 0;

            try
            {
                Peso = double.Parse(txtPeso.Text);
                Altura = double.Parse(txtAltura.Text);
            }

            catch
            {
                MessageBox.Show("Digite somente número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            Altura2 = Altura * Altura;
            IMC = Peso / Altura2;

            if (IMC < 20)
            {
                lblResp.Text = "Abaixo do Peso";
            }
            else
            {
                if (IMC >= 25)
                {
                    lblResp.Text = "Acima do Peso";
                }
                else
                {
                    lblResp.Text = "Peso Ideal";
                }
            }
            txtIMC.Text = IMC.ToString("#0.00");
        }
        #endregion

        #region txtPeso
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtIMC.Clear();
        }
        #endregion

        #region txtAltura
        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            lblResp.Text = "";
            txtIMC.Clear();
        }
        #endregion
    }
}
