namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblValC = new System.Windows.Forms.Label();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.txtValb = new System.Windows.Forms.TextBox();
            this.txtValc = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(73, 56);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(57, 20);
            this.lblValA.TabIndex = 0;
            this.lblValA.Text = "valor A";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(69, 248);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(61, 20);
            this.lblValB.TabIndex = 1;
            this.lblValB.Text = "Valor B";
            // 
            // lblValC
            // 
            this.lblValC.AutoSize = true;
            this.lblValC.Location = new System.Drawing.Point(73, 430);
            this.lblValC.Name = "lblValC";
            this.lblValC.Size = new System.Drawing.Size(61, 20);
            this.lblValC.TabIndex = 2;
            this.lblValC.Text = "Valor C";
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(160, 56);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(114, 26);
            this.txtValA.TabIndex = 3;
            this.txtValA.Validated += new System.EventHandler(this.txtValA_Validated);
            // 
            // txtValb
            // 
            this.txtValb.Location = new System.Drawing.Point(160, 248);
            this.txtValb.Name = "txtValb";
            this.txtValb.Size = new System.Drawing.Size(114, 26);
            this.txtValb.TabIndex = 4;
            this.txtValb.Validated += new System.EventHandler(this.txtValb_Validated);
            // 
            // txtValc
            // 
            this.txtValc.Location = new System.Drawing.Point(160, 430);
            this.txtValc.Name = "txtValc";
            this.txtValc.Size = new System.Drawing.Size(114, 26);
            this.txtValc.TabIndex = 5;
            this.txtValc.TextChanged += new System.EventHandler(this.txtValc_TextChanged);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(405, 225);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(179, 95);
            this.btnResultado.TabIndex = 6;
            this.btnResultado.Text = "Caulcular";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(658, 225);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(175, 95);
            this.btnLimp.TabIndex = 7;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(1051, 12);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(65, 47);
            this.bntSair.TabIndex = 8;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1138, 592);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtValc);
            this.Controls.Add(this.txtValb);
            this.Controls.Add(this.txtValA);
            this.Controls.Add(this.lblValC);
            this.Controls.Add(this.lblValB);
            this.Controls.Add(this.lblValA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValC;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.TextBox txtValb;
        private System.Windows.Forms.TextBox txtValc;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

