using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.AdministratorPagesViewModel
{
    class MainPageAdministratorViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Свойства
        public ICommand UsersCommand { get; set; }
        public ICommand OrganizationsCommand { get; set; }
        public ICommand VolontersCommand { get; set; }
        public ICommand InventoryCommand { get; set; }

        #endregion 

        public MainPageAdministratorViewModel()
        {
            try
            {
                this.UsersCommand = new Command(UsersCommandClick);
                this.OrganizationsCommand = new Command(OrganizationsCommandClick);
                this.VolontersCommand = new Command(VolontersCommandClick);
                this.InventoryCommand = new Command(InventoryCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex);
            }
        }




        #region Обработчики кнопок

        private void InventoryCommandClick(object obj)
        {
         
        }

        private void VolontersCommandClick(object obj)
        {
         
        }

        private void OrganizationsCommandClick(object obj)
        {
         
        }

        private void UsersCommandClick(object obj)
        {
            
        }


        #endregion



    }
}
