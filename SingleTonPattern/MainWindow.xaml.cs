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

namespace SingleTonPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SingleTon x, y;
        SingleTon singletone, singletone2;
        
        public MainWindow()
        {
            InitializeComponent();
            x = SingleTon.GetObject();
            y = SingleTon.GetObject();
            singletone = SingleTon.GetObject();
            Clonator3000 clonator = new Clonator3000();
            singletone2 = (SingleTon)clonator.Clone(singletone);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(y.GetCount().ToString());
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(x.GetCount1().ToString());
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Prototype artem = new Prototype()
            {
                Name = "Артем",
                Age = 28,
                Home = "Вишняки 2",
                Work = "Ленина 2",
                Bday = new Date() { Day = 21, Month = 04, Year = 2014 }
            };

            //Prototype artem2 = artem.Clone();
            Clonator3000 clonator3000 = new Clonator3000();
            Prototype artem2 = (Prototype)clonator3000.Clone(artem);
            artem2.Age = 49;
            artem2.Bday.Year = 2000;
            MessageBox.Show(artem2.GetInfo()+"\n\n\n"+artem.GetInfo());
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(singletone.GetCount().ToString());
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(singletone2.GetCount1().ToString());
        }
    }
}