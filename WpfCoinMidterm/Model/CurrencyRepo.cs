using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    [Serializable]
    public class CurrencyRepo : ICurrencyRepo , ISerializable 
    {
        public List<ICoin> Coins { get; set; }
        public List<ICoin> CurrencyList { get; set; }
        public double totalValue { get; set; }

        CurrencyRepo cr;

        public string About()
        {
            return "";
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
            CurrencyList = new List<ICoin>();
            CurrencyList.Add(new Penny());
            CurrencyList.Add(new DollarCoin());
            CurrencyList.Add(new HalfDollar());
            CurrencyList.Add(new Quarter());
            CurrencyList.Add(new Dime());
            CurrencyList.Add(new Nickel());
        }

        protected CurrencyRepo(SerializationInfo info, StreamingContext context)
        {
            totalValue = info.GetDouble("totalValue");
        }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as CurrencyRepo;
            if (toCompareWith == null)
                return false;
            return this.Coins == toCompareWith.Coins && this.totalValue == toCompareWith.totalValue;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            DollarCoin dollarCoin = new DollarCoin();
            HalfDollar halfDollar = new HalfDollar();
            Quarter quarter = new Quarter();
            Dime dime = new Dime();
            Nickel nickel = new Nickel();
            Penny penny = new Penny();
            cr = new CurrencyRepo();
            while (Amount > 0)
            {
                if (Math.Round(Amount, 2) - Math.Round(dollarCoin.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(dollarCoin.MonetaryValue, 2);
                    cr.AddCoin(dollarCoin);
                }

                else if (Math.Round(Amount, 2) - Math.Round(halfDollar.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(halfDollar.MonetaryValue, 2);
                    cr.AddCoin(halfDollar);
                }

                else if (Math.Round(Amount, 2) - Math.Round(quarter.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(quarter.MonetaryValue, 2);
                    cr.AddCoin(quarter);
                }

                else if (Math.Round(Amount, 2) - Math.Round(dime.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(dime.MonetaryValue, 2);
                    cr.AddCoin(dime);
                }
                else if (Math.Round(Amount, 2) - Math.Round(nickel.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(nickel.MonetaryValue, 2);
                    cr.AddCoin(nickel);
                }
                else if (Math.Round(Amount, 2) - Math.Round(penny.MonetaryValue, 2) >= 0)
                {
                    Amount = Math.Round(Amount, 2) - Math.Round(penny.MonetaryValue, 2);
                    cr.AddCoin(penny);
                }
                else
                    Amount = 0;


            }
            return cr;
        }

        //public ICurrencyRepo MakeChange(double AmountTendered, double TotaCost)
        //{
        //    return
        //}

        public ICoin RemoveCoin(ICoin c)
        {
            ICoin removedCoin = c;
            Coins.Remove(c);
            return removedCoin;
        }

        public double TotalValue()
        {
            totalValue = 0;
            for (int i = 0; i < GetCoinCount(); i++)
            {
                totalValue = totalValue + Coins[i].MonetaryValue;
            }
            return totalValue;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("totalValue", totalValue);
            info.AddValue("Coins", Coins);
        }




    }
}
