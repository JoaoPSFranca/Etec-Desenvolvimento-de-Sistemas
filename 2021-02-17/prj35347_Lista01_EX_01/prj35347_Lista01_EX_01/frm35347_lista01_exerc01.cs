using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj35347_Lista01_EX_01
{
    public partial class frm35347_lista01_exerc01 : Form
    {
        public frm35347_lista01_exerc01()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtValor1.Text = "";
            txtValor2.Clear();
            txtSoma.Text = "";
            lblRes.Text = "";
            txtValor1.Focus();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double soma = 0;

            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);

            }
            catch
            {
                MessageBox.Show("Digite somente número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            soma = val1 + val2;

            txtSoma.Text = soma.ToString("#0.00");
            lblRes.Text = soma.ToString("c");
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double resultado = 0;

            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);
            }
            catch 
            {
                MessageBox.Show("Digite número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            resultado = val1 - val2;

            txtSoma.Text = resultado.ToString("#0.00");
            lblRes.Text = resultado.ToString("c");
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double resultado = 0;

            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);
            }
            catch
            {
                MessageBox.Show("Digite número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            resultado = val1 * val2;

            txtSoma.Text = resultado.ToString("#0.00");
            lblRes.Text = resultado.ToString("c");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double val1 = 0;
            double val2 = 0;
            double resultado = 0;

            try
            {
                val1 = double.Parse(txtValor1.Text);
                val2 = double.Parse(txtValor2.Text);
            }
            catch
            {
                MessageBox.Show("Digite número com \n ou sem decimal", "Erro na digitação");
                Limpar();
                return;
            }

            if (val2==0)
            {
                MessageBox.Show("'Não dividirás por 0' \n \n Artistóteles 2:4");
                Limpar();
                return;
            }

            resultado = val1 / val2;

            txtSoma.Text = resultado.ToString("#0.00");
            lblRes.Text = resultado.ToString("c");
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
            txtSoma.Text = "";
            lblRes.Text = "";
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {
            txtSoma.Text = "";
            lblRes.Text = "";
        }
    }
}
