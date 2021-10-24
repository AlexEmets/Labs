using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public double square;
        public double a, b, c;
        Triangle triangle;
        EquilTriangle equil;
        bool triangle_check = false;
        bool equil_check = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TriangleInfo_Click(object sender, EventArgs e)
        {

        }

        private void aInfo_Click(object sender, EventArgs e)
        {

        }

        private void bInfo_Click(object sender, EventArgs e)
        {

        }

        private void cInfo_Click(object sender, EventArgs e)
        {

        }

        private void aField_TextChanged(object sender, EventArgs e)
        {

        }

        private void bField_TextChanged(object sender, EventArgs e)
        {

        }

        private void cField_TextChanged(object sender, EventArgs e)
        {

        }
        private void CreateTriangle_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(aField.Text);
            b = Convert.ToDouble(bField.Text);
            c = Convert.ToDouble(cField.Text);
            if (a + b >= c && b + c >= a && a + c >= b)
            {
                triangle = new Triangle(a, b, c);
                TriangleInfo.Text = "Triangle created";
                triangle_check = true;
                equil_check = false;
            }
        }

        private void sideToChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void valueToChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (triangle_check == true)
            {
                triangle.ChangeSide(sideToChange.Text, Convert.ToDouble(valueToChange.Text));
                ChangeInfo.Text = "Side changed";
            }
            else if (equil_check == true)
            {
                equil.ChangeSide(sideToChange.Text, Convert.ToDouble(valueToChange.Text));
                ChangeInfo.Text = "Side changed";
            }
        }

        private void sideInfo_Click(object sender, EventArgs e)
        {

        }

        private void valueInfo_Click(object sender, EventArgs e)
        {

        }

        private void EquilTriangleInfo_Click(object sender, EventArgs e)
        {

        }

        private void EquilSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void equilSideInfo_Click(object sender, EventArgs e)
        {

        }

        private void Perimeter_Click(object sender, EventArgs e)
        {
            if(triangle_check == true)
                PerimeterResult.Text = Convert.ToString(triangle.Side_a + triangle.Side_b + triangle.Side_c);

            else if(equil_check == true)
                PerimeterResult.Text = Convert.ToString(equil.Side_a + equil.Side_b + equil.Side_c);
        }

        private void Angle_Click(object sender, EventArgs e)
        {
            if (triangle_check == true)
                ResultAngle.Text = Convert.ToString(Math.Abs(Math.Round(triangle.CalculateAngle(AngleName.Text) * 180 / Math.PI, 3)));
            else if (equil_check == true)
                ResultAngle.Text = Convert.ToString(Math.Abs(Math.Round(equil.CalculateAngle(AngleName.Text) * 180 / Math.PI, 3)));
        }

        private void AngleName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void angleNameInfo_Click(object sender, EventArgs e)
        {

        }

        private void PerimeterResult_Click(object sender, EventArgs e)
        {

        }

        private void ResultAngle_Click(object sender, EventArgs e)
        {

        }

        private void CreateEquil_Click(object sender, EventArgs e)
        {
            equil = new EquilTriangle(Convert.ToDouble(EquilSide.Text));
            EquilTriangleInfo.Text = "Equil triangle created";
            equil_check = true;
            triangle_check = false;
        }

        private void CalculateSquare_Click(object sender, EventArgs e)
        {
            ResultSquare.Text = Convert.ToString(Math.Abs(Math.Round(equil.CalculateSquare(), 3)));
        }

        private void ResultSquare_Click(object sender, EventArgs e)
        {

        }
    }
}
