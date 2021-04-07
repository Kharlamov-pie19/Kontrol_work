using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            label4.Text = "Сложение: " + x.ToString() + " и " + y.ToString();
            double S = x + y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            label4.Text = "Вычитание: " + x.ToString() + " и " + y.ToString();
            double S = x - y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            label4.Text = "Умножение: " + x.ToString() + " и " + y.ToString();
            double S = x * y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            label4.Text = "Деление: " + x.ToString() + " и " + y.ToString();
            double S = x / y;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label4.Text = "Кв. корень из " + x.ToString();
            double S = Math.Sqrt(x);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = S.ToString();

        }
    }
}
