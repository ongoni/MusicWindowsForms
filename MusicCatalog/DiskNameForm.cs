using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace MusicCatalog {

    public partial class DiskNameForm : Form {

        public DiskNameForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            Disk disk = new Disk();
            Data.Disks.Add(disk);
        }

        private void DiskNameFormCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

    }

}
