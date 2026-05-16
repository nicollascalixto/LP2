namespace PAtividade6
{
    partial class frmExercicio5
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
            this.btnCorrigir = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCorrigir
            // 
            this.btnCorrigir.Location = new System.Drawing.Point(491, 233);
            this.btnCorrigir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCorrigir.Name = "btnCorrigir";
            this.btnCorrigir.Size = new System.Drawing.Size(142, 71);
            this.btnCorrigir.TabIndex = 0;
            this.btnCorrigir.Text = "Verificar";
            this.btnCorrigir.UseVisualStyleBackColor = true;
            this.btnCorrigir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 20;
            this.lstResultado.Location = new System.Drawing.Point(12, 13);
            this.lstResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(450, 524);
            this.lstResultado.TabIndex = 1;
            this.lstResultado.SelectedIndexChanged += new System.EventHandler(this.lstResultado_SelectedIndexChanged);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnCorrigir);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.Load += new System.EventHandler(this.frmExercicio5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCorrigir;
        private System.Windows.Forms.ListBox lstResultado;
    }
}