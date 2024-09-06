using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Triangulos
{
    public partial class frm35347_Triangulo : Form
    {
        #region inicializar
        public frm35347_Triangulo()
        {
            InitializeComponent();
        }
        #endregion

        #region rdbTipoTri
        private void rdbTipoTri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoTri.Checked == true)
            {
                gpbTipoTri.Visible = true;
            }
            else
            {
                gpbTipoTri.Visible = false;
                txtValX.Text = "";
                txtValY.Text = "";
                txtValZ.Text = "";
                txtTipoTri.Text = "";
            }
        }
        #endregion

        #region rdbAreaTri
        private void rdbAreaTri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAreaTri.Checked == true)
            {
                gpbAreaTri.Visible = true;
            }
            else
            {
                gpbAreaTri.Visible = false;
                txtBase.Text = "";
                txtAltura.Text = "";
                txtAreaTri.Text = "";
                ltbLista.Items.Clear();
            }
        }
        #endregion

        #region CheckBox
        private void cbxLimpar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLimpar.Checked == true)
            {
                btnLimparLista.Enabled = true;
                cbxLimpar.Text = "Desativar";
            }
            else
            {
                btnLimparLista.Enabled = false;
                cbxLimpar.Text = "Ativar";
            }
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Escolha

            #region AreaTri
            if (rdbAreaTri.Checked==true)
            {
                #region Variáveis
                double Base = 0.0;
                double Altura = 0.0;
                double Area = 0.0;
                #endregion

                #region TryBase
                try
                {
                    Base = double.Parse(txtBase.Text);
                }
                catch
                {
                    MessageBox.Show("Insira somente números com\n decimal na Base", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtBase.Text = "";
                    txtBase.Focus();
                    return;
                }
                #endregion

                #region TryAltura
                try
                {
                    Altura = double.Parse(txtAltura.Text);
                }
                catch
                {
                    MessageBox.Show("Insira somente números com\n decimal na Altura", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtAltura.Text = "";
                    txtAltura.Focus();
                    return;
                }
                #endregion

                #region Cálculo
                Area = (Base * Altura) / 2;
                #endregion

                #region Mostrar
                txtAreaTri.Text = Area.ToString();
                ltbLista.Items.Add ("A área do triângulo é: " + Area.ToString() + ".");
                #endregion
            }
            #endregion

            #region TipoTri
            else
            {
                if (rdbTipoTri.Checked == true)
                {
                    txtTipoTri.Text = "";
                    pbxTipoTri.Image = null;

                    #region Variáveis

                    double X = 0.0;
                    double Y = 0.0;
                    double Z = 0.0;
                    double A = 0.0;
                    double B = 0.0;
                    double C = 0.0;

                    #endregion

                    #region TryX
                    try
                    {
                        X = double.Parse(txtValX.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Insira somente números com\ndecimal no Valor X", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtValX.Text = "";
                        txtValX.Focus();
                        return;
                    }
                    #endregion

                    #region TryY
                    try
                    {
                        Y = double.Parse(txtValY.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Insira somente números com\ndecimal no Valor Y", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtValY.Text = "";
                        txtValY.Focus();
                        return;
                    }
                    #endregion

                    #region TryZ
                    try
                    {
                        Z = double.Parse(txtValZ.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Insira somente números com\ndecimal no Valor Z", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtValZ.Text = "";
                        txtValZ.Focus();
                        return;
                    }
                    #endregion

                    #region Verificar
                    A = X + Y;
                    B = X + Z;
                    C = Y + Z;

                    if (A <= Z | B <= Y | C <= X)
                    {
                        pbxTipoTri.Load("../../Images/Triangulos/nãotriângulo.jpg");
                        txtTipoTri.Text = "Não é um Triângulo";
                        return;
                    }
                    else
                    {
                        #region TiposTri
                        if (X == Y)
                        {
                            #region Equilátero
                            if (Y == Z)
                            {
                                txtTipoTri.Text = "Triângulo Equilátero";
                                pbxTipoTri.Load("../../Images/Triangulos/equilátero.jpg");
                            }
                            #endregion

                            #region Isóceles
                            else
                            {
                                txtTipoTri.Text = "Triângulo Isóceles";
                                pbxTipoTri.Load("../../Images/Triangulos/isósceles.jpg");
                            }
                            #endregion
                        }

                        #region Escaleno
                        else
                        {
                            txtTipoTri.Text = "Triângulo Escaleno";
                            pbxTipoTri.Load("../../Images/Triangulos/escaleno.jpg");
                        }
                        #endregion

                        #endregion
                    }

                    #endregion
                }

                #region Nenhum
                else
                {
                    MessageBox.Show("Por favor selecione algo na aba 'Escolha'", "Triângulos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtAreaTri.Text = "";
            txtBase.Text = "";
            txtTipoTri.Text = "";
            txtValX.Text = "";
            txtValY.Text = "";
            txtValZ.Text = "";
            pbxTipoTri.Image = null;
        }
        #endregion

        #region LimparLista
        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            ltbLista.Items.Clear();
        }
        #endregion
    }
}
