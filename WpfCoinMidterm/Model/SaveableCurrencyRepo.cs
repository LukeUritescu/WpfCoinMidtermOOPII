using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WpfCoinMidterm.Model
{
    [Serializable]
    public class SaveableCurrencyRepo : CurrencyRepo
    {
        public string Path { get; set; }

        public SaveableCurrencyRepo(List<ICoin> coins)
        {
            Path = "MyFile.bin";
            this.Coins = coins;
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Coins);
            stream.Close();
        }

        public List<ICoin> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<ICoin> coins = (List<ICoin>) formatter.Deserialize(stream);
            stream.Close();
            return coins;
        }
    }
}
