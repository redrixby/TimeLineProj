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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Desktop.App.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private MainWindow mw;

        public LoginPage()
        {
            InitializeComponent();
            //DataContext = new ViewModel.LoginVeiwModel();
        }

        public LoginPage(MainWindow o_mw)
        {
            InitializeComponent();
            mw = o_mw;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
            {
                //mw.MenuFrame.Background = new SolidColorBrush(Colors.Red);
                mw.MenuFrame.Navigate(new Pages.MenuPage(mw));
                mw.MainFrame.Navigate(new Pages.WelcomPage());
            }
        }
    }
}
