using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace PAtividade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int numero;
                bool valido = false;

                do
                {
                    string entrada = Interaction.InputBox($"Digite o número {i + 1}:");

                    valido = int.TryParse(entrada, out numero);

                    if (!valido)
                        MessageBox.Show("Digite apenas números inteiros!");
                }
                while (!valido);

                numeros[i] = numero;
            }

            Array.Reverse(numeros);

            string resultado = "Ordem inversa:\n";
            foreach (int n in numeros)
            {
                resultado += n + "\n";
            }

            MessageBox.Show(resultado);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList()
    {
        "Ana", "André", "Beatriz", "Camila",
        "João", "Joana", "Otávio",
        "Marcelo", "Pedro", "Thais"
    };

            alunos.Remove("Otávio");

            string resultado = "";

            foreach (string aluno in alunos)
            {
                resultado += aluno + "\n";
            }

            MessageBox.Show(resultado);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            string resultado = "";

            for (int i = 0; i < 20; i++)
            {
                double soma = 0;

                for (int j = 0; j < 3; j++)
                {
                    double nota;

                    do
                    {
                        nota = double.Parse(Interaction.InputBox($"Aluno {i + 1} - Nota {j + 1} (0 a 10):"));
                    }
                    while (nota < 0 || nota > 10);

                    notas[i, j] = nota;
                    soma += nota;
                }

                double media = soma / 3;
                resultado += $"Aluno {i + 1}: média: {media:F1}\n";
            }

            MessageBox.Show(resultado);
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            frmExercicio4 frm4 = new frmExercicio4();
            frm4.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio5"].BringToFront();
            }
            else
            {
                frmExercicio5 frm5 = new frmExercicio5();
                frm5.Show();
            }
        }
    }
}
