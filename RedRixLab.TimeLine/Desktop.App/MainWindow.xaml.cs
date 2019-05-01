using Desktop.App.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;

namespace Desktop.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel.MainWindowModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //todo check for current sessions
            MainFrame.Navigate(new Pages.LoginPage(this));
        }

    }
}
