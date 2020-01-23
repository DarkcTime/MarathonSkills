using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace MarathonSkills.ViewModel.MainPagesViewModel
{
    class FirstPageViewModel : HelperViewModel.HelperClassViewModel
    {

        private string timeBeforeStart;

        public string TimeBeforeStart
        {
            get => this.timeBeforeStart;
            set => Set<string>(ref this.timeBeforeStart, value);
        }

        DispatcherTimer dispatcherTimer;

        public static int NumberClickButton { get; set; }

        public ICommand RunnerCommand { get; set; }
        public ICommand SponsorCommand { get; set; }
        public ICommand InformationCommand { get; set; }
        public ICommand LoginCommand { get; set; }


        public FirstPageViewModel()
        {

            try
            {

                RunnerCommand = new Command(CommandRunnerClick);
                this.SponsorCommand = new Command(CommandSponsorClick);
                this.InformationCommand = new Command(CommandInformationClick);
                this.LoginCommand = new Command(LoginCommandClick);


                Classes.DateTimeMarathon dateTimeMarathon = new Classes.DateTimeMarathon();
                this.TimeBeforeStart = dateTimeMarathon.GetDateTimeBeforeMarathone();

                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Tick += timerTick;
                dispatcherTimer.Start();

            }
            catch (Exception ex)
            {
                this.MessageBoxError(ex);
            }

        }



        private void timerTick(object sender, EventArgs e)
        {
            try
            {
                Classes.DateTimeMarathon dateTimeMarathon = new Classes.DateTimeMarathon();
                this.TimeBeforeStart = dateTimeMarathon.GetDateTimeBeforeMarathone();
            }
            catch (Exception ex)
            {
                this.MessageBoxError(ex);
            }
        }




        #region Обработчики кнопок

        private void GoSecondPage()
        {
            dispatcherTimer.Stop(); 
            ViewModel.HelperViewModel.HelperClassViewModel.SetPage(new View.MainPages.SecondPage());
        }

        private void LoginCommandClick(object obj)
        {

            NumberClickButton = 1;
            GoSecondPage();
          
        }

        private void CommandInformationClick(object obj)
        {
            NumberClickButton = 2;
            GoSecondPage();
        }

        private void CommandRunnerClick(object obj)
        {
            NumberClickButton = 3;
            GoSecondPage();
        }

        private void CommandSponsorClick(object obj)
        {
            NumberClickButton = 4;
            GoSecondPage();
        }

        #endregion
    }
}
