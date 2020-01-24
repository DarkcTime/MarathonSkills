using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.RunnerPagesViewModel
{
    class MainPageRunnerViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Свойства
        public ICommand RegistrationOnMarathonCommand { get; set; }
        public ICommand EditProfileCommand { get; set; }
        public ICommand ContactsCommand { get; set; }
        public ICommand MyResultsCommand { get; set; }
        public ICommand MySponsorCommand { get; set; }

        #endregion 

        public MainPageRunnerViewModel()
        {
            try
            {
                this.RegistrationOnMarathonCommand = new Command(RegistrationOnMarathonCommandClick);
                this.EditProfileCommand = new Command(EditProfileCommandClick);
                this.ContactsCommand = new Command(ContactsCommandClick);
                this.MyResultsCommand = new Command(MyResultsCommandClick);
                this.MySponsorCommand = new Command(MySponsorCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex); 
            }
        }


        #region Обработчики кнопок
        private void EditProfileCommandClick(object obj)
        {
            
        }

        private void RegistrationOnMarathonCommandClick(object obj)
        {
            
        }

        private void MySponsorCommandClick(object obj)
        {

        }

        private void MyResultsCommandClick(object obj)
        {

        }

        private void ContactsCommandClick(object obj)
        {

        }


        #endregion 
    }
}
