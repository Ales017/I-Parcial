namespace IParcial
{
    partial class Ejercicio1
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
            this.Numero1Label = new System.Windows.Forms.Label();
            this.Numero2Label = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero1Label
            // 
            this.Numero1Label.AutoSize = true;
            this.Numero1Label.Location = new System.Drawing.Point(109, 75);
            this.Numero1Label.Name = "Numero1Label";
            this.Numero1Label.Size = new System.Drawing.Size(68, 16);
            this.Numero1Label.TabIndex = 0;
            this.Numero1Label.Text = "Numero 1:";
            // 
            // Numero2Label
            // 
            this.Numero2Label.AutoSize = true;
            this.Numero2Label.Location = new System.Drawing.Point(109, 129);
            this.Numero2Label.Name = "Numero2Label";
            this.Numero2Label.Size = new System.Drawing.Size(68, 16);
            this.Numero2Label.TabIndex = 1;
            this.Numero2Label.Text = "Numero 2:";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(194, 72);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(181, 22);
            this.Numero1textBox.TabIndex = 2;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(194, 126);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(181, 22);
            this.Numero2textBox.TabIndex = 3;
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(206, 191);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(145, 46);
            this.Sumarbutton.TabIndex = 4;
            this.Sumarbutton.Text = "Sumar";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(474, 104);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(69, 16);
            this.Resultadolabel.TabIndex = 5;
            this.Resultadolabel.Text = "Resultado";
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Numero2Label);
            this.Controls.Add(this.Numero1Label);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1Label;
        private System.Windows.Forms.Label Numero2Label;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button Sumarbutton;
        private System.Windows.Forms.Label Resultadolabel;
    }
}

