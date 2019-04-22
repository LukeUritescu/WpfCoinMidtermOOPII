using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm
{
    [Serializable]
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }
        public double MonetaryValue { get; set; }
        public string Name { get; set; }
        //System.DateTime.Now.Year
        public virtual string About()
        {
            return $"US {Name} is from {Year}. It is worth ${MonetaryValue}. It was made in Denver\n";
        }

        public Coin()
        {
            this.Year = 2019;
        }

        public Coin(SerializationInfo info, StreamingContext context)
        {
            Year = info.GetInt32("Year");
            MonetaryValue = info.GetDouble("Monetary Value");
            Name = info.GetString("Name");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Year", Year);
            info.AddValue("Monetary Value", MonetaryValue);
            info.AddValue("Name", Name);
        }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as Coin;
            if (toCompareWith == null)
            {
                return false;
            }
            return this.Name == toCompareWith.Name && this.Year == toCompareWith.Year && this.MonetaryValue == toCompareWith.MonetaryValue;
        }

        //public override int GetHashCode()
        //{
        //    return this.GetHashCode();
        //}
    }
}
