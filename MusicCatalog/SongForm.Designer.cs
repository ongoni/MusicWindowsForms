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
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SongFormCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(12, 9);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(30, 13);
            this.ArtistLabel.TabIndex = 0;
            this.ArtistLabel.Text = "Artist";
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(12, 25);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.Size = new System.Drawing.Size(260, 20);
            this.ArtistTextBox.TabIndex = 1;
            this.ArtistTextBox.TextChanged += new System.EventHandler(this.ArtistTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Song name";
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Location = new System.Drawing.Point(12, 64);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.SongNameTextBox.TabIndex = 3;
            this.SongNameTextBox.TextChanged += new System.EventHandler(this.SongNameTextBox_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 90);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(127, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SongFormCancelButton
            // 
            this.SongFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SongFormCancelButton.Location = new System.Drawing.Point(146, 90);
            this.SongFormCancelButton.Name = "SongFormCancelButton";
            this.SongFormCancelButton.Size = new System.Drawing.Size(127, 23);
            this.SongFormCancelButton.TabIndex = 5;
            this.SongFormCancelButton.Text = "Cancel";
            this.SongFormCancelButton.UseVisualStyleBackColor = true;
            this.SongFormCancelButton.Click += new System.EventHandler(this.SongFormCancelButton_Click_1);
            // 
            // SongForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.SongFormCancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SongNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistTextBox);
            this.Controls.Add(this.ArtistLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 135);
            this.Name = "SongForm";
            this.ShowIcon = false;
            this.Text = "Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button SongFormCancelButton;
    }
}