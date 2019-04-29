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

namespace Desktop.App.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private MainWindow mw;

        public MenuPage()
        {
            InitializeComponent();
        }

        public MenuPage(MainWindow o_mw)
        {
            InitializeComponent();
            mw = o_mw;
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.EnrolleePage());
        }

        private void Image_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StudentListPage());
        }

        private void Image_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.Administration());
        }
    }
}
