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

namespace task_4WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double dollar = Convert.ToDouble(enter.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = dollar * sumDollar;
            resSum.Text = resDollar.ToString(); 
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double euro = Convert.ToDouble(enter_Euro.Text);
            double sumEuro = Convert.ToDouble(sum_Euro.Text);
            double resEuro = euro * sumEuro;
            resSum_Euro.Text = resEuro.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double griv = Convert.ToDouble(enter_Griv.Text);
            double sumGriv = Convert.ToDouble(sum_Griv.Text);
            double resGriv = griv * sumGriv;
            resSum_Griv.Text = resGriv.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double dram = Convert.ToDouble(enter_Dram.Text);
            double sumDram = Convert.ToDouble(sum_Dram.Text);
            double resDram = dram * sumDram;
            resSum_Dram.Text = resDram.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double inch = Convert.ToDouble(enter_Inch.Text);
            double resInch = inch * 0.025;
            res_Inch.Text = resInch.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double feet = Convert.ToDouble(enter_Feet.Text);
            double resFeet = feet * 0.3048;
            res_Feet.Text = resFeet.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double mile = Convert.ToDouble(enter_Mile.Text);
            double resMile = mile * 1609.34;
            res_Mile.Text = resMile.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double verst = Convert.ToDouble(enter_Verst.Text);
            double resVerst = verst * 1066.8;
            res_Verst.Text = resVerst.ToString();
        }
    }
}
