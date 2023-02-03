namespace IParcial
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.Numero1label = new System.Windows.Forms.Label();
            this.Numero2label = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.OperacionescomboBox = new System.Windows.Forms.ComboBox();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Resultadolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero1label
            // 
            this.Numero1label.AutoSize = true;
            this.Numero1label.Location = new System.Drawing.Point(141, 72);
            this.Numero1label.Name = "Numero1label";
            this.Numero1label.Size = new System.Drawing.Size(118, 26);
            this.Numero1label.TabIndex = 0;
            this.Numero1label.Text = "Numero 1:";
            // 
            // Numero2label
            // 
            this.Numero2label.AutoSize = true;
            this.Numero2label.Location = new System.Drawing.Point(141, 158);
            this.Numero2label.Name = "Numero2label";
            this.Numero2label.Size = new System.Drawing.Size(118, 26);
            this.Numero2label.TabIndex = 1;
            this.Numero2label.Text = "Numero 2:";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(284, 69);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(191, 34);
            this.Numero1textBox.TabIndex = 2;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(284, 158);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(191, 34);
            this.Numero2textBox.TabIndex = 3;
            // 
            // OperacionescomboBox
            // 
            this.OperacionescomboBox.FormattingEnabled = true;
            this.OperacionescomboBox.Items.AddRange(new object[] {
            "Suma ",
            "Resta",
            "Division",
            "Multiplicacion"});
            this.OperacionescomboBox.Location = new System.Drawing.Point(284, 230);
            this.OperacionescomboBox.Name = "OperacionescomboBox";
            this.OperacionescomboBox.Size = new System.Drawing.Size(191, 34);
            this.OperacionescomboBox.TabIndex = 4;
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(323, 301);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(125, 45);
            this.Ejecutarbutton.TabIndex = 5;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Location = new System.Drawing.Point(566, 241);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(71, 26);
            this.Resultadolabel.TabIndex = 6;
            this.Resultadolabel.Text = "label1";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 410);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.OperacionescomboBox);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.Numero2label);
            this.Controls.Add(this.Numero1label);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1label;
        private System.Windows.Forms.Label Numero2label;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.ComboBox OperacionescomboBox;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Resultadolabel;
    }
}