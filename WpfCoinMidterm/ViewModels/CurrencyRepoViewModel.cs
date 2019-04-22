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
            set { coinsForcbCoins = value; RaisedPropertyChanged("CoinsForCBCoins"); }
        }

        public BasicCommand basicCommand { get; private set; }
        
        

        public CurrencyRepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            CoinsForcdCoins = new ObservableCollection<ICoin>(this.repo.CurrencyList);
            this.repo.AddCoin(new Penny());
            this.repo.totalValue = this.repo.TotalValue();
        }

        //public async Task<double> GetVAsync()
        //{
        //    double l = await GetVAsync();
        //    return this.repo.TotalValue();
        //}

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
            this.saveRepo.Load();
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
            this.repo.totalValue = this.repo.TotalValue();
        }

        public double RepoTotal
        {
            get { return this.repo.totalValue; }
            set
            {
                RaisedPropertyChanged();
                this.repo.totalValue = value;
            }
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
