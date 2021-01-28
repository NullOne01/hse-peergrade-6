using Peergrade6.Model.Style;
using Peergrade6.Utilities.UI;
using Peergrade6.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peergrade6
{
    public partial class MainForm : Form
    {
        private MainViewModel viewModel;
        private BaseTheme prevTheme;

        public MainForm() {
            InitializeComponent();
            InitializeControlHandlers();
            ApplyStyle();
        }

        /// <summary>
        /// Method 
        /// </summary>
        private void InitializeControlHandlers() {
            viewModel = new MainViewModel(this);
            prevTheme = viewModel.UserSettings.Theme;
            AddTab();
        }

        public void AddTab(string title = "blank", string text = "", string path = "") {
            RichTab newRichTab = new RichTab();
            tabControl.TabPages.Add(newRichTab);
            viewModel.TabsList.Add(new Model.CodeTab(title, text, path));
            int newIndex = viewModel.TabsList.Count - 1;

            // Title.
            newRichTab.DataBindings.Add(new Binding("Text", viewModel.TabsList[newIndex], "FileName"));
            newRichTab.Text = viewModel.TabsList[newIndex].FileName;

            // Text body.
            newRichTab.textBox.DataBindings.Add(
                new Binding("Text", viewModel.TabsList[newIndex], "Text",
                true, DataSourceUpdateMode.OnPropertyChanged));
            ApplyStyleTabs();
        }

        public void ForceRemoveCurrentTab() {
            int currentTabInd = tabControl.SelectedIndex;
            tabControl.TabPages.RemoveAt(currentTabInd);
            viewModel.TabsList.RemoveAt(currentTabInd);
        }

        public void RemoveCurrentTab() {
            ForceRemoveCurrentTab();
        }

        private void debugTimer_Tick(object sender, EventArgs e) {
            if (viewModel.TabsList.Count >= 1) {
                System.Diagnostics.Debug.WriteLine($"Title: {viewModel.TabsList[0].FileName}");
                System.Diagnostics.Debug.WriteLine($"Text: {viewModel.TabsList[0].Text}");
            }
        }

        private void fileStripMenuItem1_Click(object sender, EventArgs e) {
            viewModel.ChangeTheme();
            System.Diagnostics.Debug.WriteLine($"Theme changed! Now: {viewModel.UserSettings.Theme.GetType()}");
        }

        private void fileStripMenuItem2_Click(object sender, EventArgs e) {
            AddTab();
        }
        private void fileStripMenuItem3_Click(object sender, EventArgs e) {
            AddTab();
        }
        private void fileStripMenuItem4_Click(object sender, EventArgs e) {
            AddTab();
        }
        private void fileStripMenuItem5_Click(object sender, EventArgs e) {
            AddTab();
        }

        private void fileStripMenuItem6_Click(object sender, EventArgs e) {
            string fileName = "";
            string fileContent = "";
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream)) {
                        fileContent = reader.ReadToEnd();
                    }

                    AddTab(fileName, fileContent, filePath);
                }
            }
        }
        private void fileStripMenuItem7_Click(object sender, EventArgs e) {
            AddTab();
        }

        private void optionsStripMenuItem1_Click(object sender, EventArgs e) {
            viewModel.ChangeTheme();
            System.Diagnostics.Debug.WriteLine($"Theme changed! Now: {viewModel.UserSettings.Theme.GetType()}");
        }

        private void styleTimer_Tick(object sender, EventArgs e) {
            // I couldn't bind style (idk why), so I use timer instead.
            if (prevTheme == viewModel.UserSettings.Theme)
                return;
            System.Diagnostics.Debug.WriteLine($"New theme applied!");
            prevTheme = viewModel.UserSettings.Theme;
            ApplyStyle();
        }

        private void ApplyStyle() {
            SetAllControlsColors(this);
            ApplyStyleTabs();
            ApplyStyleMenu();
        }

        private void ApplyStyleTabs() {
            // Custom tabs.
            foreach (RichTab tab in tabControl.Controls) {
                tab.textBox.ForeColor = viewModel.UserSettings.Theme.AssistColor;
                tab.textBox.BackColor = viewModel.UserSettings.Theme.BackgroundColor;
            }
        }

        private void ApplyStyleMenu() {
            // Custom menu.
            foreach (ToolStripMenuItem child in menuStrip.Items) {
                foreach (ToolStripItem subChild in child.DropDownItems) {
                    subChild.ForeColor = viewModel.UserSettings.Theme.AssistColor;
                    subChild.BackColor = viewModel.UserSettings.Theme.BackgroundColor;
                }
                child.ForeColor = viewModel.UserSettings.Theme.AssistColor;
            }
        }

        /// <summary>
        /// Reset all the controls to the user's default Control color. 
        /// </summary>
        /// <param name="control"></param>
        private void SetAllControlsColors(Control control) {
            control.BackColor = viewModel.UserSettings.Theme.BackgroundColor;
            control.ForeColor = viewModel.UserSettings.Theme.ForegroundColor;

            if (control.HasChildren) {
                // Recursively call this method for each child control.
                foreach (Control childControl in control.Controls) {
                    SetAllControlsColors(childControl);
                }
            }
        }

        private void tabsContextMenuStrip_Opening(object sender, CancelEventArgs e) {
            Point p = this.tabControl.PointToClient(Cursor.Position);
            for (int i = 0; i < this.tabControl.TabCount; i++) {
                Rectangle r = this.tabControl.GetTabRect(i);
                if (r.Contains(p)) {
                    this.tabControl.SelectedIndex = i; // i is the index of tab under cursor
                    return;
                }
            }
            e.Cancel = true;
        }

        private void tabsStripMenuItem1_Click(object sender, EventArgs e) {
            RemoveCurrentTab();
        }
    }
}
