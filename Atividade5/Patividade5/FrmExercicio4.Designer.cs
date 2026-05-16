namespace Patividade5
{
    partial class FrmExercicio4
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
            this.lblEx4Prod = new System.Windows.Forms.Label();
            this.lblEx4Sal = new System.Windows.Forms.Label();
            this.lblEx4Grat = new System.Windows.Forms.Label();
            this.lblEx4SalBruto = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtGrat = new System.Windows.Forms.TextBox();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.grpbxDados = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEx4Mat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEx4Name = new System.Windows.Forms.Label();
            this.btnEx4SalBruto = new System.Windows.Forms.Button();
            this.grpbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEx4Prod
            // 
            this.lblEx4Prod.AutoSize = true;
            this.lblEx4Prod.Location = new System.Drawing.Point(25, 230);
            this.lblEx4Prod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4Prod.Name = "lblEx4Prod";
            this.lblEx4Prod.Size = new System.Drawing.Size(77, 20);
            this.lblEx4Prod.TabIndex = 2;
            this.lblEx4Prod.Text = "Produção";
            // 
            // lblEx4Sal
            // 
            this.lblEx4Sal.AutoSize = true;
            this.lblEx4Sal.Location = new System.Drawing.Point(25, 370);
            this.lblEx4Sal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4Sal.Name = "lblEx4Sal";
            this.lblEx4Sal.Size = new System.Drawing.Size(58, 20);
            this.lblEx4Sal.TabIndex = 3;
            this.lblEx4Sal.Text = "Salário";
            // 
            // lblEx4Grat
            // 
            this.lblEx4Grat.AutoSize = true;
            this.lblEx4Grat.Location = new System.Drawing.Point(25, 307);
            this.lblEx4Grat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4Grat.Name = "lblEx4Grat";
            this.lblEx4Grat.Size = new System.Drawing.Size(95, 20);
            this.lblEx4Grat.TabIndex = 4;
            this.lblEx4Grat.Text = "Gratificação";
            // 
            // lblEx4SalBruto
            // 
            this.lblEx4SalBruto.AutoSize = true;
            this.lblEx4SalBruto.Location = new System.Drawing.Point(25, 453);
            this.lblEx4SalBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4SalBruto.Name = "lblEx4SalBruto";
            this.lblEx4SalBruto.Size = new System.Drawing.Size(101, 20);
            this.lblEx4SalBruto.TabIndex = 5;
            this.lblEx4SalBruto.Text = "Salário Bruto";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(130, 219);
            this.txtProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(148, 26);
            this.txtProd.TabIndex = 3;
            this.txtProd.Validated += new System.EventHandler(this.txtProd_Validated);
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(130, 364);
            this.txtSal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(148, 26);
            this.txtSal.TabIndex = 4;
            this.txtSal.Validated += new System.EventHandler(this.txtSal_Validated);
            // 
            // txtGrat
            // 
            this.txtGrat.Location = new System.Drawing.Point(130, 302);
            this.txtGrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrat.Name = "txtGrat";
            this.txtGrat.Size = new System.Drawing.Size(148, 26);
            this.txtGrat.TabIndex = 5;
            this.txtGrat.Validated += new System.EventHandler(this.txtGrat_Validated);
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Enabled = false;
            this.txtSalBruto.Location = new System.Drawing.Point(130, 447);
            this.txtSalBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.ReadOnly = true;
            this.txtSalBruto.Size = new System.Drawing.Size(148, 26);
            this.txtSalBruto.TabIndex = 11;
            // 
            // grpbxDados
            // 
            this.grpbxDados.Controls.Add(this.textBox2);
            this.grpbxDados.Controls.Add(this.lblEx4Mat);
            this.grpbxDados.Controls.Add(this.textBox1);
            this.grpbxDados.Controls.Add(this.lblEx4Name);
            this.grpbxDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDados.Location = new System.Drawing.Point(13, 14);
            this.grpbxDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxDados.Name = "grpbxDados";
            this.grpbxDados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbxDados.Size = new System.Drawing.Size(314, 180);
            this.grpbxDados.TabIndex = 0;
            this.grpbxDados.TabStop = false;
            this.grpbxDados.Text = "Dados Colaborador";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 123);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // lblEx4Mat
            // 
            this.lblEx4Mat.AutoSize = true;
            this.lblEx4Mat.Location = new System.Drawing.Point(9, 126);
            this.lblEx4Mat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4Mat.Name = "lblEx4Mat";
            this.lblEx4Mat.Size = new System.Drawing.Size(87, 20);
            this.lblEx4Mat.TabIndex = 9;
            this.lblEx4Mat.Text = "Matrícula";
            this.lblEx4Mat.Click += new System.EventHandler(this.lblEx4Mat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // lblEx4Name
            // 
            this.lblEx4Name.AutoSize = true;
            this.lblEx4Name.Location = new System.Drawing.Point(9, 65);
            this.lblEx4Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEx4Name.Name = "lblEx4Name";
            this.lblEx4Name.Size = new System.Drawing.Size(57, 20);
            this.lblEx4Name.TabIndex = 7;
            this.lblEx4Name.Text = "Nome";
            // 
            // btnEx4SalBruto
            // 
            this.btnEx4SalBruto.Location = new System.Drawing.Point(302, 447);
            this.btnEx4SalBruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEx4SalBruto.Name = "btnEx4SalBruto";
            this.btnEx4SalBruto.Size = new System.Drawing.Size(187, 26);
            this.btnEx4SalBruto.TabIndex = 13;
            this.btnEx4SalBruto.Text = "Calcular Salário Bruto";
            this.btnEx4SalBruto.UseVisualStyleBackColor = true;
            this.btnEx4SalBruto.Click += new System.EventHandler(this.btnEx4SalBruto_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 521);
            this.Controls.Add(this.btnEx4SalBruto);
            this.Controls.Add(this.grpbxDados);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.txtGrat);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.lblEx4SalBruto);
            this.Controls.Add(this.lblEx4Grat);
            this.Controls.Add(this.lblEx4Sal);
            this.Controls.Add(this.lblEx4Prod);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExercicio4";
            this.Text = "Calcula Salário Bruto";
            this.grpbxDados.ResumeLayout(false);
            this.grpbxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEx4Prod;
        private System.Windows.Forms.Label lblEx4Sal;
        private System.Windows.Forms.Label lblEx4Grat;
        private System.Windows.Forms.Label lblEx4SalBruto;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtGrat;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.GroupBox grpbxDados;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEx4Mat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEx4Name;
        private System.Windows.Forms.Button btnEx4SalBruto;
    }
}