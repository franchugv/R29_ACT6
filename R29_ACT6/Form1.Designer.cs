namespace R29_ACT6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonEvaluar = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxEntrada2 = new System.Windows.Forms.TextBox();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonEvaluar
            // 
            this.BotonEvaluar.Location = new System.Drawing.Point(180, 53);
            this.BotonEvaluar.Name = "BotonEvaluar";
            this.BotonEvaluar.Size = new System.Drawing.Size(75, 23);
            this.BotonEvaluar.TabIndex = 0;
            this.BotonEvaluar.Text = "Evaluar";
            this.BotonEvaluar.UseVisualStyleBackColor = true;
            this.BotonEvaluar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(21, 37);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Número:";
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(74, 37);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntrada.TabIndex = 2;
            this.textBoxEntrada.Leave += new System.EventHandler(this.TextBox_Validacion_Leave);
            // 
            // textBoxEntrada2
            // 
            this.textBoxEntrada2.Location = new System.Drawing.Point(74, 63);
            this.textBoxEntrada2.Name = "textBoxEntrada2";
            this.textBoxEntrada2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntrada2.TabIndex = 5;
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Location = new System.Drawing.Point(21, 63);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(56, 13);
            this.labelNumero2.TabIndex = 4;
            this.labelNumero2.Text = "Número 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 114);
            this.Controls.Add(this.textBoxEntrada2);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.BotonEvaluar);
            this.Name = "Form1";
            this.Text = "Evaluar Números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonEvaluar;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxEntrada2;
        private System.Windows.Forms.Label labelNumero2;
    }
}

