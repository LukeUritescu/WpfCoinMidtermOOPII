﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    
    public interface ICurrencyRepo
    {
        List<ICoin> Coins { get; set; }
        List<ICoin> CurrencyList { get; set; }
        double totalValue { get; set; }
        string About();
        void AddCoin(ICoin c);
        int GetCoinCount();
        ICurrencyRepo MakeChange(double Amount);
        //ICurrencyRepo MakeChange(double AmountTendered, double TotaCost);
        ICoin RemoveCoin(ICoin c);
        double TotalValue();



    }
}
