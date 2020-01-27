using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.RunnerPagesViewModel
{
    class RegisterAsRunnerViewModel : HelperViewModel.HelperClassViewModel
    {
        public ICommand LastUserCommand { get; set; }   
        public ICommand RunnerCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public RegisterAsRunnerViewModel()
        {
            try
            {
                this.LastUserCommand = new Command(LastUserCommandClick);
                this.RunnerCommand = new Command(RunnerCommandClick);
                this.LoginCommand = new Command(LoginCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }


        private void LoginCommandClick(object obj)
        {
            try
            {
                SetPageSecondPage(new View.MainPages.LoginPage());
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }

        private void RunnerCommandClick(object obj)
        {
            try
            {
                SetPageSecondPage(new View.RunnerPages.NewRunnerPage());
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }

        private void LastUserCommandClick(object obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }
    }
}
