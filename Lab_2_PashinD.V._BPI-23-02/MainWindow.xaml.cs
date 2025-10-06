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
            addItems();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            if (Radio1.IsChecked.GetValueOrDefault())
            {
                calcA = new CalcA(R1TextA.Text, R1ComboF.Text);
                this.Title = "Ответ: " + calcA.Solve();
            }
            else if (Radio2.IsChecked.GetValueOrDefault())
            {
                calcB = new CalcB(R2TextA.Text, R2TextB.Text, R2ComboF.Text);
                this.Title = "Ответ: " + calcB.Solve();
            }
            else if (Radio3.IsChecked.GetValueOrDefault())
            {
                calcC = new CalcC(R3TextA.Text, R3TextB.Text, R3ComboC.Text, R3ComboD.Text);
                this.Title = "Ответ: " + calcC.Solve();
            }
            else if (Radio4.IsChecked.GetValueOrDefault())
            {
                calcD = new CalcD(R4TextA.Text, R4TextD.Text, R4ComboC.Text);
                this.Title = "Ответ: " + calcD.Solve();
            }
            else if (Radio5.IsChecked.GetValueOrDefault())
            {
                calcE = new CalcE(R5TextP.Text, R5TextY.Text, R5TextN.Text, R5TextK.Text);
                this.Title = "Ответ: " + calcE.Solve();
            }
        }

        private void setImages()
        {
            Img1.Source = new BitmapImage(new Uri(CalcA.Path));
            Img2.Source = new BitmapImage(new Uri(CalcB.Path));
            Img3.Source = new BitmapImage(new Uri(CalcC.Path));
            Img4.Source = new BitmapImage(new Uri(CalcD.Path));
            Img5.Source = new BitmapImage(new Uri(CalcE.Path));
        }

        private void addItems()
        {
            R1ComboF.ItemsSource = CalcA.FValues;

            R2ComboF.ItemsSource = CalcB.FValues;

            R3ComboC.ItemsSource = CalcC.CValues;
            R3ComboC.ItemsSource = CalcC.DValues;

            R4ComboC.ItemsSource = CalcD.CValues;
        }
    }
}
