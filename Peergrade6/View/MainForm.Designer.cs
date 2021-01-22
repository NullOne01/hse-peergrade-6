
namespace Peergrade6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem,
            this.editStripMenuItem,
            this.formatStripMenuItem,
            this.optionsStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileStripMenuItem
            // 
            this.fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenuItem1,
            this.fileStripMenuItem2,
            this.toolStripSeparator1,
            this.fileStripMenuItem3,
            this.fileStripMenuItem4,
            this.toolStripSeparator2,
            this.fileStripMenuItem5});
            this.fileStripMenuItem.Name = "fileStripMenuItem";
            this.fileStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileStripMenuItem.Text = "Файл";
            // 
            // fileStripMenuItem1
            // 
            this.fileStripMenuItem1.Name = "fileStripMenuItem1";
            this.fileStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.fileStripMenuItem1.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem1.Text = "Создать файл в новом окне";
            // 
            // fileStripMenuItem2
            // 
            this.fileStripMenuItem2.Name = "fileStripMenuItem2";
            this.fileStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileStripMenuItem2.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem2.Text = "Создать файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(304, 6);
            // 
            // fileStripMenuItem3
            // 
            this.fileStripMenuItem3.Name = "fileStripMenuItem3";
            this.fileStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.fileStripMenuItem3.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem3.Text = "Сохранить файл";
            // 
            // fileStripMenuItem4
            // 
            this.fileStripMenuItem4.Name = "fileStripMenuItem4";
            this.fileStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileStripMenuItem4.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem4.Text = "Сохранить всё";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // fileStripMenuItem5
            // 
            this.fileStripMenuItem5.Name = "fileStripMenuItem5";
            this.fileStripMenuItem5.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem5.Text = "Закрыть всё";
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editStripMenuItem.Text = "Правка";
            // 
            // formatStripMenuItem
            // 
            this.formatStripMenuItem.Name = "formatStripMenuItem";
            this.formatStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.formatStripMenuItem.Text = "Формат";
            // 
            // optionsStripMenuItem
            // 
            this.optionsStripMenuItem.Name = "optionsStripMenuItem";
            this.optionsStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.optionsStripMenuItem.Text = "Настройки";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 92);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(860, 430);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

