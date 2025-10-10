using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Lab_2_PashinD.V._BPI_23_02
{
    public class CalcA : CalcMain, INotifyPropertyChanged, IDataErrorInfo
    {
        private string a = String.Empty;
        private double? f;
        private static ObservableCollection<double> fValues = new ObservableCollection<double> { 4, 5, 6, 7, 8, 9 };
        private static string path = "pack://application:,,,/Resources/p1.png";
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


        public CalcA() {}

        public override string Solve()
        {
            if (res)
            {
                return Convert.ToString(Math.Sin((double)(Convert.ToDouble(A) * F)));
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
