namespace MusicCatalog {
    partial class DiskNameForm {
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
            this.DiskName = new System.Windows.Forms.Label();
            this.DiskNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.DiskNameFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiskName
            // 
            this.DiskName.AutoSize = true;
            this.DiskName.Location = new System.Drawing.Point(12, 9);
            this.DiskName.Name = "DiskName";
            this.DiskName.Size = new System.Drawing.Size(35, 13);
            this.DiskName.TabIndex = 0;
            this.DiskName.Text = "Name";
            // 
            // DiskNameTextBox
            // 
            this.DiskNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.DiskNameTextBox.Name = "DiskNameTextBox";
            this.DiskNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.DiskNameTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 50);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // DiskNameFormCancelButton
            // 
            this.DiskNameFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DiskNameFormCancelButton.Location = new System.Drawing.Point(145, 51);
            this.DiskNameFormCancelButton.Name = "DiskNameFormCancelButton";
            this.DiskNameFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.DiskNameFormCancelButton.TabIndex = 3;
            this.DiskNameFormCancelButton.Text = "Cancel";
            this.DiskNameFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // DiskNameForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DiskNameFormCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.DiskNameFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DiskNameTextBox);
            this.Controls.Add(this.DiskName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 123);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 123);
            this.Name = "DiskNameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Enter disk name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiskName;
        private System.Windows.Forms.TextBox DiskNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button DiskNameFormCancelButton;
    }
}