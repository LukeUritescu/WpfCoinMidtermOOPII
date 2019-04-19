using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm.ViewModels
{
    public class CurrencyRepoViewModel : ViewModelBase
    {
        private ICurrencyRepo repo;

        private ObservableCollection<ICoin> coinsForcbCoins;
        public ObservableCollection<ICoin> CoinsforcdCoins
        {
            get { return coinsForcbCoins; }
            set { coinsForcbCoins = value; }
        }
        
        

        public CurrencyRepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;

        }
    }
}
