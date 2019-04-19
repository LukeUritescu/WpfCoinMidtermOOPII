using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfCoinMidterm;
using WpfCoinMidterm.ViewModels;
using System.ComponentModel;

namespace UnitTestCoin
{
    /// <summary>
    /// Summary description for UnitTestMakeChangeViewModel
    /// </summary>
    [TestClass]
    public class UnitTestMakeChangeViewModel
    {
        MakeChangeViewModel vm;

        public UnitTestMakeChangeViewModel()
        {
            vm = new MakeChangeViewModel(new CurrencyRepo());
        }

        [TestMethod]
        public void NotifyPropertyChanged_tests()
        {
            //Arrange
            List<string> receivedEvents = new List<string>();

            vm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };

            //Act
            //vm.RepoTotal = 1;
            //vm.OCoin(new Penny());

            //Assert

            Assert.AreEqual(receivedEvents[0], "RepoTotal");
        }
        
    }
}
