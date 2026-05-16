namespace Patividade5
{
    partial class FrmExercicio2
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
            this.lblEx2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.lblEx2_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEx2
            // 
            this.lblEx2.AutoSize = true;
            this.lblEx2.Location = new System.Drawing.Point(18, 71);
            this.lblEx2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx2.Name = "lblEx2";
            this.lblEx2.Size = new System.Drawing.Size(90, 20);
            this.lblEx2.TabIndex = 0;
            this.lblEx2.Text = "Numero (N)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(317, 62);
            this.btnEx2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(112, 35);
            this.btnEx2.TabIndex = 2;
            this.btnEx2.Text = "Calcular H";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx2_Click);
            // 
            // lblEx2_2
            // 
            this.lblEx2_2.AutoSize = true;
            this.lblEx2_2.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblEx2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx2_2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEx2_2.Location = new System.Drawing.Point(149, 133);
            this.lblEx2_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx2_2.Name = "lblEx2_2";
            this.lblEx2_2.Size = new System.Drawing.Size(264, 20);
            this.lblEx2_2.TabIndex = 3;
            this.lblEx2_2.Text = "H=1+1/2 +1/3+1/4+1/5+...+1/N";
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 208);
            this.Controls.Add(this.lblEx2_2);
            this.Controls.Add(this.btnEx2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEx2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExercicio2";
            this.Text = "Calcular H";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEx2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Label lblEx2_2;
    }
}