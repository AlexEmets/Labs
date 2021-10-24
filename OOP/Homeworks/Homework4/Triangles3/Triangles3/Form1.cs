using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle1
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

        private void button1_Click(object sender, EventArgs e)
        {
            RightTriangle rightTriangle = new RightTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), 90);
            label7.Text = Convert.ToString(rightTriangle.Perimeter());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            label9.Text = Convert.ToString(isoscelesTriangle.Perimeter());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RightTriangle rightTriangle = new RightTriangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), 90);
            label8.Text = Convert.ToString(rightTriangle.Square());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            label10.Text = Convert.ToString(isoscelesTriangle.Square());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
