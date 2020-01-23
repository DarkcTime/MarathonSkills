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



        public MainWindowSystemViewModel()
       {
            try
            {
                setPage = SetPages;

                SetPage(new View.MainPages.FirstPage());

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

    }
}
