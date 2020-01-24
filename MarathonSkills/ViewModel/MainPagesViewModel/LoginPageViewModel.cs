using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.MainPagesViewModel
{
    class LoginPageViewModel : HelperViewModel.HelperClassViewModel
    {



        #region Свойства

        public static Model.User User { get; set; }

        private string email, password; 
        public string Email
        {
            get => this.email;
            set => Set<string>(ref email, value);
        }
        public string Password
        {
            get => this.password;
            set => Set<string>(ref password, value);
        }

        public ICommand LoginCommand { get; set; }
        public ICommand BackCommand { get; set; }

        #endregion 

        public LoginPageViewModel()
        {
            try
            {
                this.LoginCommand = new Command(LoginCommandClick);
                this.BackCommand = new Command(BackCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }

        #region Обработчики кнопок

        //переход на главное окно 
        private void BackCommandClick(object obj)
        {
            try
            {
                SetPage(new View.MainPages.FirstPage());
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }

        //авторизация пользователя 
        private void LoginCommandClick(object obj)
        {
            try
            {
                var user = base.context.User.Where(i => i.Email == this.Email && i.Password == this.Password);

                if (user.Count() > 0)
                {
                    User = user.FirstOrDefault();

                    if(Convert.ToChar(User.RoleId) == 'A')
                    {
                        SetPageSecondPage(new View.AdministratorPages.MainPageAdministrator());
                    }
                    else if(Convert.ToChar(User.RoleId) == 'C')
                    {
                        SetPageSecondPage(new View.CoordinatorPages.MainPageCoordinator());
                    }
                    else if (Convert.ToChar(User.RoleId) == 'R')
                    {
                        SetPageSecondPage(new View.RunnerPages.MainPageRunner());
                    }
                }
                else
                {
                    base.MessageBoxError("Неправильный логин или пароль");
                }

            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }

        #endregion 
    }
}
