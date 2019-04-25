using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Desktop.App.ViewModel
{
    class LoginVeiwModel : VeiwModelBase
    {
        private Page WelcomPage;
        private Page Menu;


        private Page currentPage;
        public Page CurrentPage { get => currentPage; set => currentPage = value; }

        public LoginVeiwModel()
        {
            WelcomPage = new Pages.WelcomPage();
            Menu = new Pages.MenuPage();
            
        }

       /* public ICommand LoginButton_Click
        {
            get
            {
                return new RelayCommand(() => CurrentPage = WelcomPage);
            }
        }*/
    }
}
