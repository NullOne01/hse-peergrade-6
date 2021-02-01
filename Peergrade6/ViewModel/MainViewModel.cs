using Peergrade6.Model;
using Peergrade6.Model.Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Input;

namespace Peergrade6.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public static uint viewId = 0;
        public MainModel model;

        // Some note: this interface and properties are needed to make binding possible.
        // Binding are needed to implement MVVM system. However, this shit sucks (as I've discovored).

        public MainViewModel(Form form) {
            model = MainModel.GetInstance();
            model.formList.Add(form);
            TabsList = new ObservableCollection<CodeTab>();

            if (viewId <= 0)
                LoadSettingsJSON();

            viewId++;
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

        /// <summary>
        /// Simple switch between dark and white themes.
        /// </summary>
        public void ChangeTheme() {
            if (UserSettings.Theme.Name == "WhiteTheme") {
                UserSettings.Theme = new DarkTheme();
            } else {
                UserSettings.Theme = new WhiteTheme();
            }
        }

        /// <summary>
        /// Sets default font. lel.
        /// </summary>
        /// <param name="font"> Some font. </param>
        public void SetDefaultFont(Font font) {
            UserSettings.Theme.DefaultTabFont = font;
        }

        public List<Form> FormList{
            get => model.formList;
            set => model.formList = value;
        }

        /// <summary>
        /// Save's user's options into json files.
        /// </summary>
        /// <returns> True if success. </returns>
        public bool SaveSettingsJSON() {
            try {
                File.WriteAllText("UserSettings.json", JsonSerializer.Serialize(model.userSettings));
                File.WriteAllText("Tabs.json", JsonSerializer.Serialize(TabsList));
                return true;
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Reads user's options from json files.
        /// </summary>
        /// <returns> True if success. </returns>
        public bool LoadSettingsJSON() {
            try {
                string jsonText = File.ReadAllText("UserSettings.json");
                model.userSettings = JsonSerializer.Deserialize<UserSettings>(jsonText);

                jsonText = File.ReadAllText("Tabs.json");
                TabsList = JsonSerializer.Deserialize<ObservableCollection<CodeTab>>(jsonText);

                return true;
            } catch {
                model.userSettings = new UserSettings();
                TabsList = new ObservableCollection<CodeTab>();
                return false;
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
