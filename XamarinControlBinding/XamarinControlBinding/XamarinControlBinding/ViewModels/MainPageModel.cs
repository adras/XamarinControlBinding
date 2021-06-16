using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinControlBinding.ViewModels
{
    public class MainPageModel : BaseViewModel
    {
        Random r = new Random();
        decimal soll = 0;
        string sollText = "Soll-Binding";
        decimal ist = 0;

        public ICommand NextCommand { get; }

        public decimal Soll
        {
            get { return soll; }
            set
            {
                SetProperty(ref soll, value);
                OnPropertyChanged("Difference");
            }
        }

        public string SollText
        {
            get { return sollText; }
            set
            {
                SetProperty(ref sollText, value);
                OnPropertyChanged("Difference");
            }
        }


        public decimal Ist
        {
            get { return ist; }
            set
            {
                SetProperty(ref ist, value);
                OnPropertyChanged("Difference");
            }
        }

        public decimal Difference
        {
            get
            {
                return soll - ist;
            }
            set
            {
            }
        }

        public MainPageModel()
        {
            NextCommand = new Command(async () => Next());
        }

        async void Next()
        {

            Soll += r.Next(0, 10);
            Ist += r.Next(0, 10);
        }
    }
}
