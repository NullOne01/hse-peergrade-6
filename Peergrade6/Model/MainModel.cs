using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Peergrade6.Model
{
    class MainModel : INotifyPropertyChanged
    {
        private static MainModel instance;
        public UserSettings userSettings = new UserSettings();
        public List<Form> formList = new List<Form>();

        public static MainModel GetInstance() {
            if (instance == null)
                instance = new MainModel();

            return instance;
        }

        public MainModel() {
            // We need to leave it clear.
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
