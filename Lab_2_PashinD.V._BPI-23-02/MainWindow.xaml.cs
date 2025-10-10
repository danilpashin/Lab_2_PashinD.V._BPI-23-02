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
        public CalcA calcA;
        public CalcB calcB;
        public CalcC calcC;
        public CalcD calcD;
        public CalcE calcE;
        public MainWindow()
        {
            InitializeComponent();
            setImages();
            setClasses();
        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                setUsing(Params1);
            }
            else if (Radio2.IsChecked.GetValueOrDefault())
            {
                setUsing(Params2);
            }
            else if (Radio3.IsChecked.GetValueOrDefault())
            {
                setUsing(Params3);
            }
            else if (Radio4.IsChecked.GetValueOrDefault())
            {
                setUsing(Params4);
            }
            else if (Radio5.IsChecked.GetValueOrDefault())
            {
                setUsing(Params5);
            }
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                this.Title = "Ответ: " + calcA.Solve();
            }
            else if (Radio2.IsChecked.GetValueOrDefault())
            {
                this.Title = "Ответ: " + calcB.Solve();
            }
            else if (Radio3.IsChecked.GetValueOrDefault())
            {
                this.Title = "Ответ: " + calcC.Solve();
            }
            else if (Radio4.IsChecked.GetValueOrDefault())
            {
                this.Title = "Ответ: " + calcD.Solve();
            }
            else if (Radio5.IsChecked.GetValueOrDefault())
            {
                this.Title = "Ответ: " + calcE.Solve();
            }
        }

        private void setUsing(GroupBox currGroupBox)
        {
            Params1.IsEnabled = false;
            Params2.IsEnabled = false;
            Params3.IsEnabled = false;
            Params4.IsEnabled = false;
            Params5.IsEnabled = false;
            currGroupBox.IsEnabled = true;
        }

        private void setClasses()
        {
            calcA = (CalcA)Application.Current.FindResource("CalcA");
            calcB = (CalcB)Application.Current.FindResource("CalcB");
            calcC = (CalcC)Application.Current.FindResource("CalcC");
            calcD = (CalcD)Application.Current.FindResource("CalcD");
            calcE = (CalcE)Application.Current.FindResource("CalcE");
        }

        private void setImages()
        {
            Img1.Source = new BitmapImage(new Uri(CalcA.Path));
            Img2.Source = new BitmapImage(new Uri(CalcB.Path));
            Img3.Source = new BitmapImage(new Uri(CalcC.Path));
            Img4.Source = new BitmapImage(new Uri(CalcD.Path));
            Img5.Source = new BitmapImage(new Uri(CalcE.Path));
        }
    }
}
