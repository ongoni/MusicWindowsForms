using System;
using System.Windows.Forms;
using Entities;
using Classes;

namespace MusicCatalog {

    public partial class CatalogForm : Form {

        public CatalogForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) {
            MainForm mainForm = (MainForm) Owner;
            if (mainForm.data.Catalogs.Find(x => x.Name == CatalogNameTextBox.Text) == null) {
                mainForm.data.Catalogs.Add(new Catalog(CatalogNameTextBox.Text));
            }

            Close();
        }

        private void CatalogFormCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

    }

}
