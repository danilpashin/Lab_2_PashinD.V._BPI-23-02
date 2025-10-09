using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcE : CalcMain, INotifyPropertyChanged
    {
        private string p;
        private string y;
        private string n;
        private string k;
        private static string path = "pack://application:,,,/Resources/p5.png";
        private bool res = true;

        public string P
        {
            get { return p; }
            set
            {
                p = value;
                OnPropertyChanged(nameof(P));
            }
        }
        public string Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged(nameof(Y));
            }
        }
        public string N
        {
            get { return n; }
            set
            {
                n = value;
                OnPropertyChanged(nameof(N));
            }
        }
        public string K
        {
            get { return k; }
            set
            {
                k = value;
                OnPropertyChanged(nameof(K));
            }
        }
        public static string Path { get { return path; } set { } }

        public CalcE() {}

        public override string Solve()
        {

            if (res && Convert.ToInt32(N) > 0 && Convert.ToInt32(K) > 0)
            {
                double ans = 0;
                double resInner = 0;
                for (int i = 1; i <= Convert.ToInt32(N); i++)
                {
                    for (int j = 1; j <= Convert.ToInt32(K); j++)
                    {
                        resInner = Math.Pow(Convert.ToDouble(P), i) * Math.Pow(Convert.ToDouble(Y), j) / (i * j);
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
