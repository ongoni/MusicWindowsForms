namespace MusicCatalog {
    partial class SongForm {
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
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.ArtistNameTextBox = new System.Windows.Forms.TextBox();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SongFormCancelButton = new System.Windows.Forms.Button();
            this.CatalogNameLabel = new System.Windows.Forms.Label();
            this.CatalogNameTextBox = new System.Windows.Forms.TextBox();
            this.DiskNameLabel = new System.Windows.Forms.Label();
            this.DiskNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Location = new System.Drawing.Point(12, 87);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(59, 13);
            this.ArtistNameLabel.TabIndex = 9;
            this.ArtistNameLabel.Text = "Artist name";
            // 
            // ArtistNameTextBox
            // 
            this.ArtistNameTextBox.Location = new System.Drawing.Point(12, 103);
            this.ArtistNameTextBox.Name = "ArtistNameTextBox";
            this.ArtistNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.ArtistNameTextBox.TabIndex = 3;
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(12, 126);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(61, 13);
            this.SongNameLabel.TabIndex = 10;
            this.SongNameLabel.Text = "Song name";
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Location = new System.Drawing.Point(15, 142);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.SongNameTextBox.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 168);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SongFormCancelButton
            // 
            this.SongFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SongFormCancelButton.Location = new System.Drawing.Point(145, 168);
            this.SongFormCancelButton.Name = "SongFormCancelButton";
            this.SongFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.SongFormCancelButton.TabIndex = 6;
            this.SongFormCancelButton.Text = "Cancel";
            this.SongFormCancelButton.UseVisualStyleBackColor = true;
            this.SongFormCancelButton.Click += new System.EventHandler(this.SongFormCancelButton_Click_1);
            // 
            // CatalogNameLabel
            // 
            this.CatalogNameLabel.AutoSize = true;
            this.CatalogNameLabel.Location = new System.Drawing.Point(12, 9);
            this.CatalogNameLabel.Name = "CatalogNameLabel";
            this.CatalogNameLabel.Size = new System.Drawing.Size(72, 13);
            this.CatalogNameLabel.TabIndex = 7;
            this.CatalogNameLabel.Text = "Catalog name";
            // 
            // CatalogNameTextBox
            // 
            this.CatalogNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.CatalogNameTextBox.Name = "CatalogNameTextBox";
            this.CatalogNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.CatalogNameTextBox.TabIndex = 1;
            // 
            // DiskNameLabel
            // 
            this.DiskNameLabel.AutoSize = true;
            this.DiskNameLabel.Location = new System.Drawing.Point(12, 48);
            this.DiskNameLabel.Name = "DiskNameLabel";
            this.DiskNameLabel.Size = new System.Drawing.Size(57, 13);
            this.DiskNameLabel.TabIndex = 8;
            this.DiskNameLabel.Text = "Disk name";
            // 
            // DiskNameTextBox
            // 
            this.DiskNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.DiskNameTextBox.Name = "DiskNameTextBox";
            this.DiskNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.DiskNameTextBox.TabIndex = 2;
            // 
            // SongForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.DiskNameTextBox);
            this.Controls.Add(this.DiskNameLabel);
            this.Controls.Add(this.CatalogNameTextBox);
            this.Controls.Add(this.CatalogNameLabel);
            this.Controls.Add(this.SongFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SongNameTextBox);
            this.Controls.Add(this.SongNameLabel);
            this.Controls.Add(this.ArtistNameTextBox);
            this.Controls.Add(this.ArtistNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 241);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 241);
            this.Name = "SongForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.TextBox ArtistNameTextBox;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button SongFormCancelButton;
        private System.Windows.Forms.Label CatalogNameLabel;
        private System.Windows.Forms.TextBox CatalogNameTextBox;
        private System.Windows.Forms.Label DiskNameLabel;
        private System.Windows.Forms.TextBox DiskNameTextBox;
    }
}