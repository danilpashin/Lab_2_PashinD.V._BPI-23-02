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
        public MainWindow()
        {
            InitializeComponent();
            AddItems();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R1TextA.Text);
                double f = Convert.ToDouble(R1ComboF.Text);
                this.Title = "Ответ: " + Math.Sin(f * a).ToString("F");
            }

            if (Radio2.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R2TextA.Text);
                double b = Convert.ToDouble(R2TextB.Text);
                double f = Convert.ToDouble(R2ComboF.Text);
                this.Title = "Ответ: " + (Math.Cos(f * a) + Math.Sin(f * b)).ToString("F");
            }

            if (Radio3.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R3TextA.Text);
                double b = Convert.ToDouble(R3TextA.Text);
                double c = Convert.ToDouble(R3ComboC.Text);
                double d = Convert.ToDouble(R3ComboD.Text);
                this.Title = "Ответ: " + (c*a*a + d*b*b).ToString("F");
            }

            if (Radio4.IsChecked.GetValueOrDefault())
            {
                double a = Convert.ToDouble(R4TextA.Text);
                double d = Convert.ToDouble(R4TextD.Text);
                double c = Convert.ToDouble(R4ComboC.Text);
                double res = 1;
                for(int i = 0; i < d; i++)
                {
                    res = res * (c + a) + 1;
                }
                this.Title = "Ответ: " + res.ToString("F");
            }

            if (Radio5.IsChecked.GetValueOrDefault())
            {
                double p = Convert.ToDouble(R5TextP.Text);
                double y = Convert.ToDouble(R5TextY.Text);
                int N = Convert.ToInt32(R5TextN.Text);
                int K = Convert.ToInt32(R5TextK.Text);
                double resInner = 1;
                double res = 1;
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
