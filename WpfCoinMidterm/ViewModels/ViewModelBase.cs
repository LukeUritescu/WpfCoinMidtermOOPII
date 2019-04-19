using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfCoinMidterm.ViewModels
{
    public abstract class ViewModelBase : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected virtual void RaisedPropertyChanged([CallerMemberName]string propertyName = "")
        {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
