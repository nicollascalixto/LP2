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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            //Coloca a string inteira em maiuscula
            string frase = txtEx3.Text.ToUpper();
            frase = frase.Replace(" ", "");

            //transformando a string em vetor, para reverter
            char[] vetor = frase.ToCharArray();
            //método do vetor que reverte
            Array.Reverse(vetor);
            //Reconstruindo a string invertida
            string fraseIvertida = new string(vetor);

            if (frase == fraseIvertida)
            {
                MessageBox.Show("Palíndromo confirmado!");
            }
            else { MessageBox.Show("Não é um Palíndromo");}
        }

        private void txtEx3_Validated(object sender, EventArgs e)
        {
            //Validar se existem dados digitados
            if (txtEx3.Text == string.Empty)
            {
                MessageBox.Show("Campo de texto vazio, digite uma palavra ou frase!");
                txtEx3.Focus();
            }
        }
    }
}
