namespace Pvestibular01
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReceberDados = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltsbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReceberDados
            // 
            this.btnReceberDados.Location = new System.Drawing.Point(377, 132);
            this.btnReceberDados.Name = "btnReceberDados";
            this.btnReceberDados.Size = new System.Drawing.Size(216, 87);
            this.btnReceberDados.TabIndex = 0;
            this.btnReceberDados.Text = "Receber Dados";
            this.btnReceberDados.UseVisualStyleBackColor = true;
            this.btnReceberDados.Click += new System.EventHandler(this.btnReceberDados_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(377, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(216, 84);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ltsbxResultado
            // 
            this.ltsbxResultado.FormattingEnabled = true;
            this.ltsbxResultado.ItemHeight = 20;
            this.ltsbxResultado.Location = new System.Drawing.Point(657, 16);
            this.ltsbxResultado.Name = "ltsbxResultado";
            this.ltsbxResultado.Size = new System.Drawing.Size(433, 524);
            this.ltsbxResultado.TabIndex = 2;
            this.ltsbxResultado.SelectedIndexChanged += new System.EventHandler(this.ltsbxResultado_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 618);
            this.Controls.Add(this.ltsbxResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnReceberDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceberDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltsbxResultado;
    }
}

