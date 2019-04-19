using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    [Serializable]
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark;
        public string About()
        {
            return $"US {Name} is from {Year}. It is worth ${MonetaryValue}. It was made in Denver";
        }

        public USCoin()
        {
            this.Year = System.DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;

        }

        public USCoin(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.Year = System.DateTime.Now.Year;
        }


        public static string GetMintNameFromMark(USCoinMintMark m)
        {
            if (m == USCoinMintMark.D)
            {
                return "Denver";
            }

            else if (m == USCoinMintMark.P)
            {
                return "Philadelphia";
            }

            else if (m == USCoinMintMark.S)
            {
                return "San Francisco";
            }
            else
            {
                return "West Point";
            }
        }
    }
}
