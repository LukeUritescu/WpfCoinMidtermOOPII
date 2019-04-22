﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfCoinMidterm.ViewModels;

namespace WpfCoinMidterm.Views
{
    /// <summary>
    /// Interaction logic for UserControlRepoTest.xaml
    /// </summary>
    public partial class UserControlRepoTest : UserControl
    {

        public UserControlRepoTest()
        {
            InitializeComponent();
            this.DataContext = new CurrencyRepoViewModel(new CurrencyRepo());

        }
    }
}
