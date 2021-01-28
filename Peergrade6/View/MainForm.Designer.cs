
using Peergrade6.Utilities.UI;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fileStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugTimer = new System.Windows.Forms.Timer(this.components);
            this.styleTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.tabsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.fileStripMenuItem5,
            this.toolStripSeparator2,
            this.fileStripMenuItem6,
            this.toolStripSeparator3,
            this.fileStripMenuItem7});
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
            this.fileStripMenuItem1.Click += new System.EventHandler(this.fileStripMenuItem1_Click);
            // 
            // fileStripMenuItem2
            // 
            this.fileStripMenuItem2.Name = "fileStripMenuItem2";
            this.fileStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fileStripMenuItem2.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem2.Text = "Создать файл в новой вкладке";
            this.fileStripMenuItem2.Click += new System.EventHandler(this.fileStripMenuItem2_Click);
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
            this.fileStripMenuItem3.Click += new System.EventHandler(this.fileStripMenuItem3_Click);
            // 
            // fileStripMenuItem4
            // 
            this.fileStripMenuItem4.Name = "fileStripMenuItem4";
            this.fileStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileStripMenuItem4.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem4.Text = "Сохранить всё";
            this.fileStripMenuItem4.Click += new System.EventHandler(this.fileStripMenuItem4_Click);
            // 
            // fileStripMenuItem5
            // 
            this.fileStripMenuItem5.Name = "fileStripMenuItem5";
            this.fileStripMenuItem5.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem5.Text = "Сохранить как";
            this.fileStripMenuItem5.Click += new System.EventHandler(this.fileStripMenuItem5_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(304, 6);
            // 
            // fileStripMenuItem6
            // 
            this.fileStripMenuItem6.Name = "fileStripMenuItem6";
            this.fileStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileStripMenuItem6.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem6.Text = "Открыть в новой вкладке";
            this.fileStripMenuItem6.Click += new System.EventHandler(this.fileStripMenuItem6_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(304, 6);
            // 
            // fileStripMenuItem7
            // 
            this.fileStripMenuItem7.Name = "fileStripMenuItem7";
            this.fileStripMenuItem7.Size = new System.Drawing.Size(307, 22);
            this.fileStripMenuItem7.Text = "Закрыть всё";
            this.fileStripMenuItem7.Click += new System.EventHandler(this.fileStripMenuItem7_Click);
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
            this.optionsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsStripMenuItem1});
            this.optionsStripMenuItem.Name = "optionsStripMenuItem";
            this.optionsStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.optionsStripMenuItem.Text = "Настройки";
            // 
            // optionsStripMenuItem1
            // 
            this.optionsStripMenuItem1.Name = "optionsStripMenuItem1";
            this.optionsStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.optionsStripMenuItem1.Text = "Поменять тему";
            this.optionsStripMenuItem1.Click += new System.EventHandler(this.optionsStripMenuItem1_Click);
            // 
            // tabControl
            // 
            this.tabControl.ContextMenuStrip = this.tabsContextMenuStrip;
            this.tabControl.Location = new System.Drawing.Point(12, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(860, 463);
            this.tabControl.TabIndex = 2;
            // 
            // tabsContextMenuStrip
            // 
            this.tabsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabsStripMenuItem1});
            this.tabsContextMenuStrip.Name = "tabsContextMenuStrip";
            this.tabsContextMenuStrip.Size = new System.Drawing.Size(167, 26);
            this.tabsContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.tabsContextMenuStrip_Opening);
            // 
            // tabsStripMenuItem1
            // 
            this.tabsStripMenuItem1.Name = "tabsStripMenuItem1";
            this.tabsStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.tabsStripMenuItem1.Text = "Закрыть вкладку";
            this.tabsStripMenuItem1.Click += new System.EventHandler(this.tabsStripMenuItem1_Click);
            // 
            // debugTimer
            // 
            this.debugTimer.Enabled = true;
            this.debugTimer.Interval = 1000;
            this.debugTimer.Tick += new System.EventHandler(this.debugTimer_Tick);
            // 
            // styleTimer
            // 
            this.styleTimer.Enabled = true;
            this.styleTimer.Tick += new System.EventHandler(this.styleTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 534);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabsContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Timer debugTimer;
        private System.Windows.Forms.ToolStripMenuItem optionsStripMenuItem1;
        private System.Windows.Forms.Timer styleTimer;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ContextMenuStrip tabsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tabsStripMenuItem1;
    }
}

