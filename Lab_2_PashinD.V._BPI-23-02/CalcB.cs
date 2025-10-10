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
    public class CalcB : CalcMain, INotifyPropertyChanged, IDataErrorInfo
    {
        private string a = String.Empty;
        private string b = String.Empty;
        private double? f;
        private static ObservableCollection<double> fValues = new ObservableCollection<double> { 10, 20, 30, 40 };
        private static string path = "pack://application:,,,/Resources/p2.png";
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
        public double? F
        {
            get => f;
            set
            {
                f = value;
                OnPropertyChanged(nameof(F));
            }
        }
        public ObservableCollection<double> FValues => fValues;
        public static string Path { get => path; set { } }

        public CalcB() {}

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(Math.Cos((double)(F * Convert.ToDouble(A))) + Math.Sin((double)(F * Convert.ToDouble(B))));
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

                if (!F.HasValue)
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
