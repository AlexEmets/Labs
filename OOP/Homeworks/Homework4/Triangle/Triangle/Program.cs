using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    class Triangle
    {
        internal double Side_a;
        internal double Side_b;
        internal double Side_c;
        internal Triangle(double Side_a_, double Side_b_, double Side_c_)
        {
            Side_a = Side_a_;
            Side_b = Side_b_;
            Side_c = Side_c_;
        }
        internal Triangle(double Side_)
        {
            Side_a = Side_;
            Side_b = Side_;
            Side_c = Side_;
        }
        internal virtual void ChangeSide(string side, double new_value)
        {
            switch(side)
            {
                case "a": 
                    Side_a = new_value;
                    break;
                case "b":
                    Side_b = new_value;
                    break;
                case "c":
                    Side_c = new_value;
                    break;
                default:
                    Console.WriteLine("Error: incorrect input");
                    break;
            }
        }
        internal double CalculatePerimeter()
        {
            return (Side_a + Side_b + Side_c);
        }
        internal double CalculateAngle(string angle)
        {
            switch(angle)
            {
                case "A":
                    return Math.Acos((Math.Pow(Side_b, 2) + Math.Pow(Side_c, 2) - Math.Pow(Side_a, 2)) / (2 * Side_b * Side_c));
                case "B":
                    return Math.Acos((Math.Pow(Side_a, 2) + Math.Pow(Side_c, 2) - Math.Pow(Side_b, 2)) / (2 * Side_a * Side_c));
                case "C":
                    return Math.Acos((Math.Pow(Side_a, 2) + Math.Pow(Side_b, 2) - Math.Pow(Side_c, 2)) / (2 * Side_a * Side_b));
                default:
                    Console.WriteLine("Error: Unknown input");
                    return -1;
            }
        } 
    }
    class EquilTriangle : Triangle
    {
        internal double Square;
        internal EquilTriangle(double Side_) : base(Side_)
        { }
        internal override void ChangeSide(string side, double new_value)
        {
            switch (side)
            {
                case "a":
                    Side_a = new_value;
                    Side_b = new_value;
                    Side_c = new_value;
                    break;
                case "b":
                    Side_a = new_value;
                    Side_b = new_value;
                    Side_c = new_value;
                    break;
                case "c":
                    Side_a = new_value;
                    Side_b = new_value;
                    Side_c = new_value;
                    break;
                default:
                    Console.WriteLine("Error: incorrect input");
                    break;
            }
        }
        internal double CalculateSquare()
        {
            double buffer = Math.Sqrt(3) / 4 * Math.Pow(Side_a, 2);
            Square = buffer;
            return buffer;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
