using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcA : CalcMain, INotifyPropertyChanged
    {
        private string a = String.Empty;
        private double f;
        private static ObservableCollection<double> fValues = new ObservableCollection<double> { 4, 5, 6, 7, 8, 9 };
        private static string path = "pack://application:,,,/Resources/p1.png";
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


        public CalcA() {}

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(Math.Sin((Convert.ToDouble(A) * F)));
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
