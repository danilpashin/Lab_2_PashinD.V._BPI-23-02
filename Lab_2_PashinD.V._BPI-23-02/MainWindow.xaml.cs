using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_2_PashinD.V._BPI_23_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public GroupBox currentParams;
        public MainWindow()
        {
            InitializeComponent();
            AddItems();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = 0;
                double f = Convert.ToDouble(R1ComboF.Text);
                if(double.TryParse(R1TextA.Text,out a))
                {
                    this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
                }
                else
                {
                    MessageBox.Show("Один или несколько параметров не являются числами!");
                    this.Title = "Ответ: ошибка в параметрах";
                }
            }

            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = 0;
                double b = 0;
                double f = Convert.ToDouble(R2ComboF.Text);
                if (double.TryParse(R2TextA.Text, out a) && double.TryParse(R2TextB.Text, out b))
                {
                    this.Title = "Ответ: " + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
                }
                else
                {
                    MessageBox.Show("Один или несколько параметров не являются числами!");
                    this.Title = "Ответ: ошибка в параметрах";
                }
            }

            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = 0;
                double b = 0;
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                if (double.TryParse(R3TextA.Text, out a) && double.TryParse(R3TextB.Text, out b))
                {
                    this.Title = "Ответ: " + (c * a * a + d * b * b).ToString("F");
                }
                else
                {
                    MessageBox.Show("Один или несколько параметров не являются числами!");
                    this.Title = "Ответ: ошибка в параметрах";
                }
            }

            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double a = 0;
                double d = 0;
                double c = Convert.ToDouble(R4ComboC.Text);
                double res = 1;
                if (double.TryParse(R4TextA.Text, out a) && double.TryParse(R4TextD.Text, out d))
                {
                    for (int i = 0; i < d; i++)
                    {
                        res = res * (c + a) + 1;
                    }
                    this.Title = "Ответ: " + res.ToString("F");
                }
                else
                {
                    MessageBox.Show("Один или несколько параметров не являются числами!");
                    this.Title = "Ответ: ошибка в параметрах";
                }   
            }

            if (Radio5.IsChecked.GetValueOrDefault())
            {
                double p = 0;
                double y = 0;
                int N = 1;
                int K = Convert.ToInt32(R5TextK.Text);
                double resInner = 0;
                double res = 0;
                if(int.TryParse(R5TextN.Text, out N) && int.TryParse(R5TextK.Text, out K) && double.TryParse(R5TextP.Text, out p) && double.TryParse(R5TextY.Text, out y))
                {
                    if(N > 0 && K > 0)
                    {
                        for (int i = 1; i <= N; i++)
                        {
                            for (int j = 1; j <= K; j++)
                            {
                                resInner = Math.Pow(p, i) * Math.Pow(y, j) / (i * j);
                            }
                            res = res + resInner;
                        }
                        this.Title = "Ответ: " + res.ToString("F");
                    }
                    else
                    {
                        MessageBox.Show("N и K должны быть больше нуля!");
                        this.Title = "Ответ: ошибка в параметрах";
                    }
                }
                else
                {
                    MessageBox.Show("Один или несколько параметров не являются числами!");
                    this.Title = "Ответ: ошибка в параметрах";
                }
            }
        }

        private void AddItems()
        {
            R1ComboF.Items.Add(4);
            R1ComboF.Items.Add(5);
            R1ComboF.Items.Add(6);
            R1ComboF.Items.Add(7);
            R1ComboF.Items.Add(8);
            R1ComboF.Items.Add(9);

            R2ComboF.Items.Add(10);
            R2ComboF.Items.Add(20);
            R2ComboF.Items.Add(30);
            R2ComboF.Items.Add(40);

            R3ComboC.Items.Add(0);
            R3ComboC.Items.Add(1);
            R3ComboD.Items.Add(-1);
            R3ComboD.Items.Add(0);
            R3ComboD.Items.Add(1);

            R4ComboC.Items.Add(0);
            R4ComboC.Items.Add(1);
            R4ComboC.Items.Add(2);
            R4ComboC.Items.Add(3);
            R4ComboC.Items.Add(4);
            R4ComboC.Items.Add(5);
        }
    }
}
