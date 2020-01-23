using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MarathonSkills.ViewModel.MainPagesViewModel
{
    class SecondPageViewModel : HelperViewModel.HelperClassViewModel
    {

        private string timeBeforeStart;

        public string TimeBeforeStart
        {
            get => this.timeBeforeStart;
            set => Set<string>(ref this.timeBeforeStart, value);
        }


        private string title;
        public string Title
        {
            get => this.title;
            set => Set<string>(ref title, value);
        }

        private Page currentPage;

        public Page CurrentPage
        {

            get => this.currentPage;
            set => this.Set<Page>(ref this.currentPage, value);
        }



        DispatcherTimer dispatcherTimer;

        public ICommand BackCommand { get; set; }

        public SecondPageViewModel()
        {
            try
            {

                Classes.DateTimeMarathon dateTimeMarathon = new Classes.DateTimeMarathon();
                this.TimeBeforeStart = dateTimeMarathon.GetDateTimeBeforeMarathone();

                dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Tick += timerTick;
                dispatcherTimer.Start();


                this.BackCommand = new Command(BackCommandClick);

                setPageSecondPage = SetPages;
   
                
                
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


        private void SetPages(Page page)
        {

            try
            {
                CurrentPage = page;
                Title = page.Title;
            }
            catch (Exception ex)
            {
                this.MessageBoxError(ex);
            }

        }

        #region Обработчики кнопок

        private void BackCommandClick(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion 



    }
}
