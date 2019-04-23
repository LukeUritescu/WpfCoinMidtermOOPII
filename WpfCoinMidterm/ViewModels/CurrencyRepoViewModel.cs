using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCoinMidterm.Model;

namespace WpfCoinMidterm.ViewModels
{
    public class CurrencyRepoViewModel : ViewModelBase
    {
        private ICurrencyRepo repo;
        private SaveableCurrencyRepo saveRepo;
        private ICoin coinName;
        private int coinNum;
        public ICoin CoinName
        {
            get { return this.coinName; }
            set
            {
                RaisedPropertyChanged();
                this.coinName = value;
            }
        }

        private ObservableCollection<ICoin> coinsForcbCoins;
        public ObservableCollection<ICoin> CoinsForcdCoins
        {
            get { return coinsForcbCoins; }
            set { coinsForcbCoins = value; RaisedPropertyChanged("CoinsForcdCoins"); }
        }

        public BasicCommand basicCommand { get; private set; }
        
        

        public CurrencyRepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            CoinsForcdCoins = new ObservableCollection<ICoin>(this.repo.CurrencyList);
        }

        public BasicCommand NewRepo
        {
            get
            {
                basicCommand = new BasicCommand(newRepo);
                return basicCommand;
            }
        }

        public void newRepo()
        {
            this.repo.Coins = new List<ICoin>();
            RaisedPropertyChanged("RepoTotal");
        }


        public BasicCommand SaveCoin
        {
            get
            {
                basicCommand = new BasicCommand(saveCoin);
                return basicCommand;
            }
        }

        public void saveCoin()
        {
            saveRepo = new SaveableCurrencyRepo(this.repo.Coins);
            this.saveRepo.Save();
        }

        public BasicCommand LoadCoin
        {
            get
            {
                basicCommand = new BasicCommand(loadCoin);
                return basicCommand;
            }
        }

        public void loadCoin()
        {
            saveRepo = new SaveableCurrencyRepo(this.repo.Coins);
            this.repo.Coins = this.saveRepo.Load();
            RaisedPropertyChanged("RepoTotal");

        }

        public BasicCommand AddCoinCommand
        {
            get
            {        
                basicCommand = new BasicCommand(addCoin);
                return basicCommand;
            }
        }

        public void addCoin()
        {
            for(int i = 0; i < CoinNum; i++)
            {
                this.repo.AddCoin(CoinName);
            }
            RaisedPropertyChanged("RepoTotal");
        }

        public double RepoTotal
        {
            get { return this.repo.TotalValue(); }
        }

        public int CoinNum
        {
            get
            {
                return this.coinNum;
            }

            set
            {
                RaisedPropertyChanged("CoinNum");
                this.coinNum = value;
            }
        }
    }
}
