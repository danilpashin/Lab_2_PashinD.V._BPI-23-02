using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcC:CalcMain
    {
        private double a = 0.0f;
        private double b = 0.0f;
        private double c = 0.0f;
        private double d = -1.0f;
        private static List<double> cValues = new List<double> { 0, 1 };
        private static List<double> dValues = new List<double> { -1, 0, 1 };
        private static string path = "pack://application:,,,/Resources/p3.png";
        private bool res = true;

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public static List<double> CValues { get { return cValues; } set { } }
        public static List<double> DValues { get { return dValues; } set { } }
        public static string Path { get { return path; } set { } }

        public CalcC(string A, string B, string C, string D)
        {
            if (double.TryParse(A, out a) && double.TryParse(B, out b) && double.TryParse(C, out c) && double.TryParse(D, out d))
            {
                res = true;
            }
            else res = false;
        }

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(c * a * a + d * b * b);
            }
            else
            {
                return "ошибка в параметрах";
            }

        }
    }
}
