using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcE : CalcMain, INotifyPropertyChanged, IDataErrorInfo
    {
        private string p;
        private string y;
        private string n;
        private string k;
        private static string path = "pack://application:,,,/Resources/p5.png";
        private bool res = true;

        public string P
        {
            get => p;
            set
            {
                p = value;
                OnPropertyChanged(nameof(P));
            }
        }
        public string Y
        {
            get => y;
            set
            {
                y = value;
                OnPropertyChanged(nameof(Y));
            }
        }
        public string N
        {
            get => n;
            set
            {
                n = value;
                OnPropertyChanged(nameof(N));
            }
        }
        public string K
        {
            get => k;
            set
            {
                k = value;
                OnPropertyChanged(nameof(K));
            }
        }
        public static string Path { get => path; set { } }

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

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                double num;
                if (!double.TryParse(N, out num))
                {
                    error = "Некорректный ввод";
                }
                else if (Convert.ToDouble(N) < 1)
                {
                    MessageBox.Show("N должно быть больше нуля!");
                    error = "N меньше 1";
                }

                if (!double.TryParse(K, out num))
                {
                    error = "Некорректный ввод";
                }
                else if (Convert.ToDouble(K) < 1)
                {
                    MessageBox.Show("K должно быть больше нуля!");
                    error = "K меньше 1";
                }

                if (!double.TryParse(P, out num))
                {
                    error = "Некорректный ввод";
                }

                if (!double.TryParse(Y, out num))
                {
                    error = "Некорректный ввод";
                }

                if (error != String.Empty)
                {
                    res = false;
                    error = String.Empty;
                }
                else res = true;

                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
