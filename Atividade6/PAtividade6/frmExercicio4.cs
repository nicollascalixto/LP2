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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] tamanhos = new int[10];

            for (int i = 0; i < 10; i++)
            {
                string nome;

                do
                {
                    nome = Interaction.InputBox($"Digite o nome {i + 1}:").Trim();
                }
                while (string.IsNullOrWhiteSpace(nome));

                nomes[i] = nome;
                tamanhos[i] = nome.Replace(" ", "").Length;
            }

            lstNomes.Items.Clear();

            for (int i = 0; i < 10; i++)
            {
                lstNomes.Items.Add($"{nomes[i]} - {tamanhos[i]} caracteres");
            }
        }
    }
}
