namespace MusicCatalog {
    partial class DiskForm {
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
            this.DiskNameLabel = new System.Windows.Forms.Label();
            this.DiskNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.DiskFormCancelButton = new System.Windows.Forms.Button();
            this.CatalogNameLabel = new System.Windows.Forms.Label();
            this.CatalogNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DiskNameLabel
            // 
            this.DiskNameLabel.AutoSize = true;
            this.DiskNameLabel.Location = new System.Drawing.Point(12, 48);
            this.DiskNameLabel.Name = "DiskNameLabel";
            this.DiskNameLabel.Size = new System.Drawing.Size(57, 13);
            this.DiskNameLabel.TabIndex = 6;
            this.DiskNameLabel.Text = "Disk name";
            // 
            // DiskNameTextBox
            // 
            this.DiskNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.DiskNameTextBox.Name = "DiskNameTextBox";
            this.DiskNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.DiskNameTextBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 90);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DiskFormCancelButton
            // 
            this.DiskFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DiskFormCancelButton.Location = new System.Drawing.Point(145, 90);
            this.DiskFormCancelButton.Name = "DiskFormCancelButton";
            this.DiskFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.DiskFormCancelButton.TabIndex = 4;
            this.DiskFormCancelButton.Text = "Cancel";
            this.DiskFormCancelButton.UseVisualStyleBackColor = true;
            this.DiskFormCancelButton.Click += new System.EventHandler(this.DiskFormCancelButton_Click);
            // 
            // CatalogNameLabel
            // 
            this.CatalogNameLabel.AutoSize = true;
            this.CatalogNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CatalogNameLabel.Name = "CatalogNameLabel";
            this.CatalogNameLabel.Size = new System.Drawing.Size(72, 13);
            this.CatalogNameLabel.TabIndex = 5;
            this.CatalogNameLabel.Text = "Catalog name";
            // 
            // CatalogNameTextBox
            // 
            this.CatalogNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.CatalogNameTextBox.Name = "CatalogNameTextBox";
            this.CatalogNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.CatalogNameTextBox.TabIndex = 1;
            // 
            // DiskForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DiskFormCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.CatalogNameTextBox);
            this.Controls.Add(this.CatalogNameLabel);
            this.Controls.Add(this.DiskFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.DiskNameTextBox);
            this.Controls.Add(this.DiskNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 163);
            this.Name = "DiskForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiskNameLabel;
        private System.Windows.Forms.TextBox DiskNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button DiskFormCancelButton;
        private System.Windows.Forms.Label CatalogNameLabel;
        private System.Windows.Forms.TextBox CatalogNameTextBox;
    }
}