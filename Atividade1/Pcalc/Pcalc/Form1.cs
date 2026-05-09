using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Resultado;

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnSair)
            {
                return;
            }
            if (!double.TryParse(txtNum2.Text, out Num2))
            {
                MessageBox.Show("Numero 2 invalido");
                txtNum2.Focus();
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            Resultado = Num1 + Num2;
            txtResultdo.Text = Resultado.ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Resultado = Num1 - Num2;
            txtResultdo.Text = Resultado.ToString();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Resultado = Num1 * Num2;
            txtResultdo.Text = Resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Num2 == 0)
            {

                MessageBox.Show("DIVISAO POR ZERO ");
                txtNum2.Focus();
            }
            else
            {
                Resultado = Num1 / Num2;
                txtResultdo.Text = Resultado.ToString();
            }
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultdo.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnSair)
            {
                return;
            }

            if (!double.TryParse(txtNum1.Text, out Num1)) {
                MessageBox.Show("Numero 1 invalido");
                txtNum1.Focus();
            }
            
            
         
                
        }
    }
}
