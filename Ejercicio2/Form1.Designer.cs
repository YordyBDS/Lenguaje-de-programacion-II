namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btncambiartexto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 38);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            label1.Click += label1_Click;
            // 
            // btncambiartexto
            // 
            btncambiartexto.Location = new Point(46, 194);
            btncambiartexto.Name = "btncambiartexto";
            btncambiartexto.Size = new Size(162, 29);
            btncambiartexto.TabIndex = 1;
            btncambiartexto.Text = "Cambiar texto";
            btncambiartexto.UseVisualStyleBackColor = true;
            btncambiartexto.Click += btncambiartexto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncambiartexto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncambiartexto;
    }
}
