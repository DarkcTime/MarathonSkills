﻿using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.MarathonInormationViewModel
{
    class FindOutMoreInformationViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Свойства 
        
        public ICommand MarathonCommand { get; set; }
        public ICommand LastResultCommand { get; set; }
        public ICommand BMICalcCommand { get; set; }
        public ICommand DuringMarathonCommand { get; set; }
        public ICommand ListOrganizationsCommand { get; set; }
        public ICommand BRMCalcCommand { get; set; }


        #endregion 

        public FindOutMoreInformationViewModel()
        {
            try
            {
                this.MarathonCommand = new Command(MarathonCommandClick);
                this.LastResultCommand = new Command(LastResultCommandClick);
                this.BMICalcCommand = new Command(BMICalcCommandClick);
                this.DuringMarathonCommand = new Command(DuringMarathonCommandClick);
                this.ListOrganizationsCommand = new Command(ListOrganizationsCommandClick);
                this.BRMCalcCommand = new Command(BRMCalcCommandClick);
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex); 
            }
        }

        #region Обработчики кнопок 

        private void BRMCalcCommandClick(object obj)
        {
            
        }

        private void ListOrganizationsCommandClick(object obj)
        {
            
        }

        private void DuringMarathonCommandClick(object obj)
        {
            
        }

        private void BMICalcCommandClick(object obj)
        {
            
        }

        private void MarathonCommandClick(object obj)
        {
            
        }

        private void LastResultCommandClick(object obj)
        {
            
        }

        #endregion 
    }
}
