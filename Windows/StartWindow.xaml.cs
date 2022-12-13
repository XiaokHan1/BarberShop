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
            gengerTb.SelectedValuePath = "Id";
            gengerTb.DisplayMemberPath = "Name";
            gengerTb.ItemsSource = AppData.BS.beloborodov.POl.ToList();
        }

        private void DobBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(NameTb.Text))
                mes += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(DateTb.Text))
                mes += "Введите дату рождения\n";
            if (string.IsNullOrWhiteSpace(AgeTb.Text))
                mes += "Введите возраст\n";
            if (string.IsNullOrWhiteSpace(gengerTb.Text))
                mes += "Введите пол\n";

            if(mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Model.ManPost manPost = new Model.ManPost()
            {
                Name = NameTb.Text,
                Data = (DateTime)DateTb.SelectedDate,
                Genger = int.Parse(AgeTb.Text),
                POl1 = gengerTb.SelectedItem as Model.POl
            };
            AppData.BS.beloborodov.ManPost.Add(manPost);
            AppData.BS.beloborodov.SaveChanges();
            MessageBox.Show("Добавлено");

            NameTb.Text = "";
            DateTb.Text = "";
            AgeTb.Text = "";
            gengerTb.Text = "";
        }

        private void DelBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
