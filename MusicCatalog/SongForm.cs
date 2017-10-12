using System;
using System.Windows.Forms;
using MusicCatalog.Entities;

namespace MusicCatalog {

    public partial class SongForm : Form {

        public SongForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            MainForm mainForm = (MainForm) Owner;
            Catalog catalog = mainForm.Data.Catalogs.Find(x => x.Name == CatalogNameTextBox.Text);

            if (catalog == null) {
                catalog = new Catalog(CatalogNameTextBox.Text);
                mainForm.Data.Catalogs.Add(catalog);
            }

            Disk disk = catalog.Find(DiskNameTextBox.Text);

            if (disk == null) {
                disk = new Disk(DiskNameTextBox.Text);
                catalog.Add(disk);
            }

            disk.Add(new Song(
                ArtistNameTextBox.Text,
                SongNameTextBox.Text
            ));

            Close();
        }

        private void SongFormCancelButton_Click_1(object sender, EventArgs e) {
            Close();
        }

    }

}
