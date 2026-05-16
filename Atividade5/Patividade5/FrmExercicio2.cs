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
    public partial class FrmExercicio2 : Form
    {
        int ValorN;


        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Double ValorH = 0;

            for (int i = 1; i <= ValorN; i++) {
                
                ValorH = ValorH + (1.0/i);

            }

            ValorH = Math.Round(ValorH, 4);
            MessageBox.Show($"Valor do H: {ValorH}");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out ValorN))
            {
                MessageBox.Show("Insira um número inteiro para o valor de N!");
                textBox1.Focus();
                textBox1.Clear(); //Aqui limpa o txtbox inteiro.
                //Caso eu queira apagar só um caractere SendKeys.Send("{BACKSPACE}");
            }
        }
    }
}
