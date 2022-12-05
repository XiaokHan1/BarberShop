using BarberShopSalon.Windows;
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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void StartTypingBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void StartTypingBtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartTypingBtn_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StartTypingBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow auth = new MainWindow();
            auth.Show();
            Close();
        }
    }
}

