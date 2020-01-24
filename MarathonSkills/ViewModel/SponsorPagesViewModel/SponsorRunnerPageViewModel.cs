using MarathonSkills.ViewModel.HelperViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MarathonSkills.ViewModel.SponsorPagesViewModel
{
    class SponsorRunnerPageViewModel : HelperViewModel.HelperClassViewModel
    {
        #region Свойства

        public static int SumDonationStatic { get; set; }

        public static NewRunner SelectedRunnerStatic { get; set; }

        private string name, ownerCard, numberCard, mouthEnd, yearEnd, _CVC;

        private int sumDonation;

        public int SumDonation
        {
            get => this.sumDonation;
            set => Set<int>(ref sumDonation, value); 
        }

        public string Name
        {
            get => this.name;
            set => Set<string>(ref name , value);
        }

        public string OwnerCard
        {
            get => this.ownerCard;
            set => Set<string>(ref ownerCard, value);
        }

        public string NumberCard
        {
            get => this.numberCard;
            set => Set<string>(ref numberCard, value);
        }

        public string YearEnd
        {
            get => this.yearEnd; 
            set => Set<string>(ref yearEnd, value);
        }

        public string MouthEnd
        {
            get => this.mouthEnd;
            set => Set<string>(ref mouthEnd, value); 
        }

        public string CVC
        {
            get => this._CVC;
            set => Set<string>(ref _CVC, value);
        }

        

        public ICommand PayCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand MinCommand { get; set; }
        public ICommand PlusCommand { get; set; }

        public List<NewRunner> ListRunners { get; set; }

        public NewRunner selectedRunner; 
        public NewRunner SelectedRunner
        {
            get => this.selectedRunner;
            set => Set<NewRunner>(ref selectedRunner, value); 
        }

        public int selectedIndex; 
        public int SelectedIndex
        {
            get => this.selectedIndex;
            set => Set<int>(ref selectedIndex, value); 
        }

        #endregion 


        public SponsorRunnerPageViewModel()
        {
            try
            {
                this.PayCommand = new Command(PayCommandClick);
                this.CancelCommand = new Command(CancelCommandClick);
                this.MinCommand = new Command(MinCommandClick);
                this.PlusCommand = new Command(PlusCommandClick);

                this.ListRunners = this.context.Runner.Select(i => new NewRunner()
                {
                    Runner = i 
                }).ToList();

                
            }
            catch (Exception ex)
            {
                this.MessageBoxError(ex); 
            }
        }

       

        #region Обработчики кнопок

        //обработчик кнопки Отмена
        private void CancelCommandClick(object obj)
        {
            try
            {
                ViewModel.HelperViewModel.HelperClassViewModel.SetPage(new View.MainPages.FirstPage());
            }
            catch (Exception ex)
            {

                this.MessageBoxError(ex);
            }
        }

        //обработчик кнопки Заплатить
        private void PayCommandClick(object obj)
        {
            try
            {
                if (this.CheckingField())
                {
                    SumDonationStatic = this.SumDonation;
                    SelectedRunnerStatic = this.SelectedRunner; 
                    SetPageSecondPage(new View.SponsorPages.SponsorshipConfirmationPage());
                }
            }
            catch (Exception ex)
            {
                this.MessageBoxError(ex); 
            }
        }

        //плюс и минус
        private void PlusCommandClick(object obj)
        {
            this.SumDonation += 10; 
        }

        private void MinCommandClick(object obj)
        {
            this.SumDonation -= 10;
            if (this.SumDonation < 0)
            {
                this.SumDonation = 0; 
            }
        }




        #endregion


        #region Методы

        private bool CheckingField()
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(OwnerCard) ||
                 string.IsNullOrWhiteSpace(NumberCard) || string.IsNullOrWhiteSpace(YearEnd)
                || string.IsNullOrWhiteSpace(MouthEnd) || string.IsNullOrWhiteSpace(CVC)  
                )
            {
                this.MessageBoxWarning("Все поля должны быть заполнены");
                return false; 
            }

            if (SelectedRunner == null)
            {
                this.MessageBoxWarning("Выберите бегуна");
                return false;
            }
            

            if (NumberCard.Length != 19)
            {
                this.MessageBoxWarning("Введите номер карты в формате - 1234 1234 1234 1234");
                this.NumberCard = "";
                return false; 
            }

            if (DateTime.TryParse($"01/{this.MouthEnd}/{this.YearEnd}",out DateTime result))
            {
                if (DateTime.Compare(result, DateTime.Now) >= 0)
                {
                    this.MessageBoxWarning("Срок действия карты не действителен");
                    return false; 
                }
            }
            else
            {
                this.MessageBoxWarning("Срок действия карты имеет неверный формат");
                this.MouthEnd = "";
                this.YearEnd = "";
                return false; 
            }

            MessageBox.Show(CVC);

            if (CVC.Length < 3 && int.TryParse(CVC, out int res))
            {
                this.MessageBoxWarning("CVC состоит из 3 чисел");
                return false;
            }
           
           

            return true; 


        }

        #endregion 


    }

    public class NewRunner
    {
        public Model.Runner Runner; 

        public string InformationAboutRunner
        {
            get
            {
                return $"{Runner.User.FirstName} {Runner.User.LastName} " +
                    $"{Runner.CountryCode} - ({Runner.Country.CountryName})"; 
            }
        }
    }
}
