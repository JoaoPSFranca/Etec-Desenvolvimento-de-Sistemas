using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_CPF
{
    public partial class frm35347_CPF : Form
    {
        #region Inicializar
        public frm35347_CPF()
        {
            InitializeComponent();
        }
        #endregion

        #region btnLimpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtxtNumeros.Text = "";
            lblResultado.Text = "";
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            cls35347_CPF.NCPF = mtxtNumeros.Text.Replace(",", "").Replace("-", "");
            int valor1 = int.Parse(cls35347_CPF.NCPF.Substring(9, 1));
            int valor2 = int.Parse(cls35347_CPF.NCPF.Substring(10, 1));
            int digito1 = cls35347_CPF.ReturnDigito1;
            int digito2 = cls35347_CPF.ReturnDigito2;
            #endregion

            #region Verificar
            if (digito1 == valor1 && digito2 == valor2)
            {
                lblResultado.Text = "CPF Válido";
            }
            else
            {
                lblResultado.Text = "CPF Inválido";
            }
            #endregion
        }
        #endregion

        #region mtxtNumeros
        private void mtxtNumeros_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }
        #endregion
    }
}
