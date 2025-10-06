using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcA:CalcMain
    {
        private double a = 0.0f;
        private double f = 10f;
        private static string path = "Resources/p1.png";
        private bool res = true;

        public double A { get; set; }
        public double F { get; set; }
        public static string Path { get { return path; } set { } }

        public CalcA(string A, double F)
        {
            if (double.TryParse(A, out a))
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
                return Convert.ToString(Math.Sin(f * a));
            }
            else
            {
                return "ошибка в параметрах";
            }
            
        }
    }
}
