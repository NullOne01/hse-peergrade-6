using Peergrade6.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Peergrade6.Utilities.UI
{
    /// <summary>
    /// Custom UI element. Basically it is a simple tab with RichTextBox.
    /// </summary>
    class RichTab : TabPage
    {
        public RichTextBox textBox;
        // We might need this field in the future.
        private CodeTab tabInfo;

        public RichTab(CodeTab codeTab) {
            textBox = new RichTextBox();
            Controls.Add(textBox);
            textBox.Dock = DockStyle.Fill;

            tabInfo = codeTab;
            textBox.KeyDown += richTextBox_KeyDown;

            // Creatinng elements of menu.
            ToolStripMenuItem allMenuItem = new ToolStripMenuItem("Выделить всё");
            ToolStripMenuItem cutMenuItem = new ToolStripMenuItem("Вырезать");
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Копировать");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Вставить");
            ToolStripMenuItem formatMenuItem = new ToolStripMenuItem("Формат");

            allMenuItem.Click += ChooseAll;
            cutMenuItem.Click += CutOut;
            copyMenuItem.Click += Copy;
            pasteMenuItem.Click += Paste;
            formatMenuItem.Click += Format;

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.AddRange(new[] { allMenuItem, cutMenuItem, copyMenuItem,
                                               pasteMenuItem, formatMenuItem});
            textBox.ContextMenuStrip = contextMenu;
        }

        private void ChooseAll(object sender, EventArgs e) {
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
        }
        private void CutOut(object sender, EventArgs e) {
            textBox.Cut();
        }
        private void Copy(object sender, EventArgs e) {
            textBox.Copy();
        }
        private void Paste(object sender, EventArgs e) {
            textBox.Paste();
        }
        private void Format(object sender, EventArgs e) {
            using FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK) {
                textBox.SelectionFont = fontDialog.Font;
            }
        }

        // Fix undo/redo option.
        private void richTextBox_KeyDown(object sender, KeyEventArgs e) {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) {
                SuspendLayout();
                rtb.Undo();
                rtb.Redo();
                ResumeLayout();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            // Rebind Control + Shift + Z.
            if (keyData == (Keys.Control | Keys.Shift | Keys.Z)) {
                textBox.Redo();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
