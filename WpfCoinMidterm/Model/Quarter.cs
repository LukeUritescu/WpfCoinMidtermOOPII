using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    [Serializable]
    public class Quarter : USCoin
    {
        public Quarter()
        {
            this.MintMark = USCoinMintMark.D;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.25;
            this.Name = "Quarter";
        }

        public Quarter(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
            this.MonetaryValue = 0.25;
            this.Name = "Quarter";
        }
    }
}
