using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace MarathonSkills.ViewModel.MainWinodowSystemViewModel
{
    class MainWindowSystemViewModel : HelperViewModel.HelperClassViewModel
    {
        public static Action CloseWindow { get; set; }

        private string timeBeforeStart;
        
        public string TimeBeforeStart
        {
            get => this.timeBeforeStart;
            set => Set<string>(ref this.timeBeforeStart , value); 
        }

        DispatcherTimer dispatcherTimer;

   

        public ICommand RunnerCommand { get; set; }
        public ICommand SponsorCommand { get; set; }
        public ICommand InformationCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public MainWindowSystemViewModel()
        {

            try
            {
                Classes.DateTimeMarathon dateTimeMarathon = new Classes.DateTimeMarathon();
                this.TimeBeforeStart = dateTimeMarathon.GetDateTimeBeforeMarathone();


                RunnerCommand = new Command(CommandRunnerClick);
                this.SponsorCommand = new Command(CommandSponsorClick);
                this.InformationCommand = new Command(CommandInformationClick);
                this.LoginCommand = new Command(LoginCommandClick);

                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Interval = new TimeSpan(0,0,1);
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

        private void LoginCommandClick(object obj)
        {
            throw new NotImplementedException();
        }

        private void CommandInformationClick(object obj)
        {
            throw new NotImplementedException();
        }

        private void CommandRunnerClick(object obj)
        {
            throw new NotImplementedException();
        }

        private void CommandSponsorClick(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
