namespace UsuariosRegistro.UI.Registros
{
    partial class rFibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // NumeroTextBox1
            // 
            this.NumeroTextBox1.Location = new System.Drawing.Point(97, 75);
            this.NumeroTextBox1.Name = "NumeroTextBox1";
            this.NumeroTextBox1.Size = new System.Drawing.Size(126, 20);
            this.NumeroTextBox1.TabIndex = 2;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(123, 242);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 3;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(97, 127);
            this.ResultadotextBox.Multiline = true;
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(126, 55);
            this.ResultadotextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // rFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.NumeroTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "rFibonacci";
            this.Text = "rFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox NumeroTextBox1;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Label label2;
    }
}