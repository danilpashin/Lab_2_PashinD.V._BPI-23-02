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
                calcA = new CalcA(R1TextA.Text, Convert.ToDouble(R1ComboF.Text));
                this.Title = "Ответ: " + calcA.Solve();
            }
            if (Radio2.IsChecked.GetValueOrDefault())
            {
                calcB = new CalcB(R2TextA.Text, R2TextB.Text, Convert.ToDouble(R2ComboF.Text));
                this.Title = "Ответ: " + calcB.Solve();
            }
            if (Radio3.IsChecked.GetValueOrDefault())
            {
                calcC = new CalcC(R3TextA.Text, R3TextB.Text, Convert.ToDouble(R3ComboC.Text), Convert.ToDouble(R3ComboD.Text));
                this.Title = "Ответ: " + calcC.Solve();
            }
            if (Radio4.IsChecked.GetValueOrDefault())
            {
                calcD = new CalcD(R4TextA.Text, R4TextD.Text, Convert.ToDouble(R4ComboC.Text));
                this.Title = "Ответ: " + calcD.Solve();
            }
            if (Radio5.IsChecked.GetValueOrDefault())
            {
                calcE = new CalcE(R5TextP.Text, R5TextY.Text, R5TextN.Text, R5TextK.Text);
                this.Title = "Ответ: " + calcE.Solve();
            }
        }

        private void setImages()
        {
            Img1.Source = new BitmapImage(new Uri(CalcA.Path, UriKind.Relative));
            Img2.Source = new BitmapImage(new Uri(CalcB.Path, UriKind.Relative));
            Img3.Source = new BitmapImage(new Uri(CalcC.Path, UriKind.Relative));
            Img4.Source = new BitmapImage(new Uri(CalcD.Path, UriKind.Relative));
            Img5.Source = new BitmapImage(new Uri(CalcE.Path, UriKind.Relative));
        }

        private void addItems()
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
