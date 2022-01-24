using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace task_14WpfApp
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductType = ProductTypes.Food,
                Name = "Хлеб",
                Image = 1,
                Price = 40
            });
            products.Add(new Product()
            {
                ProductType = ProductTypes.Food,
                Name = "Молоко",
                Image = 2,
                Price = 70
            });
            products.Add(new Product()
            {
                ProductType = ProductTypes.Appliances,
                Name = "Утюг",
                Image = 3,
                Price = 1234
            });
            lstBox.ItemsSource = products;
        }

        
    }
}
