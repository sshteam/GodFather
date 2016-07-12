using System;
using System.Windows.Forms;
using KingCulator.OneArgument;
using KingCulator.TwoArgument;

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
            ITwoArgumentCalculater calculater = TwoArgumentFactory.CreateCalculater(((Button) sender).Name);
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
