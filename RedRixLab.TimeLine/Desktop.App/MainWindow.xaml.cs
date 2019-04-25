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
            //DataContext = new ViewModel.MainWindowModel();
            MainFrame.Navigate(new Pages.LoginPage(MainFrame));
            //MainFrame.GoBack();
        }
        private int c = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //navig test
            c++;
            switch (c)
            {
                case 1:
                    MainFrame.Navigate(new Pages.LoginPage(MainFrame));
                        //.Source = new System.Uri("/Desktop.App;component/Pages/LoginPage.xaml");
                    break;
                case 2:
                    MainFrame.Navigate(new Pages.EnrolleePage());
                    MenuFrame.Navigate(new Pages.MenuPage());
                    break;
                case 3:
                    MainFrame.Navigate(new Pages.MenuPage());
                    break;
                case 4:
                    MainFrame.Navigate(new Pages.WelcomPage());
                    break;
                default:
                    break;
            }
        }
        

        /*

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //if (MainFrame.Content.ToString() == "Desktop.App.Pages.LoginPage")
            //{
            //    MenuFrame.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    MenuFrame.Visibility = Visibility.Visible;
            //}
            //if (this.MainFrame.Source == )
        }*/



        /* private void BtnGet_Click(object sender, RoutedEventArgs e)
         {
             HttpClient client = new HttpClient();
             client.BaseAddress = new Uri("http://localhost:5050/");

             client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

             var id = tbId.Text.Trim();

             var url = "api/FormOfEducation/" + id;

             HttpResponseMessage response = client.GetAsync(url).Result;

             if (response.IsSuccessStatusCode)
             {
                 var formOfEducation = response.Content.ReadAsAsync<FormOfEducation>().Result;

                 lbDesc.Content = formOfEducation.Description;

                 MessageBox.Show("Employee Found : " + formOfEducation.Description);

             }
             else
             {
                 MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
             }
         }*/
    }
}
