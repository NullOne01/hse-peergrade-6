using Peergrade6.Model;
using Peergrade6.Model.Style;
using Peergrade6.Utilities.UI;
using Peergrade6.View;
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
        private Font prevDefaultFont;

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
            prevDefaultFont = viewModel.UserSettings.Theme.DefaultTabFont;
            autoSaveTimer.Interval = viewModel.UserSettings.SaveInterval;

            if (viewModel.TabsList.Count <= 0) {
                // If no tabs were saved.
                AddTab(new CodeTab());
            } else {
                FillTabs();
            }
        }

        /// <summary>
        /// Reading saved list of CodeTab and printig it on view.
        /// </summary>
        private void FillTabs() {
            foreach (CodeTab tab in viewModel.TabsList) {
                AddTab(tab, false);
            }
        }

        /// <summary>
        /// Just print tab. If addToList == false, then new tab won't be added into model.
        /// </summary>
        /// <param name="newCodeTab"> New tab. </param>
        /// <param name="addToList"> Will our tab be added into model? </param>
        public void AddTab(CodeTab newCodeTab, bool addToList = true) {
            RichTab newRichTab = new RichTab(newCodeTab);
            if (addToList)
                viewModel.TabsList.Add(newCodeTab);
            tabControl.TabPages.Add(newRichTab);

            // Title.
            newRichTab.DataBindings.Add(new Binding("Text", newCodeTab, "ModifiedFileName"));
            newRichTab.Text = newCodeTab.ModifiedFileName;

            // Text body.
            // Binding doesn't work properly with Rtf. Fuck my life.
            newRichTab.textBox.DataBindings.Add(
                new Binding("Text", newCodeTab, "Text",
                true, DataSourceUpdateMode.OnPropertyChanged));

            ApplyStyleTabs();
            ApplyFontTabs();
        }

        /// <summary>
        /// Removes current tab without dialog.
        /// </summary>
        public void ForceRemoveCurrentTab() {
            int currentTabInd = tabControl.SelectedIndex;
            tabControl.TabPages.RemoveAt(currentTabInd);
            viewModel.TabsList.RemoveAt(currentTabInd);
        }

        /// <summary>
        /// Closes current tab. If closing was cancel, then return false.
        /// </summary>
        /// <returns> True if was removed. False if canceled.</returns>
        public bool RemoveCurrentTab() {
            CodeTab currentTab = viewModel.TabsList[tabControl.SelectedIndex];
            if (!currentTab.WasModified) {
                ForceRemoveCurrentTab();
                return true;
            }

            ExitSaveDialog exitSaveDialog = new ExitSaveDialog();

            // Replaces {0} with FileName.
            exitSaveDialog.saveFileText.Text =
                string.Format(exitSaveDialog.saveFileText.Text, currentTab.FileName);

            exitSaveDialog.ShowDialog();

            switch (exitSaveDialog.DialogResult) {
                case DialogResult.Yes:
                    if (SaveCurrentTab())
                        ForceRemoveCurrentTab();
                    else
                        return false;

                    break;
                case DialogResult.No:
                    ForceRemoveCurrentTab();
                    break;
                case DialogResult.Cancel:
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Save current file without dialog.
        /// </summary>
        /// <returns> True, if saving was successful.</returns>
        private bool ForceSaveCurrentFile() {
            return ForceSaveFile(tabControl.SelectedIndex);
        }
        /// <summary>
        /// Saving without dialog printed tab with index.
        /// </summary>
        /// <param name="tabIndex"> Index of tab. </param>
        /// <returns> True if saving was successful. </returns>
        private bool ForceSaveFile(int tabIndex) {
            try {
                CodeTab currentTab = viewModel.TabsList[tabIndex];
                RichTab viewCurrentTab = (RichTab)tabControl.TabPages[tabIndex];
                string path = currentTab.Path;
                if (path.Length <= 0)
                    return false;
                File.WriteAllText(path, currentTab.Text);

                // Some quick bug fix.
                int caretPos = viewCurrentTab.textBox.SelectionStart;
                int caretLength = viewCurrentTab.textBox.SelectionLength;
                currentTab.WasModified = false;
                viewCurrentTab.textBox.Select(caretPos, caretLength);

                return true;
            }
            catch {
                return false;
            }
        }

        /// <summary>
        /// Save current file with dialog.
        /// </summary>
        /// <returns> True if success. </returns>
        private bool SaveCurrentFileDialog() {
            return SaveFileDialog(tabControl.SelectedIndex);
        }

        /// <summary>
        /// Save printed tab with index.
        /// </summary>
        /// <param name="tabIndex"> Index of the tab. </param>
        /// <returns> True if success. </returns>
        private bool SaveFileDialog(int tabIndex) {
            Stream myStream;
            using SaveFileDialog saveFileDialog = new SaveFileDialog();
            CodeTab selectedTab = viewModel.TabsList[tabIndex];

            saveFileDialog.Filter = "Файл без форматирования (*.*;*.txt;*.cs)|*.*;*.txt;*.cs|Файл с форматированием (*.*;*.rtf)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = selectedTab.FileName;
            saveFileDialog.Title = $"Сохранение вкладки: {selectedTab.FileName}";

            // If using .rtf, then we should choose saving with format as default.
            saveFileDialog.FilterIndex = selectedTab.isRtfText ? 2 : 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                RichTab currentTab = (RichTab)tabControl.TabPages[tabIndex];
                if ((myStream = saveFileDialog.OpenFile()) != null) {
                    switch (saveFileDialog.FilterIndex) {
                        case 1:
                            currentTab.textBox.SaveFile(myStream, RichTextBoxStreamType.PlainText);
                            break;
                        case 2:
                            currentTab.textBox.SaveFile(myStream, RichTextBoxStreamType.RichText);
                            break;
                    }

                    selectedTab.WasModified = false;
                    selectedTab.FileName = Path.GetFileName(saveFileDialog.FileName);
                    selectedTab.Path = saveFileDialog.FileName;


                    myStream.Close();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Saves current tab. Returns true if file was saved.
        /// </summary>
        /// <returns> True if file was saved. Otherwise false.</returns>
        private bool SaveCurrentTab() {
            if (ForceSaveCurrentFile())
                return true;
            if (SaveCurrentFileDialog())
                return true;
            return false;
        }

        /// <summary>
        /// Saves tab with index. Returns true if file was saved.
        /// </summary>
        /// <returns> True if file was saved. Otherwise false.</returns>
        private bool SaveTab(int index) {
            if (ForceSaveFile(index))
                return true;
            if (SaveFileDialog(index))
                return true;
            return false;
        }

        /// <summary>
        /// Opening new file in a new tab. Dialog is shown.
        /// </summary>
        private void OpenNewFileDialog() {
            string fileName = "";
            string fileContent = "";
            string filePath = "";

            using OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|other shit (*.*)|(*.*)";
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

                // If user chose .rtf, then we need to save this file as .rtf. wow.
                CodeTab newTab = new CodeTab(fileName, fileContent, filePath,
                    fileName.ToLower().EndsWith(".rtf"), false);
                AddTab(newTab);
            }
        }

        private void fileNewWindowStripMenuItem_Click(object sender, EventArgs e) {
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        private void fileNewTabStripMenuItem_Click(object sender, EventArgs e) {
            AddTab(new CodeTab());
        }
        private void fileSaveStripMenuItem_Click(object sender, EventArgs e) {
            SaveCurrentTab();
        }
        private void fileSaveAllStripMenuItem_Click(object sender, EventArgs e) {
            for (int i = 0; i < viewModel.TabsList.Count; i++) {
                SaveTab(i);
            }
        }
        private void fileSaveAsStripMenuItem_Click(object sender, EventArgs e) {
            // Save as.
            SaveCurrentFileDialog();
        }

        private void fileOpenStripMenuItem_Click(object sender, EventArgs e) {
            OpenNewFileDialog();
        }
        private void fileCloseAllStripMenuItem_Click(object sender, EventArgs e) {
            CloseAllForms();
        }

        private void defaultFontStripMenuItem_Click(object sender, EventArgs e) {
            using FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                viewModel.SetDefaultFont(fontDialog.Font);
            }
        }

        private void optionsThemeStripMenuItem_Click(object sender, EventArgs e) {
            viewModel.ChangeTheme();
        }

        private void optionsSaveStripMenuItem_Click(object sender, EventArgs e) {
            ChangeSaveInterval();
        }

        /// <summary>
        /// Calling dialog to change auto save interval.
        /// </summary>
        private void ChangeSaveInterval() {
            using SaveIntervalDialog saveIntervalDialog = new SaveIntervalDialog();
            saveIntervalDialog.intervalNumericUpDown.Value = viewModel.UserSettings.SaveInterval;
            saveIntervalDialog.ShowDialog();

            if (saveIntervalDialog.DialogResult == DialogResult.OK) {
                viewModel.UserSettings.SaveInterval = (int)saveIntervalDialog.intervalNumericUpDown.Value;
            }
        }

        private void styleTimer_Tick(object sender, EventArgs e) {
            // I couldn't bind timer interval. It is not possible. This shit sucks.
            autoSaveTimer.Interval = viewModel.UserSettings.SaveInterval;

            // I couldn't bind style, so I've used timer instead.
            if (prevTheme != viewModel.UserSettings.Theme) {
                System.Diagnostics.Debug.WriteLine($"New theme applied!");
                prevTheme = viewModel.UserSettings.Theme;
                ApplyStyle();
            }

            if (prevDefaultFont != viewModel.UserSettings.Theme.DefaultTabFont.font) {
                System.Diagnostics.Debug.WriteLine($"New font applied!");
                prevDefaultFont = viewModel.UserSettings.Theme.DefaultTabFont;
                ApplyFontTabs();
            }
        }

        /// <summary>
        /// Applies new theme to the app.
        /// </summary>
        private void ApplyStyle() {
            SetAllControlsColors(this);
            ApplyStyleTabs();
            ApplyStyleMenu();
        }

        /// <summary>
        /// Applies new theme to tabs.
        /// </summary>
        private void ApplyStyleTabs() {
            // Custom tabs.
            foreach (RichTab tab in tabControl.Controls) {
                // Doing this bullshit to avoid binding trigger.
                if (tab.textBox.ForeColor != viewModel.UserSettings.Theme.AssistColor)
                    tab.textBox.ForeColor = viewModel.UserSettings.Theme.AssistColor;
                if (tab.textBox.BackColor != viewModel.UserSettings.Theme.BackgroundColor)
                    tab.textBox.BackColor = viewModel.UserSettings.Theme.BackgroundColor;
            }
        }

        /// <summary>
        /// Applies default font to all tabs.
        /// </summary>
        private void ApplyFontTabs() {
            foreach (RichTab tab in tabControl.Controls) {
                tab.textBox.Font = viewModel.UserSettings.Theme.DefaultTabFont;
            }
        }

        /// <summary>
        /// Applies new theme to all menus.
        /// </summary>
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

        /// <summary>
        /// Closes all opened tabs in the form. Returns false, if closing was canceled.
        /// </summary>
        /// <returns></returns>
        public bool CloseAllTabs() {
            for (int i = tabControl.TabCount - 1; i >= 0; i--) {
                tabControl.SelectedIndex = i;
                if (!RemoveCurrentTab())
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Closes all forms. Close event is called on each form.
        /// </summary>
        public void CloseAllForms() {
            int formListCount = viewModel.FormList.Count;
            for (int i = formListCount - 1; i >= 0; i--) {
                viewModel.FormList[i].Close();
                // If form wasn't closed.
                if (i < viewModel.FormList.Count)
                    return;
            }
        }

        private void tabsContextMenuStrip_Opening(object sender, CancelEventArgs e) {
            Point p = tabControl.PointToClient(Cursor.Position);
            for (int i = 0; i < tabControl.TabCount; i++) {
                Rectangle r = tabControl.GetTabRect(i);
                if (r.Contains(p)) {
                    tabControl.SelectedIndex = i; // i is the index of tab under cursor
                    return;
                }
            }
            e.Cancel = true;
        }

        private void tabsStripMenuItem1_Click(object sender, EventArgs e) {
            RemoveCurrentTab();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            // if trying to close last form, we need to save all options.
            if (viewModel.FormList.Count <= 1) {
                viewModel.SaveSettingsJSON();
            }
            if (CloseAllTabs()) {
                e.Cancel = false;
                viewModel.FormList.Remove(this);
            } else {
                e.Cancel = true;
            }
        }

        private void autoSaveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < tabControl.TabCount; i++) {
                ForceSaveFile(i);
            }
        }
    }
}
