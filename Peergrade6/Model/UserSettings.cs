using Peergrade6.Model.Style;
using Peergrade6.Model.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Peergrade6.Model
{
    class UserSettings : INotifyPropertyChanged
    {
        public BaseTheme Theme { get; set; } = new DarkTheme();

        public int SaveInterval { get; set; } = 5000;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
