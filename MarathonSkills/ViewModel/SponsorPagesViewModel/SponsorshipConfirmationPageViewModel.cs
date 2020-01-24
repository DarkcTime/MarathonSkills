using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.SponsorPagesViewModel
{
    class SponsorshipConfirmationPageViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Свойства 
        private int sumDonation;
        public int SumDonation
        {
            get => this.sumDonation;
            set => Set<int>(ref sumDonation, value); 
        }
        private string nameRunner;

        public string NameRunner
        {
            get => this.nameRunner;
            set => Set<string>(ref nameRunner, value);
        }

        public ICommand BackCommand { get; set; }
        #endregion


        public SponsorshipConfirmationPageViewModel()
        {
            try
            {

                this.BackCommand = new Command(BackCommandClick
                    );
                this.SumDonation = ViewModel.SponsorPagesViewModel.SponsorRunnerPageViewModel.SumDonationStatic;
                this.NameRunner = ViewModel.SponsorPagesViewModel.SponsorRunnerPageViewModel.SelectedRunnerStatic.InformationAboutRunner; 
            }
            catch (Exception ex)
            {
                base.MessageBoxError(ex); 
            }
        }

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
    }
}
