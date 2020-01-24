﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarathonSkills.View.MainPages
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            try
            {
                InitializeComponent();
                DataContext = new ViewModel.MainPagesViewModel.SecondPageViewModel(); 
            }
            catch (Exception ex)
            {
                ViewModel.HelperViewModel.HelperClassViewModel.MessageBoxErrorStatic(ex);
            }
            
        }
    }
}
