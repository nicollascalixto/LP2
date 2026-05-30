using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Microsoft.VisualBasic;
namespace Pvestibular01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReceberDados_Click(object sender, EventArgs e)
        {
            int[,] Dados = new int[3, 5];
            string aux = "";
            int[] totalCurso = new int[3];

            for (int curso = 0; curso < 3; curso ++) {
                for ( int ano = 0; ano < 5; ano ++)
                {
                            aux = Interaction.InputBox("Total do Curso:  " + (curso +1) + " do ano " + (ano +1)  + ":");

                        if (aux == "")
                    {
                        return;
                    }
                        if (!int.TryParse(aux, out Dados[curso,ano]) || Dados[curso,ano] < 0)
                    {
                        MessageBox.Show("valor Invalido");
                        ano--;
                    }
                        else
                    {
                         totalCurso[curso] += Dados[curso, ano];
                    }

                }
                        int TotalGeral = 0;
                for (int curso1 = 0; curso1 < 3; curso1++)
                {
                    ltsbxResultado.Items.Add($"Total do Curso:  {totalCurso[curso1]} ");
                    TotalGeral += totalCurso[curso1];
                }
                ltsbxResultado.Items.Add("______________________________");
                ltsbxResultado.Items.Add($"Total Geral: {TotalGeral}");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
                    ltsbxResultado.Items.Clear();
        }

        private void ltsbxResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
