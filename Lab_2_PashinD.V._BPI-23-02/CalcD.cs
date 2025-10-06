using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcD:CalcMain
    {
        private double a = 0.0f;
        private double c = 0.0f;
        private double d = 0.0f;
        private static List<double> cValues = new List<double> { 0, 1, 2, 3, 4, 5 };
        private static string path = "pack://application:,,,/Resources/p4.png";
        private bool res = true;

        public double A { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public static List<double> CValues { get { return cValues; } set { } }
        public static string Path { get { return path; } set { } }

        public CalcD(string A, string D, string C)
        {
            if (double.TryParse(A, out a) && double.TryParse(D, out d) && double.TryParse(C, out c))
            {
                res = true;
            }
            else res = false;
        }

        public override string Solve()
        {
            if (res)
            {
                double ans = 1;
                for (int i = 0; i < d; i++)
                {
                    ans = ans * (c + a) + 1;
                }
                return Convert.ToString(ans);
            }
            else
            {
                return "ошибка в параметрах";
            }

        }
    }
}
