using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Desktop.App.ViewModel
{
    class MainWindowModel : VeiwModelBase
    {
        private Page LoginPage;
        private Page EnrollePage;
        private Page StudentListPage;


        private Page currentPage;
        public Page CurrentPage { get => currentPage; set => currentPage = value; }

        public MainWindowModel()
        {
            /*EnrollePage = new Pages.EnrolleePage();
            CurrentPage = EnrollePage;
            
            LoginPage = new Pages.LoginPage();
            CurrentPage = LoginPage;
            StudentListPage = new Pages.StudentListPage();
            CurrentPage = StudentListPage;*/

            //LoginPage = new Pages.LoginPage();
            //CurrentPage = LoginPage;
    
        }
    }
}
