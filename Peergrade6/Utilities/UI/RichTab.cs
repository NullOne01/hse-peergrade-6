using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Peergrade6.Utilities.UI
{
    class RichTab : TabPage
    {
        public RichTextBox textBox;
        public RichTab() {
            textBox = new RichTextBox();
            Controls.Add(textBox);
            textBox.Dock = DockStyle.Fill;

            // создаем элементы меню
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
            using (FontDialog fontDialog = new FontDialog()) {
                if (fontDialog.ShowDialog() == DialogResult.OK) {
                    textBox.SelectionFont = fontDialog.Font;
                }
            }

        }
    }
}
