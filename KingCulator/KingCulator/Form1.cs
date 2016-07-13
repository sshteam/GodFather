using System;
using System.Windows.Forms;
using KingCulator.OneArgument;
using KingCulator.Sort;
using KingCulator.TwoArgument;

namespace KingCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoArgumentsButtonClick(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                double secondValue = Convert.ToDouble(textBox2.Text);
                ITwoArgumentCalculater calculater = TwoArgumentFactory.CreateCalculater(((Button) sender).Name);
                double answer = calculater.Calculate(firstValue, secondValue);
                textBox3.Text = Convert.ToString(answer);
            }
            catch (Exception exc)
            {
                MessageBox.Show("произошла ошибка " + exc.Message); // обработка исключения
            }
        }

        private void OneArgumentButtonClick(object sender, EventArgs e)
        {
            try
            {
                double oneValue = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculater calculater2 = OneArgumentFactory.CreateCalculater(((Button) sender).Name);
                double triganswer = calculater2.Calculate(oneValue);
                textBox3.Text = Convert.ToString(triganswer);
            }
            catch (Exception exc)
            {
                MessageBox.Show("произошла ошибка " + exc.Message); // обработка исключения
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = textBox4.Text.Split(' ');
                double[] doubleArray = new double[stringArray.Length];
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    doubleArray[i] = Convert.ToDouble(stringArray[i]);
                }
                ISorter sorter = SortFactory.CreateCalculater(((Button) sender).Name);
                sorter.Sort(doubleArray);
                string resultArray = "";
                for (int i = 0; i < doubleArray.Length; i++)
                {
                    resultArray += " " + doubleArray[i];
                }
                textBox3.Text = resultArray;
            }
            catch (Exception exc)
            {
                MessageBox.Show("произошла ошибка " + exc.Message); // обработка исключения
            }

        }
    }
}
