using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
   [Serializable]
    public class Dime : USCoin
    {
        public Dime()
        {
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.10;
            this.Name = "Dime";

        }

        public Dime(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
            this.Name = "Dime";
        }
    }
}
