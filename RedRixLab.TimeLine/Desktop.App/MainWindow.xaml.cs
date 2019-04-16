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
        }

        private void BtnGet_Click(object sender, RoutedEventArgs e)
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
        }
    }
}
