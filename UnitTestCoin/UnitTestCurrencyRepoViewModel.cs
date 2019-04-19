using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfCoinMidterm.ViewModels;
using WpfCoinMidterm;
using System.Collections.ObjectModel;

namespace UnitTestCoin
{
    /// <summary>
    /// Summary description for UnitTestCurrencyRepo
    /// </summary>
    [TestClass]
    public class UnitTestCurrencyRepoViewModel
    {

        ICurrencyRepo repo;
        CurrencyRepoViewModel vm;

        public UnitTestCurrencyRepoViewModel()
        {

        }

        [TestMethod]
        public void Coins_For_ComboBoxCoins_Collections_AreSame()
        {
            //Arrange
            repo = new CurrencyRepo();
            vm = new CurrencyRepoViewModel(repo);

            ObservableCollection<ICoin> testCoinsforcdCoins;

            //Act
            testCoinsforcdCoins = vm.CoinsforcdCoins;
            //Assert
            CollectionAssert.AreEqual(((CurrencyRepo)repo).Coins, testCoinsforcdCoins);

        }
    }
}
