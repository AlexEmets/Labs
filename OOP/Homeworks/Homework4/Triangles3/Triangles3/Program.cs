using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle1
{
    internal abstract class Triangle
    {
        internal double Side1;
        internal double Side2;
        internal double Angle;
        internal Triangle(double _side1, double _side2, double _angle)
        {
            Side1 = _side1;
            Side2 = _side2;
            Angle = _angle;
        }
        internal abstract double Perimeter();
        //return Side1 + Side2 + Math.Sqrt(Side1*Side1+Side2*Side2-2*Side1*Side1*Math.Cos(Angle)*180/Math.PI);
        internal abstract double Square();
        //return 0.5*Side1*Side2*Math.Sin(Angle)*180/Math.PI;
    }

    internal class RightTriangle : Triangle
    {
        internal RightTriangle(double _side1, double _side2, double _angle) : base(_side1, _side2, _angle) { }
        internal override double Perimeter()
        {
            return Side1 + Side2 + Math.Sqrt(Side1 * Side1 + Side2 * Side2);
        }
        internal override double Square()
        {
            return 0.5 * Side1 * Side2;
        }
    }
    internal class IsoscelesTriangle : Triangle
    {
        internal IsoscelesTriangle(double _side1, double _side2, double _angle) : base(_side1, _side2, _angle) { }
        internal override double Perimeter()
        {
            return 2 * Side1 + Math.Sqrt(Side1 * Side1 + Side1 * Side1 - 2 * Side1 * Side1 * Math.Cos(Angle / 180 * Math.PI));
        }
        internal override double Square()
        {
            return 0.5 * Side1 * Side1 * Math.Sin(Angle / 180 * Math.PI);
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
