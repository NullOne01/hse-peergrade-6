using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Peergrade6.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public static uint viewId = 0;

        public MainViewModel() {
            viewId++;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Execute(object sender, object parameter) {
            ((ICommand)sender).Execute(parameter);
        }

        public void NotifyPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
