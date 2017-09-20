using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCatalog {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void AddCatalogButton_Click(object sender, EventArgs e) {

        }

        private void AddDiskButton_Click(object sender, EventArgs e) {

        }

        private void AddSongButton_Click(object sender, EventArgs e) {
            SongForm sf = new SongForm();
        }

    }

}
