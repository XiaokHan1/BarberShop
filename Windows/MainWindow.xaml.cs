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

namespace BarberShopSalon.Windows
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

        private void AutorizationApp_Click(object sender, RoutedEventArgs e)
        {
            var enter = AppData.BS.barbershopEntities.Users.Where(i => i.Login == NameTb.Text && i.Password == PassTb.Password).FirstOrDefault();
            if (enter != null)
            {
                Window1 window2 = new Window1();
                window2.Show();
                Close();
            }
            if (enter == null)
            {
                MessageBox.Show("Проверьте Логин и пароль.");
            }
        }

        private void And1Btn_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            Close();
        }
    }
}
