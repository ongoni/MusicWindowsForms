using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using Entities;
using Classes;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MusicCatalog {

    public partial class MainForm : Form {

        public Data data = new Data();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void AddCatalogButton_Click(object sender, EventArgs e) {
            CatalogForm cnf = new CatalogForm();
            cnf.Owner = this;
            cnf.Show();
        }

        private void AddDiskButton_Click(object sender, EventArgs e) {
            DiskForm dnf = new DiskForm();
            dnf.Owner = this;
            dnf.Show();
        }

        private void AddSongButton_Click(object sender, EventArgs e) {
            SongForm sf = new SongForm();
            sf.Owner = this;
            sf.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream fileStream = new FileStream("../../data.xml", FileMode.Create)) {
                serializer.Serialize(fileStream, data);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e) {
            foreach (Catalog catalog in data.Catalogs) {
                TreeNode catalogNode = new TreeNode();
                var catalogNodes = CatalogTree.Nodes.Find(catalog.Name, false);

                if (catalogNodes.Count() == 0) {
                    catalogNode = new TreeNode {
                        Name = catalog.Name,
                        Text = catalog.Name
                    };
                    CatalogTree.Nodes.Add(catalogNode);
                } else {
                    catalogNode = catalogNodes.First();
                }

                foreach (Disk disk in catalog.Disks) {
                    TreeNode diskNode = new TreeNode();
                    var diskNodes = catalogNode.Nodes.Find(disk.Name, false);

                    if (diskNodes.Count() == 0) {
                        diskNode = new TreeNode {
                            Name = disk.Name,
                            Text = disk.Name
                        };
                        catalogNode.Nodes.Add(diskNode);
                    } else {
                        diskNode = diskNodes.First();
                    }

                    foreach (Song song in disk.Songs) {
                        TreeNode songNode = new TreeNode();
                        var songNodes = diskNode.Nodes.Find(song.Artist + " " + song.Name, false);

                        if (songNodes.Count() == 0) {
                            songNode = new TreeNode {
                                Name = song.Artist + " " + song.Name,
                                Text = song.Artist + " " + song.Name
                            };
                            diskNode.Nodes.Add(diskNode);
                        } else {
                            songNode = songNodes.First();
                        }
                    }
                }
            }
        }
    }

}
