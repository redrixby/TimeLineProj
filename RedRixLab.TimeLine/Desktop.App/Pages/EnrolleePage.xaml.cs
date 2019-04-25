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
    /// Логика взаимодействия для EnrolleePage.xaml
    /// </summary>
    public partial class EnrolleePage : Page
    {
        public bool filterFlag = true;
        public EnrolleePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InsertEnrolle.Margin = new Thickness(15, 300, -757, 0);
;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (filterFlag)
            {
                listApplicantsGrid.Margin = new Thickness(15, 108, 62, -534);
                TabContrPort.Visibility = Visibility.Hidden;
                filterFlag = !filterFlag;
                FilteFlagButton.Content = "Показать фильтры";
            }
            else
            {
                listApplicantsGrid.Margin = new Thickness(15, 560, 62, -534);
                TabContrPort.Visibility = Visibility.Visible;
                filterFlag = !filterFlag;
                FilteFlagButton.Content = "Скрыть фильтры";
            }
            
        }
    }
}
