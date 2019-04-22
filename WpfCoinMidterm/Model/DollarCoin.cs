using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
   
    public class DollarCoin : USCoin
    {
        public DollarCoin()
        {
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 1.00;
            this.Name = "Dollar Coin";
        }

        public DollarCoin(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 1.00;
            this.Name = "Dollar Coin";
        }
    }
}
//sustem.date.time.yeare