namespace Ptestemetodos
{
    partial class frmExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnContaNum = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(84, 64);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(475, 267);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnContaNum
            // 
            this.btnContaNum.Location = new System.Drawing.Point(578, 64);
            this.btnContaNum.Name = "btnContaNum";
            this.btnContaNum.Size = new System.Drawing.Size(170, 62);
            this.btnContaNum.TabIndex = 1;
            this.btnContaNum.Text = "Conta Números";
            this.btnContaNum.UseVisualStyleBackColor = true;
            this.btnContaNum.Click += new System.EventHandler(this.btnContaNum_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.Location = new System.Drawing.Point(578, 167);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(170, 62);
            this.btnCaracterBranco.TabIndex = 2;
            this.btnCaracterBranco.Text = "Localiza 1º caracter em branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            this.btnCaracterBranco.Click += new System.EventHandler(this.btnCaracterBranco_Click);
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(578, 269);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(170, 62);
            this.btnContaLetras.TabIndex = 3;
            this.btnContaLetras.Text = "Conta Letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnContaNum);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnContaNum;
        private System.Windows.Forms.Button btnCaracterBranco;
        private System.Windows.Forms.Button btnContaLetras;
    }
}