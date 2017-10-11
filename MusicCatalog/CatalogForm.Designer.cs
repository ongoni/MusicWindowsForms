namespace MusicCatalog {
    partial class CatalogForm {
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
            this.CatalogNameLabel = new System.Windows.Forms.Label();
            this.CatalogNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CatalogFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatalogNameLabel
            // 
            this.CatalogNameLabel.AutoSize = true;
            this.CatalogNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CatalogNameLabel.Name = "CatalogNameLabel";
            this.CatalogNameLabel.Size = new System.Drawing.Size(72, 13);
            this.CatalogNameLabel.TabIndex = 0;
            this.CatalogNameLabel.Text = "Catalog name";
            // 
            // CatalogNameTextBox
            // 
            this.CatalogNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.CatalogNameTextBox.Name = "CatalogNameTextBox";
            this.CatalogNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.CatalogNameTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Location = new System.Drawing.Point(12, 50);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CatalogFormCancelButton
            // 
            this.CatalogFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CatalogFormCancelButton.Location = new System.Drawing.Point(145, 50);
            this.CatalogFormCancelButton.Name = "CatalogFormCancelButton";
            this.CatalogFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.CatalogFormCancelButton.TabIndex = 3;
            this.CatalogFormCancelButton.Text = "Cancel";
            this.CatalogFormCancelButton.UseVisualStyleBackColor = true;
            this.CatalogFormCancelButton.Click += new System.EventHandler(this.CatalogFormCancelButton_Click);
            // 
            // CatalogForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CatalogFormCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.CatalogFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CatalogNameTextBox);
            this.Controls.Add(this.CatalogNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 123);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 123);
            this.Name = "CatalogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CatalogNameLabel;
        private System.Windows.Forms.TextBox CatalogNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CatalogFormCancelButton;
    }
}