using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patividade5
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
            this.ActiveControl = txtFrase;
        }

        private void btnEspacos_Click(object sender, EventArgs e)
        {
            int Cont = 0;

            foreach (char i in txtFrase.Text)
            {
                if (i == ' ')
                {
                    Cont++;
                }
            }
            MessageBox.Show($"O texto digitado tem {Cont} espaços");
        }

        private void txtFrase_Validated(object sender, EventArgs e)
        {
            //Validar se existem dados digitados
            if (txtFrase.Text == string.Empty)
            {
                MessageBox.Show("Campo de texto vazio, digite uma frase!");
                txtFrase.Focus();
            }

        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int i = 0;
            int tamanho = txtFrase.Text.Length;
            int cont = 0;
            while (i < tamanho)
            {
                //O método ToUpper dentro da classe char deixa 1 unico char maiusculo
                //Caso use o ToUpper da classe string, ele vai deixar a string inteira maiúscula
                if (char.ToUpper(txtFrase.Text[i]) == 'R')
                {
                    cont++;
                }
                i++;
            }
            MessageBox.Show($"O número de R no texto é {cont}.");
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            int tamanho = txtFrase.Text.Length;
            //colocando toda string maiuscula para garantir (com o método da string)
            string textomaiusculo = txtFrase.Text.ToUpper();

            int Cont = 0;

            //Fazendo o i partir de 1 pois preciso comparar com (i -1) em cada iteração
            for(int i = 1; i<tamanho; i++)
            {
                if(textomaiusculo[i] != '.' && textomaiusculo[i] == textomaiusculo[(i - 1)])
                {
                    Cont++;
                }
            }
            MessageBox.Show($"A quantidade de letras iguais sucessivas no texto é: {Cont}");
        }
    }
}
