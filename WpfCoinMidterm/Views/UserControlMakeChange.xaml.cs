﻿using System;
using System.Collections.Generic;
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
    /// Interaction logic for UserControlMakeChange.xaml
    /// </summary>
    public partial class UserControlMakeChange : UserControl
    {
        public UserControlMakeChange()
        {
            InitializeComponent();
            this.DataContext = new MakeChangeViewModel(new CurrencyRepo());
        }
    }
}
