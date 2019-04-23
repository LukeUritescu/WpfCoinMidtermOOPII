using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    [Serializable]
    public class HalfDollar : USCoin
    {
        public HalfDollar()
        {
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.50;
            this.Name = "HalfDollar Coin";
        }

        public HalfDollar(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.50;
            this.Name = "HalfDollar Coin";
        }

    }
}
