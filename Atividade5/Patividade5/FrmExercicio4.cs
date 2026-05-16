using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patividade5
{
    public partial class FrmExercicio4 : Form
    {   
        //Variaveis declaradas aqui em cima para validar com validated e try parse
        Double Salario, SalBruto,gratificacao;
        int prod;

        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void txtSal_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtSal.Text, out Salario))
            {
                MessageBox.Show("Insira o valor do salario base");
                txtSal.Focus();
                txtSal.Clear(); //Aqui limpa o txtbox inteiro.
                //Caso eu queira apagar só um caractere SendKeys.Send("{BACKSPACE}");
            }
        }

        private void txtGrat_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtGrat.Text, out gratificacao))
            {
                MessageBox.Show("Insira o valor da gratificação");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            //Validar se existem dados digitados
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Inserir Nome!");
                textBox1.Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            //Validar se existem dados digitados
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Inserir Matricula!");
                textBox2.Focus();
            }
        }

        private void lblEx4Mat_Click(object sender, EventArgs e)
        {

        }

        private void btnEx4SalBruto_Click(object sender, EventArgs e)
        {

            int B, C, D;
            B = 0;
            C = 0;
            D = 0;

            //Formula A + Ax(0, 05xB + 0, 1xC + 0, 1xD) + Total de gratificações.
            if(prod>= 150)
            {
                B = 1;
                C = 1;
                D = 1;
            }
            else if (prod >= 120)
            {
                B = 1;
                C = 1;
            }
            else if (prod >= 100)
            {
                B = 1;
            }

            SalBruto = Salario + (Salario * (0.05 * B + 0.1 * C + 0.1 * D))+gratificacao;

            if(SalBruto > 7000.00 && (prod < 150 || gratificacao == 0))
            {
                SalBruto = 7000.00;
            }

            txtSalBruto.Text = SalBruto.ToString("F2");
        }

        private void txtProd_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProd.Text, out prod))
            {
                MessageBox.Show("Insira o valor da produção!");
                txtProd.Focus();
                txtProd.Clear(); //Aqui limpa o txtbox inteiro.
                //Caso eu queira apagar só um caractere SendKeys.Send("{BACKSPACE}");
            }
        }
    }
}
