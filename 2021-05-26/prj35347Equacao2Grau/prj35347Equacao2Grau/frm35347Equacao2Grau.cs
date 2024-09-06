using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347Equacao2Grau
{
    public partial class frm35347Equacao2Grau : Form
    {
        #region Inicializar
        public frm35347Equacao2Grau()
        {
            InitializeComponent();
        }
        #endregion

        #region Forms

        #region Variável Global
        int X = 0;
        #endregion

        #region Form Load
        private void frm35347Equacao2Grau_Load(object sender, EventArgs e)
        {
            Size = new Size(486, 418);
            this.KeyPreview = true;
            btnCalc.Enabled = false;
            txtA.Focus();
        }
        #endregion

        #region Form Click
        private void frm35347Equacao2Grau_Click(object sender, EventArgs e)
        {
            if (X == 0)
            {
                Size = new Size(486, 608);
                X = 1;
            }
            else
            {
                Size = new Size(486, 418);
                X = 0;
            }
        }
        #endregion

        #region Form Closing
        private void frm35347Equacao2Grau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Equação do 2º Grau", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Form KeyDown
        private void frm35347Equacao2Grau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        #endregion

        #endregion

        #region Limpar

        #region Buton
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region Método Limpar
        private void Limpar()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lblA1.Text = "A";
            lblA2.Text = "A";
            lblA3.Text = "A";
            lblB1.Text = "B";
            lblB2.Text = "B";
            lblB21.Text = "B²";
            lblC1.Text = "C";
            lblC2.Text = "C";
            lblC3.Text = "C";
            lblRDelta.Text = "";
            lblX11.Text = "X";
            lblX12.Text = "X";
            lblX21.Text = "X²";
            lblX22.Text = "X²";
            pbxGrafico.Image = null;
        }
        #endregion

        #endregion

        #region Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Calcular
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis

            double Delta = 0.0;
            double X1 = 0.0;
            double X2 = 0.0;
            double A = 0.0;
            double B = 0.0;
            double C = 0.0;

            #endregion

            #region Try's

                #region Try A
                try
                {
                    A = double.Parse(txtA.Text);
                }
                catch 
                {
                    MessageBox.Show("Informe apenas números no valor A", "Equação do 2º Grau", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtA.Text = "";
                    return;
                }
                #endregion

                #region Try B
                try
                {
                    B = double.Parse(txtB.Text);
                }
                catch
                {
                    MessageBox.Show("Informe apenas números no valor B", "Equação do 2º Grau", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtB.Text = "";
                    return;
                }
                #endregion

                #region Try C
                try
                {
                    C = double.Parse(txtC.Text);
                }
                catch
                {
                    MessageBox.Show("Informe apenas números no valor C", "Equação do 2º Grau", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtC.Text = "";
                    return;
                }
                #endregion

            #endregion

            #region Calcular

                #region Delta
                Delta = Math.Pow(B, 2) - 4 * A * C;
                #endregion

                #region X1
                X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                #endregion

                #region X2
                X2 = (-B - Math.Sqrt(Delta)) / (2 * A);
                #endregion

            #endregion

            #region Mostrar

            lblA1.Text = txtA.Text;
            lblA2.Text = txtA.Text;
            lblA3.Text = txtA.Text;

            lblB1.Text = txtB.Text;
            lblB2.Text = txtB.Text;
            lblB21.Text = txtB.Text + "²";

            lblC1.Text = txtC.Text;
            lblC2.Text = txtC.Text;
            lblC3.Text = txtC.Text;

            lblRDelta.Text = Delta.ToString("#");

            lblX11.Text = X1.ToString("#");
            lblX12.Text = X2.ToString("#");

            lblX21.Text = X1.ToString("#") + "²";
            lblX22.Text = X2.ToString("#") + "²";

            #endregion

            #region PicBox

            if (Delta == 0 & A > 0)
            {
                pbxGrafico.Load ("../../Images/D0AMA0.bmp");
            }
            else
            {
                if (Delta == 0 & A < 0)
                {
                    pbxGrafico.Load ("../../Images/D0AME0.bmp");
                }
                else
                {
                    if (Delta > 0 & A > 0)
                    {
                        pbxGrafico.Load ("../../Images/DMA0AMA0.bmp");
                    }
                    else
                    {
                        if (Delta > 0 & A < 0)
                        {
                            pbxGrafico.Load ("../../Images/DMA0AME0.bmp");
                        }
                        else
                        {
                            if (Delta < 0 & A > 0)
                            {
                                pbxGrafico.Load("../../Images/DME0AMA0.bmp");
                            }
                            else
                            {
                                if (Delta < 0 & A < 0)
                                {
                                    pbxGrafico.Load ("../../Images/DME0AME0.bmp");
                                }
                            }
                        }
                    }
                }
            }

            #endregion
        }
        #endregion

        #region TextChanged's

        #region Método Verifica
        public bool Verifica()
        {
            if (txtA.TextLength > 0 & txtB.TextLength > 0 & txtC.TextLength > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region TxtA
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = Verifica();
        }
        #endregion

        #region TxtB
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = Verifica();
        }
        #endregion

        #region TxtC
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = Verifica();
        }
        #endregion

        #endregion
    }
}
