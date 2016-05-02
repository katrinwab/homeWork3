using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MVVMExample.Model.Coin;
using MVVMExample.Model.Drink;
using MVVMExample.Model.Provider;

namespace MVVMExample
{
    class ViewModel : INotifyPropertyChanged
    {
        public ICommand ClickCommand { get; set; }
        public ICommand BuyCommand { get; set; }

        private List<Coin> _listCoins; 
        public List<Coin> Coins
        {
            get
            {
                return _listCoins;
            }
            set
            {
                _listCoins = value;
            }
        }

        private List<Drink> _listDrinks; 

        public List<Drink> Drinks
        {
            get
            {
                return _listDrinks;
            }
            set
            {
                if (_listDrinks != value)
                {
                    _listDrinks = value;
                    OnPropertyChanged("Drinks");
                }
            }
        }

        private int _balance;
        public int Balance
        {
            get { return _balance; }
            set
            {
                if (_balance != value)
                {
                    _balance = value;
                    OnPropertyChanged("Balance");
                }
            }
        }  

        public int SelectedIndexCoin { get; set; }
        public int SelectedIndexDrink { get; set; }    

        
        public ViewModel()
        {
            ClickCommand = new RelayCommand(arg => ClickMethod());
            BuyCommand = new RelayCommand(arg => BuyMethod());

            var uc = new UnityContainer();
            uc.LoadConfiguration("");
            var providerDrink = uc.Resolve<IProvider>();
            Drinks = providerDrink.GetInformation().Select(item => item as Drink).ToList();
            Drinks = Drinks.Where(drink => drink.Count > 0).OrderBy(x => x.Cost).ToList();

            uc.LoadConfiguration("CoinXml");
            var providerCoin = uc.Resolve<IProvider>();
            Coins = providerCoin.GetInformation().Select(item => item as Coin).ToList();
            Coins = Coins.OrderBy(x => x.Rating).ToList();

            Balance = 0;
            SelectedIndexCoin = 0;
            SelectedIndexDrink = 0;
            

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ClickMethod()
        {
            if (SelectedIndexCoin >= 0 && SelectedIndexCoin <= Coins.Count && !Coins[SelectedIndexCoin].IsBlocked)
                Balance += Coins[SelectedIndexCoin].Rating;
        }

        private void BuyMethod()
        {
            if (SelectedIndexDrink >= 0 && SelectedIndexDrink <= Drinks.Count && Drinks[SelectedIndexCoin].Count > 0)
            {
                Balance -= Drinks[SelectedIndexDrink].Buy();
                Drinks = Drinks.Where(drink => drink.Count > 0).OrderBy(x => x.Cost).ToList();
            }
        }

        public void ButtonClicked(object ob, RoutedEventArgs eventArgs)
        {
            BuyMethod();
        }
    }
}
