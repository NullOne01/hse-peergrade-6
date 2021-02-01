using Peergrade6.Model.Style;
using Peergrade6.Model.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Text;

namespace Peergrade6.Model
{
    class UserSettings : INotifyPropertyChanged
    {
        public BaseTheme Theme { get; set; } = new DarkTheme();

        public int SaveInterval { get; set; } = 5000;

        // We might need to bind these values, so this event should be here.
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
