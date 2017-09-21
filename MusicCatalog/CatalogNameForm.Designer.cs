namespace MusicCatalog {
    partial class CatalogNameForm {
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
            this.CatalogName = new System.Windows.Forms.Label();
            this.CatalogNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CatalogNameFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CatalogName
            // 
            this.CatalogName.AutoSize = true;
            this.CatalogName.Location = new System.Drawing.Point(12, 9);
            this.CatalogName.Name = "CatalogName";
            this.CatalogName.Size = new System.Drawing.Size(35, 13);
            this.CatalogName.TabIndex = 0;
            this.CatalogName.Text = "Name";
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
            this.OkButton.Location = new System.Drawing.Point(12, 50);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CatalogNameFormCancelButton
            // 
            this.CatalogNameFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CatalogNameFormCancelButton.Location = new System.Drawing.Point(145, 50);
            this.CatalogNameFormCancelButton.Name = "CatalogNameFormCancelButton";
            this.CatalogNameFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.CatalogNameFormCancelButton.TabIndex = 3;
            this.CatalogNameFormCancelButton.Text = "Cancel";
            this.CatalogNameFormCancelButton.UseVisualStyleBackColor = true;
            this.CatalogNameFormCancelButton.Click += new System.EventHandler(this.CatalogNameFormCancelButton_Click);
            // 
            // CatalogNameForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CatalogNameFormCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 85);
            this.Controls.Add(this.CatalogNameFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CatalogNameTextBox);
            this.Controls.Add(this.CatalogName);
            this.MaximumSize = new System.Drawing.Size(300, 123);
            this.MinimumSize = new System.Drawing.Size(300, 123);
            this.Name = "CatalogNameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Enter catalog name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CatalogName;
        private System.Windows.Forms.TextBox CatalogNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CatalogNameFormCancelButton;
    }
}