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
    public class CalcC : CalcMain, INotifyPropertyChanged, IDataErrorInfo
    {
        private string a = String.Empty;
        private string b = String.Empty;
        private double? c;
        private double? d;
        private static ObservableCollection<double> cValues = new ObservableCollection<double> { 0, 1 };
        private static ObservableCollection<double> dValues = new ObservableCollection<double> { -1, 0, 1 };
        private static string path = "pack://application:,,,/Resources/p3.png";
        private bool res = true;

        public string A
        {
            get => a;
            set
            {
                a = value;
                OnPropertyChanged(nameof(A));
            }
        }
        public string B
        {
            get => b;
            set
            {
                b = value;
                OnPropertyChanged(nameof(B));
            }
        }
        
        public ObservableCollection<double> CValues => cValues;
        public double? C
        {
            get => c;
            set
            {
                c = value;
                OnPropertyChanged(nameof(C));
            }
        }
        public ObservableCollection<double> DValues => dValues;
        public double? D
        {
            get => d;
            set
            {
                d = value;
                OnPropertyChanged(nameof(D));
            }
        }
        public static string Path { get { return path; } set { } }

        public CalcC() {}

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(C * Convert.ToDouble(A) * Convert.ToDouble(A) + D * Convert.ToDouble(B) * Convert.ToDouble(B));
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
                if (!double.TryParse(A, out num))
                {
                    error = "Некорректный ввод";
                }

                if (!double.TryParse(B, out num))
                {
                    error = "Некорректный ввод";
                }

                if (!C.HasValue)
                {
                    error = "Не выбрано значение из списка";
                }

                if (!D.HasValue)
                {
                    error = "Не выбрано значение из списка";
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
