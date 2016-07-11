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

        private void TwoArgumentsButtonClick(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            ITwoArgumentCalculater calculater = TwoArgumentFabric.CreateCalculater(((Button) sender).Name);
            double answer = calculater.Calculate(firstValue, secondValue);
            textBox3.Text = Convert.ToString(answer);
        }
        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            double oneValue = Convert.ToDouble(textBox1.Text);
            IOneArgumentCalculater calculater2 = OneArgumentFactory.CreateCalculater(((Button)sender).Name);
            double triganswer = calculater2.Calculate(oneValue);
            textBox3.Text = Convert.ToString(triganswer);
        }
    }
}
