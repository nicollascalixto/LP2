namespace Patividade5
{
    partial class FrmExercicio3
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
            this.lblEx3 = new System.Windows.Forms.Label();
            this.txtEx3 = new System.Windows.Forms.TextBox();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.lblEx3_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEx3
            // 
            this.lblEx3.AutoSize = true;
            this.lblEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx3.Location = new System.Drawing.Point(13, 32);
            this.lblEx3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx3.Name = "lblEx3";
            this.lblEx3.Size = new System.Drawing.Size(515, 29);
            this.lblEx3.TabIndex = 0;
            this.lblEx3.Text = "Digite uma palavra ou frase (até 50 caracteres):";
            // 
            // txtEx3
            // 
            this.txtEx3.Location = new System.Drawing.Point(18, 84);
            this.txtEx3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEx3.MaxLength = 50;
            this.txtEx3.Name = "txtEx3";
            this.txtEx3.Size = new System.Drawing.Size(408, 26);
            this.txtEx3.TabIndex = 1;
            this.txtEx3.Validated += new System.EventHandler(this.txtEx3_Validated);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(454, 84);
            this.btnEx3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(158, 26);
            this.btnEx3.TabIndex = 2;
            this.btnEx3.Text = "Checa Palíndromo";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx3_Click);
            // 
            // lblEx3_2
            // 
            this.lblEx3_2.Location = new System.Drawing.Point(101, 149);
            this.lblEx3_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx3_2.Name = "lblEx3_2";
            this.lblEx3_2.Size = new System.Drawing.Size(438, 77);
            this.lblEx3_2.TabIndex = 3;
            this.lblEx3_2.Text = "Um “palíndromo” é uma sequência de caracteres cuja leitura é idêntica se feita da" +
    " esquerda";
            this.lblEx3_2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 301);
            this.Controls.Add(this.lblEx3_2);
            this.Controls.Add(this.btnEx3);
            this.Controls.Add(this.txtEx3);
            this.Controls.Add(this.lblEx3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExercicio3";
            this.Text = "Testa Palíndromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEx3;
        private System.Windows.Forms.TextBox txtEx3;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.Label lblEx3_2;
    }
}