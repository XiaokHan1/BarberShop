using BarberShopSalon.Pages;
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
using System.Windows.Shapes;

namespace BarberShopSalon
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ListClient_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Ochered());
        }

        private void ListCustomers_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new RecordPage());
        }

        private void ListMenu_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ListPage());
        }
    }
}
