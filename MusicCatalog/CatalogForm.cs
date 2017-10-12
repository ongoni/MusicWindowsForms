using System;
using System.Windows.Forms;
using MusicCatalog.Entities;

namespace MusicCatalog {

    public partial class CatalogForm : Form {

        public CatalogForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            MainForm mainForm = (MainForm) Owner;
            if (mainForm.Data.Catalogs.Find(x => x.Name == CatalogNameTextBox.Text) == null) {
                mainForm.Data.Catalogs.Add(new Catalog(CatalogNameTextBox.Text));
            }

            Close();
        }

        private void CatalogFormCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

    }

}
