using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double answer;
            switch (((Button)sender).Name)
            {
                case "summa": answer = firstValue + secondValue;
                    break;
                case "minus": answer = firstValue - secondValue;
                    break;
                case "umnozenie": answer = firstValue * secondValue;
                    break;
                case "delenie": answer = firstValue / secondValue;
                    break;
                default:
                    throw new Exception("Неизвестная опереация");
            }
            textBox3.Text = Convert.ToString(answer);
        }
    }
}
