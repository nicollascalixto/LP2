using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade6
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = 40;

            string[] gabarito = { "A", "B", "C", "D", "E", "A", "B", "C", "D", "E" };

            lstResultado.Items.Clear();

            for (int aluno = 0; aluno < N; aluno++)
            {
                lstResultado.Items.Add($"===== Aluno {aluno + 1} =====");

                for (int q = 0; q < 10; q++)
                {
                    string resp;

                    while (true)
                    {
                        resp = Interaction.InputBox(
                            $"Aluno {aluno + 1} - Questão {q + 1} (A,B,C,D,E):"
                        );

                        if (string.IsNullOrEmpty(resp))
                            return;

                        resp = resp.ToUpper();

                        if (resp == "A" || resp == "B" || resp == "C" || resp == "D" || resp == "E")
                            break;

                        MessageBox.Show("Digite apenas A, B, C, D ou E.");
                    }

                    if (resp == gabarito[q])
                    {
                        lstResultado.Items.Add(
                            $"Aluno {aluno + 1} ACERTOU a questão {q + 1} (Gabarito: {gabarito[q]} | Escolheu: {resp})"
                        );
                    }
                    else
                    {
                        lstResultado.Items.Add(
                            $"Aluno {aluno + 1} ERROU a questão {q + 1} (Gabarito: {gabarito[q]} | Escolheu: {resp})"
                        );
                    }
                }

                lstResultado.Items.Add(" ");
            }
        }

        private void frmExercicio5_Load(object sender, EventArgs e)
        {

        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
