using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfCoinMidterm.Views;

namespace WpfCoinMidterm.ViewModels
{
    public class MakeChangeViewModel : ViewModelBase
    {
        private ICurrencyRepo repo;
        private double amount = 0;
        public BasicCommand basicCommand { get; private set; }
        private ObservableCollection<ICoin> vmCoins = new ObservableCollection<ICoin>();


        public MakeChangeViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
        }

        public ObservableCollection<ICoin> VMCoins
        {
            get { return vmCoins; }
            set { vmCoins = value; RaisedPropertyChanged("VMCoins"); }
        }

        public BasicCommand Ocoin
        {
            get
            {
                if(basicCommand == null)
                {
                    basicCommand = new BasicCommand(OCoin);
                }
                return basicCommand;
            }
        }

        private void OCoin()
        {
            this.repo = this.repo.MakeChange(Amount);
            for(int i = 0; i < this.repo.GetCoinCount(); i++)
            {
                vmCoins.Add(this.repo.Coins[i]);
            }
        }

        //This will represent the value the user input into the textbox
        public double Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                RaisedPropertyChanged();
                this.amount = value;
            }
        }
    }
}
