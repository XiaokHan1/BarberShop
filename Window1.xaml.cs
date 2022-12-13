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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            userList.ItemsSource = AppData.BS.beloborodov.ManPost.ToList();
        }

        private void Lists_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AndBtn2_Click(object sender, RoutedEventArgs e)
        {
            Windows.MainWindow mainWindow = new Windows.MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Windows.StartWindow startWindow = new Windows.StartWindow();
            startWindow.Show();
            Close();
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AndBtn2_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
