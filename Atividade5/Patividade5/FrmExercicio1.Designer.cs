namespace Patividade5
{
    partial class FrmExercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEspacos = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.RichTextBox();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.lblExercicio1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEspacos
            // 
            this.btnEspacos.Location = new System.Drawing.Point(22, 96);
            this.btnEspacos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEspacos.Name = "btnEspacos";
            this.btnEspacos.Size = new System.Drawing.Size(152, 25);
            this.btnEspacos.TabIndex = 0;
            this.btnEspacos.Text = "Qtd de Espaços";
            this.btnEspacos.UseVisualStyleBackColor = true;
            this.btnEspacos.Click += new System.EventHandler(this.btnEspacos_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(22, 150);
            this.txtFrase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(512, 167);
            this.txtFrase.TabIndex = 1;
            this.txtFrase.Text = "";
            this.txtFrase.Validated += new System.EventHandler(this.txtFrase_Validated);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(204, 96);
            this.btnR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(152, 25);
            this.btnR.TabIndex = 2;
            this.btnR.Text = "Qtd de R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(382, 96);
            this.btnPar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(152, 25);
            this.btnPar.TabIndex = 3;
            this.btnPar.Text = "Qtd Par de Letras";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // lblExercicio1
            // 
            this.lblExercicio1.AutoSize = true;
            this.lblExercicio1.Location = new System.Drawing.Point(18, 32);
            this.lblExercicio1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExercicio1.Name = "lblExercicio1";
            this.lblExercicio1.Size = new System.Drawing.Size(516, 20);
            this.lblExercicio1.TabIndex = 4;
            this.lblExercicio1.Text = "Digite uma frase ou texto, respoderei de acordo com cada botão abaixo:";
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(574, 369);
            this.Controls.Add(this.lblExercicio1);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnEspacos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExercicio1";
            this.Text = "Exercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspacos;
        private System.Windows.Forms.RichTextBox txtFrase;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Label lblExercicio1;
    }
}