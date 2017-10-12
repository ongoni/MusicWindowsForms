namespace MusicCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCatalogButton = new System.Windows.Forms.Button();
            this.AddDiskButton = new System.Windows.Forms.Button();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.CatalogTree = new System.Windows.Forms.TreeView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadFromBinaryButton = new System.Windows.Forms.Button();
            this.LoadFromXmlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCatalogButton
            // 
            this.AddCatalogButton.Location = new System.Drawing.Point(12, 12);
            this.AddCatalogButton.Name = "AddCatalogButton";
            this.AddCatalogButton.Size = new System.Drawing.Size(100, 23);
            this.AddCatalogButton.TabIndex = 1;
            this.AddCatalogButton.Text = "Add catalog";
            this.AddCatalogButton.UseVisualStyleBackColor = true;
            this.AddCatalogButton.Click += new System.EventHandler(this.AddCatalogButton_Click);
            // 
            // AddDiskButton
            // 
            this.AddDiskButton.Location = new System.Drawing.Point(12, 41);
            this.AddDiskButton.Name = "AddDiskButton";
            this.AddDiskButton.Size = new System.Drawing.Size(100, 23);
            this.AddDiskButton.TabIndex = 2;
            this.AddDiskButton.Text = "Add disk";
            this.AddDiskButton.UseVisualStyleBackColor = true;
            this.AddDiskButton.Click += new System.EventHandler(this.AddDiskButton_Click);
            // 
            // AddSongButton
            // 
            this.AddSongButton.Location = new System.Drawing.Point(12, 70);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(100, 23);
            this.AddSongButton.TabIndex = 3;
            this.AddSongButton.Text = "Add song";
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            // 
            // CatalogTree
            // 
            this.CatalogTree.Location = new System.Drawing.Point(118, 12);
            this.CatalogTree.Name = "CatalogTree";
            this.CatalogTree.Size = new System.Drawing.Size(654, 537);
            this.CatalogTree.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 131);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadFromBinaryButton
            // 
            this.LoadFromBinaryButton.Location = new System.Drawing.Point(12, 160);
            this.LoadFromBinaryButton.Name = "LoadFromBinaryButton";
            this.LoadFromBinaryButton.Size = new System.Drawing.Size(100, 23);
            this.LoadFromBinaryButton.TabIndex = 5;
            this.LoadFromBinaryButton.Text = "Load binary data";
            this.LoadFromBinaryButton.UseVisualStyleBackColor = true;
            this.LoadFromBinaryButton.Click += new System.EventHandler(this.LoadFromBinaryButton_Click);
            // 
            // LoadFromXmlButton
            // 
            this.LoadFromXmlButton.Location = new System.Drawing.Point(12, 189);
            this.LoadFromXmlButton.Name = "LoadFromXmlButton";
            this.LoadFromXmlButton.Size = new System.Drawing.Size(100, 23);
            this.LoadFromXmlButton.TabIndex = 6;
            this.LoadFromXmlButton.Text = "Load xml data";
            this.LoadFromXmlButton.UseVisualStyleBackColor = true;
            this.LoadFromXmlButton.Click += new System.EventHandler(this.LoadFromXmlButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.LoadFromXmlButton);
            this.Controls.Add(this.LoadFromBinaryButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CatalogTree);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.AddDiskButton);
            this.Controls.Add(this.AddCatalogButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCatalogButton;
        private System.Windows.Forms.Button AddDiskButton;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.TreeView CatalogTree;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadFromBinaryButton;
        private System.Windows.Forms.Button LoadFromXmlButton;
    }
}

