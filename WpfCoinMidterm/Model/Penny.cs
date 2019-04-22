using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    
    public class Penny : USCoin
    {
        public Penny()
        {
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.01;
            this.Name = "Penny";
        }

        public Penny(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.01;
            this.Name = "Penny";
        }
    }
}
