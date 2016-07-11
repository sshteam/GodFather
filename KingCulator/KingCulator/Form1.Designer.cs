namespace KingCulator
{
    partial class Form1
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
            this.summa = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.umnozenie = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.arctg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(149, 12);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(75, 23);
            this.summa.TabIndex = 0;
            this.summa.Text = "+";
            this.summa.UseVisualStyleBackColor = true;
            this.summa.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(149, 47);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // umnozenie
            // 
            this.umnozenie.Location = new System.Drawing.Point(149, 88);
            this.umnozenie.Name = "umnozenie";
            this.umnozenie.Size = new System.Drawing.Size(75, 23);
            this.umnozenie.TabIndex = 2;
            this.umnozenie.Text = "*";
            this.umnozenie.UseVisualStyleBackColor = true;
            this.umnozenie.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // delenie
            // 
            this.delenie.Location = new System.Drawing.Point(149, 126);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(75, 23);
            this.delenie.TabIndex = 3;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = true;
            this.delenie.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(149, 231);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(149, 260);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(149, 289);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 9;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(149, 318);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 10;
            this.arctg.Text = "arctg";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 446);
            this.Controls.Add(this.arctg);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delenie);
            this.Controls.Add(this.umnozenie);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.summa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summa;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button umnozenie;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button arctg;
    }
}

