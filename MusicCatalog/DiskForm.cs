using System;
using System.Linq;
using System.Windows.Forms;
using Entities;
using Classes;

namespace MusicCatalog {

    public partial class DiskForm : Form {

        public DiskForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            MainForm mainForm = (MainForm) Owner;
            Catalog catalog = mainForm.data.Catalogs.Find(x => x.Name == CatalogNameTextBox.Text);

            if (catalog == null) {
                catalog = new Catalog(CatalogNameTextBox.Text);

                mainForm.data.Catalogs.Add(catalog);
            }

            Disk disk = new Disk(DiskNameTextBox.Text);
            catalog.Add(disk);

            Close();
        }

        private void DiskFormCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

    }

}
