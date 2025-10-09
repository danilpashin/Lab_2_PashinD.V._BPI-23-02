using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcD : CalcMain, INotifyPropertyChanged
    {
        private string a = String.Empty;
        private string d = String.Empty;
        private double c;
        private static ObservableCollection<double> cValues = new ObservableCollection<double> { 0, 1, 2, 3, 4, 5 };
        private static string path = "pack://application:,,,/Resources/p4.png";
        private bool res = true;

        public string A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged(nameof(A));
            }
        }
        public string D
        {
            get { return d; }
            set
            {
                d = value;
                OnPropertyChanged(nameof(D));
            }
        }
        public double C
        {
            get => c;
            set
            {
                c = value;
                OnPropertyChanged(nameof(C));
            }
        }
        public ObservableCollection<double> CValues => cValues;
        public static string Path { get { return path; } set { } }

        public CalcD() {}

        public override string Solve()
        {
            if (res)
            {
                double ans = 1;
                for (int i = 0; i < Convert.ToDouble(D); i++)
                {
                    ans = (ans * (C + Convert.ToDouble(A)) + 1);
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
