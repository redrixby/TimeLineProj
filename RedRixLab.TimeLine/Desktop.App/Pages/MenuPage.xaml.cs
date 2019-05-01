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
        public bool workStudentFlag = false;

        private bool menu_btn_state = true;
        private bool menu_stud_state = false;

        public MenuPage()
        {
            InitializeComponent();
        }

        public MenuPage(MainWindow o_mw)
        {
            InitializeComponent();
            mw = o_mw;
        }
     
        private void ButtonWorkEnrolle_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.EnrolleePage());
        }

        private void ButtonListStudent_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StudentListPage());
        }

        private void ButtonExaminationSheets_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.ExaminationSheetsPage());
        }

        private void ButtonAcademicTranscript_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.AcademicTranscriptPage());
        }

        private void ButtonDebtorsHonors_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.DebtorsHonorsPage());
        }

        private void ButtonStudentSearch_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StudentSearchPage());
        }

        private void ButtonGroupDistribution_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.GroupDistributionPage());
        }

        private void ButtonStatisticsPerformance_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StatisticsPerformancePage());
        }

        private void ButtonAdministration_Click(object sender, RoutedEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.Administration());
        }

        private void ButtonWorkStudent_Click(object sender, RoutedEventArgs e)
        {
            //if (!workStudentFlag)
            //{
            //    PanelStudent.Height = 241;
            //    ButtonHR.Margin = new Thickness(15,464,27,283);
            //    ButtonAdministration.Margin = new Thickness(15, 509, 4, 0);
            //    workStudentFlag = !workStudentFlag;
            //}
            //else
            //{
            //    PanelStudent.Height = 44;
            //    ButtonHR.Margin = new Thickness(15, 259, 27, 283);
            //    ButtonAdministration.Margin = new Thickness(15, 305, 4, 0);
            //    workStudentFlag = !workStudentFlag;
            //}
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (menu_btn_state)
            {
                menu_btn.Source = new BitmapImage(new Uri("pack://application:,,,/Desktop.App;component/Resources/img/Menu/menu_btn_closed.png"));
                menu_btn_state = false;
                Width = 60;
                search_panel.Visibility = Visibility.Hidden;
            }
            else
            {
                menu_btn.Source = new BitmapImage(new Uri("pack://application:,,,/Desktop.App;component/Resources/img/Menu/menu_btn_open.png"));
                menu_btn_state = true;
                Width = 197;
                search_panel.Visibility = Visibility.Visible;
            }
            Change_Size_Imgs();
        }

        private void Change_Size_Imgs()
        {

        }

        private void Set_Def_imgs()
        {

        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(Search_text.Text);
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (menu_stud_state)
            {
                menu_stud_btn.Source = new BitmapImage(new Uri("pack://application:,,,/Desktop.App;component/Resources/img/Menu/menu_students_inactive_167x40.png"));
                menu_stud_btn.Width = 167;
                menu_stud_btn.Height = 40;
                menu_stud_btn.Margin = new Thickness(15, 0, 0, 0);
                stud_panel.Height = 40;
                menu_stud_state = false;
                menu_3.Margin = new Thickness(15, 270, 0, 0);
                menu_4.Margin = new Thickness(15, 325, 0, 0);
            }
            else
            {
                menu_stud_btn.Source = new BitmapImage(new Uri("pack://application:,,,/Desktop.App;component/Resources/img/Menu/menu_students_active_187x45.png"));
                menu_stud_btn.Width = 187;
                menu_stud_btn.Height = 50;
                menu_stud_btn.Margin = new Thickness(5, 0, 0, 0);
                stud_panel.Height = 270;
                menu_stud_state = true;
                menu_3.Margin = new Thickness(15, 484, 0, 0);
                menu_4.Margin = new Thickness(15, 539, 0, 0);
            }
        }

        private void Menu_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.EnrolleePage());
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StudentListPage());
        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.ExaminationSheetsPage());
        }

        private void Label_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.AcademicTranscriptPage());
        }

        private void Label_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.DebtorsHonorsPage());
        }

        private void Label_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StudentSearchPage());
        }

        private void Label_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.GroupDistributionPage());
        }

        private void Label_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.StatisticsPerformancePage());
        }

        private void Menu_4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (mw != null)
                mw.MainFrame.Navigate(new Pages.Administration());
        }
    }
}

/*

    <Page.Resources>
        <ControlTemplate x:Key="TextBoxTemplate" TargetType="TextBox">
            <Border CornerRadius="15" 
                     BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" SnapsToDevicePixels="True">
                <ScrollViewer x:Name="PART_ContentHost" Focusable="false" HorizontalScrollBarVisibility="Hidden" VerticalScrollBarVisibility="Hidden"/>
            </Border>
        </ControlTemplate>
    </Page.Resources>
 */
