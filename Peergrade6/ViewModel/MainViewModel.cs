using Peergrade6.Model;
using Peergrade6.Model.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace Peergrade6.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public static uint viewId = 0;
        public MainModel model;

        public MainViewModel(Form form) {
            model = MainModel.GetInstance();
            model.formList.Add(form);
            viewId++;
            TabsList = new ObservableCollection<CodeTab>();
        }

        //Properties
        private ObservableCollection<CodeTab> tabsList;
        public ObservableCollection<CodeTab> TabsList {
            get {
                return tabsList;
            }

            set {
                tabsList = value;
                tabsList.CollectionChanged += 
                    new NotifyCollectionChangedEventHandler(
                        (sender, e) => NotifyPropertyChanged("TabsList"));
            }
        }

        public UserSettings UserSettings {
            get {
                return model.userSettings;
            }
        }

        public void ChangeTheme() {
            if (UserSettings.Theme is WhiteTheme) {
                UserSettings.Theme = new DarkTheme();
            } else {
                UserSettings.Theme = new WhiteTheme();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Execute(object sender, object parameter) {
            ((ICommand)sender).Execute(parameter);
        }

        public void NotifyPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
