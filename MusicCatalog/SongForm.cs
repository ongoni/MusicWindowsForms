using System;
using System.Windows.Forms;
using Entities;
using Classes;

namespace MusicCatalog {

    public partial class SongForm : Form {

        public SongForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void SongFormCancelButton_Click_1(object sender, EventArgs e) {
            Close();
        }

    }

}
