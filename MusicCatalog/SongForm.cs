using System;
using System.Windows.Forms;
using Entities;

namespace MusicCatalog {

    public partial class SongForm : Form {

        public SongForm() {
            InitializeComponent();
        }

        private void ArtistTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void OkButton_Click(object sender, EventArgs e) {
            Data.Songs.Add(new Song(ArtistTextBox.Text, SongNameTextBox.Text));
        }

        private void SongFormCancelButton_Click_1(object sender, EventArgs e) {
            Close();
        }

    }

}
