using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MarathonSkills.View.MainWindowSystem
{
    /// <summary>
    /// Логика взаимодействия для WMainWindowSystem.xaml
    /// </summary>
    public partial class WMainWindowSystem : Window
    {
        public WMainWindowSystem()
        {
            try
            {
                InitializeComponent();
                ViewModel.MainWinodowSystemViewModel.MainWindowSystemViewModel.CloseWindow = new Action(() => this.Close()); 
                DataContext = new ViewModel.MainWinodowSystemViewModel.MainWindowSystemViewModel(); 
            }
            catch (Exception ex)
            {
                ViewModel.HelperViewModel.HelperClassViewModel.MessageBoxErrorStatic(ex);
            }
            
        }
    }
}
