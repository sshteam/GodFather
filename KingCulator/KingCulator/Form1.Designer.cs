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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.arccos = new System.Windows.Forms.Button();
            this.arcsin = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
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
            this.textBox2.Location = new System.Drawing.Point(531, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(637, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(230, 12);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(75, 23);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(230, 47);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(75, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(230, 88);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(75, 23);
            this.tg.TabIndex = 9;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arctg
            // 
            this.arctg.Location = new System.Drawing.Point(230, 126);
            this.arctg.Name = "arctg";
            this.arctg.Size = new System.Drawing.Size(75, 23);
            this.arctg.TabIndex = 10;
            this.arctg.Text = "arctg";
            this.arctg.UseVisualStyleBackColor = true;
            this.arctg.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ответ";
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(311, 12);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 23);
            this.power.TabIndex = 14;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(311, 47);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 15;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.TwoArgumentsButtonClick);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(311, 88);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(75, 23);
            this.ln.TabIndex = 16;
            this.ln.Text = "lg";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(311, 126);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 23);
            this.sqrt.TabIndex = 17;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arccos
            // 
            this.arccos.Location = new System.Drawing.Point(392, 12);
            this.arccos.Name = "arccos";
            this.arccos.Size = new System.Drawing.Size(75, 23);
            this.arccos.TabIndex = 18;
            this.arccos.Text = "arccos";
            this.arccos.UseVisualStyleBackColor = true;
            this.arccos.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // arcsin
            // 
            this.arcsin.Location = new System.Drawing.Point(392, 47);
            this.arcsin.Name = "arcsin";
            this.arcsin.Size = new System.Drawing.Size(75, 23);
            this.arcsin.TabIndex = 19;
            this.arcsin.Text = "arcsin";
            this.arcsin.UseVisualStyleBackColor = true;
            this.arcsin.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(392, 88);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(75, 23);
            this.factorial.TabIndex = 20;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(392, 126);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 21;
            this.exp.Text = "e";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OneArgumentButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 446);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.arcsin);
            this.Controls.Add(this.arccos);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.log);
            this.Controls.Add(this.power);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button arccos;
        private System.Windows.Forms.Button arcsin;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button exp;
    }
}

