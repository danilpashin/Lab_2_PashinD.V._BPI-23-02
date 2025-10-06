using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcA:CalcMain, INotifyPropertyChanged
    {
        private double a;
        private double f;
        private static List<double> fValues = new List<double> { 4, 5, 6, 7, 8, 9 };
        private static string path = "pack://application:,,,/Resources/p1.png";
        private bool res = true;

        public double A
        {
            get { return a; }
            set
            {
                a = value;
                OnPropertyChanged("AText");
            }
        }
        public double F 
        { 
            get { return f; } 
            set 
            { 
                f = value;
                OnPropertyChanged("FText");
            } 
        }
        public static List<double> FValues { get { return fValues;  } set { } }
        public static string Path { get { return path; } set { } }

        public CalcA(string A, string F)
        {
            if (double.TryParse(A, out a) && double.TryParse(F, out f))
            {
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

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
