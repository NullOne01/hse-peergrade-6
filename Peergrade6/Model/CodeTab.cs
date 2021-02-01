using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text;

namespace Peergrade6.Model
{
    /// <summary>
    /// Unit of code tab to save in some table.
    /// </summary>
    public class CodeTab : INotifyPropertyChanged
    {
        // Some note: this interface and properties are needed to make binding possible.
        // Binding are needed to implement MVVM system. However, this shit sucks (as I discovored).

        public bool isRtfText = false;

        private bool wasModified = true;
        public bool WasModified {
            get {
                return wasModified;
            }
            set {
                wasModified = value;
                NotifyPropertyChanged("FileName");
                NotifyPropertyChanged("ModifiedFileName");
            }
        }

        public CodeTab() {
        }

        public CodeTab(string fileName, string text, string path, bool isRtfText = false, bool wasModified = true) {
            FileName = fileName;
            Text = text;
            Path = path;

            this.isRtfText = isRtfText;
            this.wasModified = wasModified;
        }

        private string fileName = "blank";
        public string FileName {
            get {
                return fileName;
            }
            set {
                fileName = value;
                NotifyPropertyChanged("FileName");
                NotifyPropertyChanged("ModifiedFileName");
            }
        }

        private string text = "";
        public string Text {
            get {
                return text;
            }
            set {
                wasModified = true;
                text = value;
                NotifyPropertyChanged("Text");
            }
        }

        private string path = "";
        public string Path {
            get {
                return path;
            }
            set {
                path = value;
                NotifyPropertyChanged("Path");
            }
        }

        public void NotifyPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Returns fileName with (*) symbol, if file was modified.
        /// </summary>
        public string ModifiedFileName => fileName + (wasModified ? "(*)" : "");

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
