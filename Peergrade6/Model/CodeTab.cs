using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Peergrade6.Model
{
    class CodeTab : INotifyPropertyChanged
    {
        public CodeTab() {
        }
        public CodeTab(string fileName, string text, string path) {
            FileName = fileName;
            Text = text;
            Path = path;
        }

        private string fileName = "blank";
        public string FileName {
            get {
                return fileName;
            }
            set {
                fileName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FileName"));
            }
        }

        private string text = "";
        public string Text {
            get {
                return text;
            }
            set {
                text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
            }
        }

        private string path = "";        
        public string Path {
            get {
                return path;
            }
            set {
                path = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Path"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
