using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void frmExercicio5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) ||
                string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Preencha as duas caixas!");
                return;
            }

            int numero1, numero2;

            if (!int.TryParse(txtNum1.Text, out numero1) ||
                !int.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Digite apenas números válidos!");
                return;
            }

            if (numero1 > numero2)
            {
                MessageBox.Show("O Número 1 deve ser menor ou igual ao Número 2!");
                return;
            }

            Random rnd = new Random();
            int resultado = rnd.Next(numero1, numero2 + 1);

            txtResultado.Text = resultado.ToString();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNum1.Text) ||
                string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Preencha as duas caixas!");
                return;
            }

            int numero1, numero2;

            if (!int.TryParse(txtNum1.Text, out numero1) ||
                !int.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Digite apenas números válidos!");
                return;
            }

            if (numero1 > numero2)
            {
                MessageBox.Show("O Número 1 é MAIOR que o Número 2");
            }
            else if (numero1 < numero2)
            {
                MessageBox.Show("O Número 1 é MENOR que o Número 2");
            }
            else
            {
                MessageBox.Show("Os dois números são IGUAIS");
            }
        }
    }
}




