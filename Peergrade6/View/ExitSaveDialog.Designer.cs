
namespace Peergrade6.View
{
    partial class ExitSaveDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.saveButton = new System.Windows.Forms.Button();
            this.dontSaveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveFileText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.saveButton.Location = new System.Drawing.Point(12, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // dontSaveButton
            // 
            this.dontSaveButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.dontSaveButton.Location = new System.Drawing.Point(126, 41);
            this.dontSaveButton.Name = "dontSaveButton";
            this.dontSaveButton.Size = new System.Drawing.Size(108, 23);
            this.dontSaveButton.TabIndex = 1;
            this.dontSaveButton.Text = "Не сохранять";
            this.dontSaveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(240, 41);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveFileText
            // 
            this.saveFileText.AutoSize = true;
            this.saveFileText.Location = new System.Drawing.Point(12, 9);
            this.saveFileText.Name = "saveFileText";
            this.saveFileText.Size = new System.Drawing.Size(123, 15);
            this.saveFileText.TabIndex = 3;
            this.saveFileText.Text = "Сохранить файл: {0}?";
            // 
            // ExitSaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 80);
            this.Controls.Add(this.saveFileText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dontSaveButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitSaveDialog";
            this.Text = "Сохранить файл?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dontSaveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Label saveFileText;
    }
}