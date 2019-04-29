using System.Windows;
using System.Windows.Controls;

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
