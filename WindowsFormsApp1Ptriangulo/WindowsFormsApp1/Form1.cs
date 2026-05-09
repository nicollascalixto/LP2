using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double valorA, valorB, valorC;

        private void txtValb_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtValb, "");
                this.valorB = Convert.ToDouble(txtValb.Text);
            }
            catch
            {
                errorProvider1.SetError(txtValb, "Valor B invalido");

            }
        }

        private void txtValc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtValc, "");
                this.valorC = Convert.ToDouble(txtValc.Text);
            }
            catch
            {
                errorProvider1.SetError(txtValc, "Valor C invalido");

            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if ((valorA < (valorB + valorC)) &&
                (valorA > (Math.Abs(valorB) - valorC)) &&
                (valorB < (valorA + valorC)) &&
                (valorB > (Math.Abs(valorC) - valorA)) &&
                (valorC < (valorA + valorB)) &&
                (valorC > (Math.Abs(valorA) - valorB)))
            {

                if ((valorA == valorB) && (valorA == valorC))
                {
                    MessageBox.Show("È EQUILATERO");
                }
                else if ((valorA == valorB) && (valorA != valorC)
                    || (valorA == valorC) && (valorA != valorB))
                {
                    MessageBox.Show("È ISOSCELES");
                }
                else
                    MessageBox.Show("È ESCALENO");
            }
            else
                MessageBox.Show("Nao´formam triangulo");
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtValA.Clear();
            txtValb.Clear();
            txtValc.Clear();

            valorA = 0;
            valorB = 0;
            valorC = 0;
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtValA_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtValA, "");
                this.valorA = Convert.ToDouble(txtValA.Text);
            }
            catch
            {
                errorProvider1.SetError(txtValA, "Valor A invalido");

            }
        }
    }
}
