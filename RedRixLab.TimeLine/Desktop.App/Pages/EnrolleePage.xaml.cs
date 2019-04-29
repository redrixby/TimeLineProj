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
            PanelSearchList.Margin = new Thickness(15, 186, 0, 0);
        }

 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (filterFlag)
            {
                listApplicantsGrid.Margin = new Thickness(15, 160, 62, -534);
                redIcon.Margin = new Thickness(846, 128, 146, 256);
                yellowIcon.Margin = new Thickness(942, 128, 61, 256);
                labelNameGrid.Margin = new Thickness(15, 126, 0, 0);
                //listApplicantsGrid.Height = 644;
                TabContrPort.Visibility = Visibility.Hidden;
                PanelInsertEnrolle.Visibility = Visibility.Hidden;
                PanelSearchList.Visibility = Visibility.Hidden;
                PanelCreatedNewList.Visibility = Visibility.Hidden;
               // FonPortFrame.Visibility = Visibility.Hidden;
                filterFlag = !filterFlag;
                FilteFlagButton.Content = "Показать фильтры";
            }
            else
            {
                listApplicantsGrid.Margin = new Thickness(15, 560, 62, -534);
                redIcon.Margin = new Thickness(846, 528, 146, 256);
                yellowIcon.Margin = new Thickness(942, 528, 61, 256);
                labelNameGrid.Margin = new Thickness(15, 526, 0, 0);
                //listApplicantsGrid.Height = 240;
                TabContrPort.Visibility = Visibility.Visible;
                PanelInsertEnrolle.Visibility = Visibility.Visible;
                PanelSearchList.Visibility = Visibility.Visible;
                PanelCreatedNewList.Visibility = Visibility.Visible;
               // FonPortFrame.Visibility = Visibility.Visible;
                filterFlag = !filterFlag;
                FilteFlagButton.Content = "Скрыть фильтры";
            }
            
        }

        

        private void CreateNewList_Click(object sender, RoutedEventArgs e)
        {
            PanelInsertEnrolle.Margin = new Thickness(15, 300, -757, 0);
            PanelCreatedNewList.Margin = new Thickness(-1719, 186, 0, 0);
        }

        private void OpenCreatedNewList_Click(object sender, RoutedEventArgs e)
        {
            PanelCreatedNewList.Margin = new Thickness(15, 186, 0, 0);
            PanelSearchList.Margin = new Thickness(-942, 186, 0, 0);
        }

        private void ShowListEnrolle_Click(object sender, RoutedEventArgs e)
        {
            PanelSearchList.Margin = new Thickness(-905, 186, 0, 0);
            PanelInsertEnrolle.Margin = new Thickness(15, 300, -757, 0);

        }

        private void OpenPanelSearchList_Click(object sender, RoutedEventArgs e)
        {
            PanelSearchList.Margin = new Thickness(15, 186, 0, 0);
            PanelCreatedNewList.Margin = new Thickness(-1719, 186, 0, 0);

        }

        private void OpenPanelSearchListFromInsertEnrollePanel_Click(object sender, RoutedEventArgs e)
        {
            PanelInsertEnrolle.Margin = new Thickness(-2647, 300, 0, 0);
            PanelSearchList.Margin = new Thickness(15, 186, 0, 0);
        }

        private void PickUpDock_Click(object sender, RoutedEventArgs e)
        {
            if (InsertDatePickUpDocText.IsEnabled)
            {
                InsertDatePickUpDocText.IsEnabled = false;
                InsertDatePickUpDocText.Text = "";
               // PickUpDock.Content = new StaticResourceExtension(new Uri(@"F:\RedRix\RedRixLab.TimeLine\Resource\image\blue_ellipse_empty.png"));
              //  PickUpDock.Background = new ImageBrush(new BitmapImage(new Uri(@"F:\RedRix\RedRixLab.TimeLine\Resource\image\blue_ellipse_empty.png")));
            }
            else
            {
                InsertDatePickUpDocText.IsEnabled = true;
                //PickUpDock.Content = new StaticResourceExtension(new Uri(@"F:\RedRix\RedRixLab.TimeLine\Resource\image\blue_ellipse.png"));
               // PickUpDock.Background = new ImageBrush(new BitmapImage(new Uri(@"F:\RedRix\RedRixLab.TimeLine\Resource\image\blue_ellipse.png")));
            }
            


        }
    }
}
