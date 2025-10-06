using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcE:CalcMain
    {
        private double p = 0.0f;
        private double y = 0.0f;
        private int n = 1;
        private int k = 1;
        private static string path = "Resources/p5.png";
        private bool res = true;

        public double P { get; set; }
        public double Y { get; set; }
        public double N { get; set; }
        public double K { get; set; }
        public static string Path { get { return path; } set { } }

        public CalcE(string P, string Y, string N, string K)
        {
            if (double.TryParse(P, out p) && double.TryParse(Y, out y) && int.TryParse(N, out n) && int.TryParse(K, out k))
            {
                res = true;
            }
            else res = false;
        }

        public override string Solve()
        {
            if (res && n > 0 && k > 0)
            {
                double ans = 0;
                double resInner = 0;
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        resInner = Math.Pow(p, i) * Math.Pow(y, j) / (i * j);
                    }
                    ans = ans + resInner;
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
