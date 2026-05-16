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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio1>().Count() > 0)
            {
                Application.OpenForms["frmExercicio1"].BringToFront();
            }
            else
            {

                //Como instanciar um objeto: Classe(Nome da classe que vc criou), Nome do Objeto  = new Classe 
                FrmExercicio1 frmExercicio1 = new FrmExercicio1();
                frmExercicio1.MdiParent = this;
                frmExercicio1.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicio2"].BringToFront();
            }
            else
            {

                //Como instanciar um objeto: Classe(Nome da classe que vc criou), Nome do Objeto  = new Classe 
                FrmExercicio2 frmExercicio2 = new FrmExercicio2();
                frmExercicio2.MdiParent = this;
                frmExercicio2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio3>().Count() > 0)
            {
                Application.OpenForms["frmExercicio3"].BringToFront();
            }
            else
            {

                //Como instanciar um objeto: Classe(Nome da classe que vc criou), Nome do Objeto  = new Classe 
                FrmExercicio3 frmExercicio3 = new FrmExercicio3();
                frmExercicio3.MdiParent = this;
                frmExercicio3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmExercicio4>().Count() > 0)
            {
                Application.OpenForms["frmExercicio4"].BringToFront();
            }
            else
            {

                //Como instanciar um objeto: Classe(Nome da classe que vc criou), Nome do Objeto  = new Classe 
                FrmExercicio4 frmExercicio4 = new FrmExercicio4();
                frmExercicio4.MdiParent = this;
                frmExercicio4.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
