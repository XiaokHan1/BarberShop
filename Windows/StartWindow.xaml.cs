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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void DobBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите дату рождения\n";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите возраст\n";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите пол\n";

            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
             User user = new User()
            {
                name = NameTb.Text,
                dataOfBirth = DateTb.Text,
                age = AgeTb.Text,
                gender = gengerTb.Text
            };
            
            NameTb.Text = "";
            DateTb.Text = "";
            AgeTb.Text = "";
            gengerTb.Text = "";
        }
    }
}
