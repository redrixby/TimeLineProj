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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Desktop.App.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Frame fMainFrame;
        public LoginPage()
        {
            InitializeComponent();
            //DataContext = new ViewModel.LoginVeiwModel();
        }

        public LoginPage(Frame frame)
        {
            InitializeComponent();
            fMainFrame = frame;
        }

            private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            fMainFrame.Navigate(new WelcomPage());
            
        }
    }
}
