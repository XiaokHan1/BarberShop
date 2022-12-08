﻿using System;
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
        public List<User> user = new List<User>();
        public Window1()
        {
            InitializeComponent();

            user.Add(new User("Каримов А.О.", "27.04.1996", "23", "M"));
            user.Add(new User("Шишкин К.А.", "25.02.1998", "21", "M"));
            user.Add(new User("Кучукбаева Л.А.", "18.02.1999", "20", "W"));
            user.Add(new User("Белов А.В.", "25.02.1997", "22", "M"));
            user.Add(new User("Хоробрых Г.Д.", "25.02.1996", "23", "M"));
            user.Add(new User("Юкович Н.Т.", "25.02.1995", "22", "M"));
            user.Add(new User("Власов А.А.", "25.02.1994", "25", "M"));
            user.Add(new User("Теплоухов Н.С.", "25.02.1993", "26", "M"));
            LoadUser(user);
        }

        public void LoadUser(List<User> _user)
        {
            userList.Items.Clear(); 

            for (int i = 0; i < _user.Count; i++) 
            {
                userList.Items.Add(_user[i]);
            }
        }

        private void Lists_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            newUsers = user;

            if (genderFilter.SelectedIndex == 0)
                newUsers = user.FindAll(x => x.gender == "M");
            else
                newUsers = user.FindAll(x => x.gender == "W");

            LoadUser(newUsers);

            newUsers = newUsers.FindAll(x => x.name.Contains(nameFilter.Text));
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
    }
}
