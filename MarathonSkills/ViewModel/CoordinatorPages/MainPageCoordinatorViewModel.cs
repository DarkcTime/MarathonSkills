using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.CoordinatorPages
{
    class MainPageCoordinatorViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Cвойства 
        public ICommand RunnersCommand { get; set; }
        public ICommand SponsorsCommand { get; set; }

        #endregion

        public MainPageCoordinatorViewModel()
        {
            try
            {
                this.RunnersCommand = new Command(RunnersCommandClick);
                this.SponsorsCommand = new Command(SponsorsCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex); 
            }
        }

        private void SponsorsCommandClick(object obj)
        {
            
        }

        private void RunnersCommandClick(object obj)
        {
            
        }
    }
}
