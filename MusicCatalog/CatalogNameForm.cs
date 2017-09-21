using System;
using System.Windows.Forms;
using Entities;

namespace MusicCatalog {

    public partial class CatalogNameForm : Form {

        public CatalogNameForm() {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e) { 
            Catalog catalog = new Catalog();
        }

        private void CatalogNameFormCancelButton_Click(object sender, EventArgs e) {
            Close();
        }

    }

}
