using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Acad
{
    public partial class frm35347_Acad : Form
    {
        #region Inicializar
        public frm35347_Acad()
        {
            InitializeComponent();
        }
        #endregion

        //#region FormClosing
        //private void frm35347_Acad_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Deseja Sair?", "Academia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //#endregion

        #region Verificar

        #region Método Verificar
        public void Verificar()
        {
            if (ltbEscolhidas.Items.Count > 0)
            {
                btnExcluir.Enabled = true;

                if (mtxtMatricula.TextLength > 0 & txtNome.TextLength > 0)
                {
                    if (rdbManha.Checked | rdbNoite.Checked | rdbTarde.Checked)
                    {
                        if (cbxQua.Checked | cbxQui.Checked | cbxSab.Checked | cbxSeg.Checked | cbxSex.Checked | cbxTer.Checked)
                        {
                            btnCalc.Enabled = true;
                        }
                        else
                        {
                            btnCalc.Enabled = false;
                        }
                    }
                    else
                    {
                        btnCalc.Enabled = false;
                    }
                }
                else
                {
                    btnCalc.Enabled = false;
                }
            }
            else
            {
                btnCalc.Enabled = false;
            }
        }
        #endregion

        #region mtxtMatricula
        private void mtxtMatricula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Verificar();
        }
        #endregion

        #region txtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region rdbManha
        private void rdbManha_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region rdbTarde
        private void rdbTarde_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region rdbNoite
        private void rdbNoite_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxSeg
        private void cbxSeg_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxTer
        private void cbxTer_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxQua
        private void cbxQua_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxQui
        private void cbxQui_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxSex
        private void cbxSex_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region cbxSab
        private void cbxSab_CheckedChanged(object sender, EventArgs e)
        {
            Verificar();
        }
        #endregion

        #region ltbModalidade
        private void ltbModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbModalidade.SelectedIndices == null)
            {
                btnInserir.Enabled = false;
            }
            else
            {
                btnInserir.Enabled = true;
            }
        }
        #endregion

        #region ltbEscolhidas
        private void ltbEscolhidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbEscolhidas.SelectedIndices == null)
            {
                btnExcluir.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
            }
        }
        #endregion

        #endregion

        #region Btn's

        #region btnInserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbEscolhidas.Items.Add(ltbModalidade.Text);
            ltbModalidade.Items.Remove(ltbModalidade.SelectedItem);
            btnInserir.Enabled = false;
            Verificar();
        }
        #endregion

        #region btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ltbModalidade.Items.Add(ltbEscolhidas.Text);
            ltbEscolhidas.Items.Remove(ltbEscolhidas.SelectedItem);
            btnExcluir.Enabled = false;
            Verificar();
        }
        #endregion

        #region btnCalc
        private void btnCalc_Click(object sender, EventArgs e)
        {
            #region Variáveis
            int X = 0;
            double Val = 0;
            int Mod = ltbEscolhidas.Items.Count;
            #endregion

            #region IF's Dias

            #region cbxSeg
            if (cbxSeg.Checked)
            {
                X = X + 1;
            }
            #endregion

            #region cbxTer
            if (cbxTer.Checked)
            {
                X = X + 1;
            }
            #endregion

            #region cbxQua
            if (cbxQua.Checked)
            {
                X = X + 1;
            }
            #endregion

            #region cbxQui
            if (cbxQui.Checked)
            {
                X = X + 1;
            }
            #endregion

            #region cbxSex
            if (cbxSex.Checked)
            {
                X = X + 1;
            }
            #endregion

            #region cbxSab
            if (cbxSab.Checked)
            {
                X = X + 1;
            }
            #endregion

            #endregion

            #region if Manhã
            if (rdbManha.Checked)
            {
                if (X < 2)
                {
                    Val = Mod * 20;
                }
                else
                {
                    Val = Mod * 30;
                }
            }
            #endregion

            #region if Tarde
            if (rdbTarde.Checked)
            {
                if (X < 2)
                {
                    Val = Mod * 20;
                }
                else
                {
                    Val = Mod * 30;
                }

                Val = Val - (Val * 0.10);
            }
            #endregion

            #region if Noite
            if (rdbNoite.Checked)
            {
                if (X < 2)
                {
                    Val = Mod * 20;
                }
                else
                {
                    Val = Mod * 30;
                }

                Val = Val - (Val * 0.15);
            }
            #endregion

            #region Mostrar
            txtVal.Text = Val.ToString("c");
            #endregion
        }
        #endregion

        #endregion
    }
}
