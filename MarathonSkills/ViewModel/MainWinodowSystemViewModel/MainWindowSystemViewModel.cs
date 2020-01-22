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

       public MainWindowSystemViewModel()
       {

       }

    }
}
