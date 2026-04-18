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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text;
            string palavra2 = txtPalavra2.Text;

            if (string.IsNullOrWhiteSpace(palavra1) || string.IsNullOrWhiteSpace(palavra2))
            {
                MessageBox.Show("Preencha os dois campos");
                return;
            }

            bool iguais = palavra1.Trim().Equals(palavra2.Trim(), StringComparison.OrdinalIgnoreCase);

            if (iguais)
            {
                MessageBox.Show("As palavras são iguais!");
            }
            else
            {
                MessageBox.Show("As palavras são diferentes.");
            }



        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text.Trim();
            string palavra2 = txtPalavra2.Text.Trim();

            if (string.IsNullOrWhiteSpace(palavra1) || string.IsNullOrWhiteSpace(palavra2))
            {
                MessageBox.Show("Preencha os dois campos.");
                return;
            }

            int meio = palavra2.Length / 2;

            string resultado = palavra2.Substring(0, meio)
                             + palavra1
                             + palavra2.Substring(meio);

            txtPalavra2.Text = resultado;
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text.Trim();

            if (string.IsNullOrWhiteSpace(palavra1))
            {
                MessageBox.Show("Preencha a Palavra 1.");
                return;
            }

            int meio = palavra1.Length / 2;

            string resultado = palavra1.Insert(meio, "**");

            txtPalavra2.Text = resultado;
        }
    }
}

    

