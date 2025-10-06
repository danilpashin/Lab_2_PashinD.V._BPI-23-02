using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcB:CalcMain
    {
        private double a = 0.0f;
        private double b = 0.0f;
        private double f = 10f;
        private static string path = "Resources/p2.png";
        private bool res = true;

        public double A { get; set; }
        public double B { get; set; }
        public double F { get; set; }
        public static string Path { get { return path; } set { } }

        public CalcB(string A, string B, double F)
        {
            if (double.TryParse(A, out a) && double.TryParse(B, out b))
            {
                f = F;
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
