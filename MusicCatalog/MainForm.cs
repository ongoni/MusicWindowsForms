using System;
using System.Windows.Forms;

namespace MusicCatalog {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void AddCatalogButton_Click(object sender, EventArgs e) {
            CatalogNameForm cnf = new CatalogNameForm();
            cnf.Show();
        }

        private void AddDiskButton_Click(object sender, EventArgs e) {
            DiskNameForm dnf = new DiskNameForm();
            dnf.Show();
        }

        private void AddSongButton_Click(object sender, EventArgs e) {
            SongForm sf = new SongForm();
            sf.Show();
        }

    }

}
