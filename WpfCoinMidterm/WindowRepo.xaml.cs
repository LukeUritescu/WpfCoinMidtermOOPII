using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfCoinMidterm.ViewModels;

namespace WpfCoinMidterm
{
    /// <summary>
    /// Interaction logic for WindowRepo.xaml
    /// </summary>
    public partial class WindowRepo : Window
    {
        private static CurrencyRepo repo;
        public static CurrencyRepo Repo
        {
            get
            {
                return repo;
            }
            set { repo = value; }
        }

        public WindowRepo(CurrencyRepo repo)
        {
            InitializeComponent();
            CurrencyRepoViewModel repoVM = new CurrencyRepoViewModel(repo);

            UserControlRepo1.DataContext = repoVM;
        }

        private void UserControlRepo1_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlRepo1.cbCoinName.SelectedIndex = 0;
        }

        
    }
}
