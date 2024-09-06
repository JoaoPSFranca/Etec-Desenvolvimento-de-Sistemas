using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjPalindromoClasse
{
    public partial class frm35347_Palindromo : Form
    {
        #region Inicializar
        public frm35347_Palindromo()
        {
            InitializeComponent();
        }
        #endregion 

        #region btn
        private void btnPalio_Click(object sender, EventArgs e)
        {
            if (txtPalio.Text == "")
            {
                lblPalio.Text = "Digite algo";
                return;
            }

            lblPalio.Text = cls35347.Verificar(txtPalio.Text);
        }
        #endregion

        #region txt
        private void txtPalio_TextChanged(object sender, EventArgs e)
        {
            lblPalio.Text = "";
        }
        #endregion
    }
}
