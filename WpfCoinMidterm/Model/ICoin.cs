using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    public interface ICoin : ICurrency
    {
        int Year { get; set; }
    }
}
