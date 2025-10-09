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
    public class CalcB : CalcMain, INotifyPropertyChanged
    {
        private string a = String.Empty;
        private string b = String.Empty;
        private double f;
        private static ObservableCollection<double> fValues = new ObservableCollection<double> { 10, 20, 30, 40 };
        private static string path = "pack://application:,,,/Resources/p2.png";
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
        public string B
        {
            get { return b; }
            set
            {
                b = value;
                OnPropertyChanged(nameof(B));
            }
        }
        public double F
        {
            get => f;
            set
            {
                f = value;
                OnPropertyChanged(nameof(F));
            }
        }
        public ObservableCollection<double> FValues => fValues;
        public static string Path { get { return path; } set { } }

        public CalcB() {}

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(Math.Cos(F * Convert.ToDouble(A)) + Math.Sin(F * Convert.ToDouble(B)));
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
