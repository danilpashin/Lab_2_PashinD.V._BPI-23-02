using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcB : CalcMain
    {
        private double a = 0.0f;
        private double b = 0.0f;
        private double f = 10f;
        private static List<double> fValues = new List<double> { 10, 20, 30, 40 };
        private static string path = "pack://application:,,,/Resources/p2.png";
        private bool res = true;

        public double A { get; set; }
        public double B { get; set; }
        public double F { get; set; }
        public static List<double> FValues { get { return fValues; } set { } }
        public static string Path { get { return path; } set { } }

        public CalcB(string A, string B, string F)

        {
            if (double.TryParse(A, out a) && double.TryParse(B, out b) && double.TryParse(F, out f))
            {
                res = true;
            }
            else res = false;
        }

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(Math.Cos(f * a) + Math.Sin(f * b));
            }
            else
            {
                return "ошибка в параметрах";
            }

        }
    }
}
