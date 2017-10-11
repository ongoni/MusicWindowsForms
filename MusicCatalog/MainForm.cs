using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using Entities;
using Classes;

namespace MusicCatalog {

    public partial class MainForm : Form {

        public Data data = new Data();

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream fileStream = new FileStream("../../data.xml", FileMode.Open)) {
                XmlReader reader = XmlReader.Create(fileStream);
                Data deserializedData = (Data) serializer.Deserialize(reader);
                data = deserializedData;
            }
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
                fileStream.Close();
            }

            using (FileStream fileStream = new FileStream("../../data.dat", FileMode.Create)) {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try {
                    binaryFormatter.Serialize(fileStream, data);
                } catch (SerializationException ex) {
                    Console.WriteLine(ex.Message);
                } finally {
                    fileStream.Close();
                }
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
                        string fullSongName = song.Artist + " - " + song.Name;
                        var songNodes = diskNode.Nodes.Find(fullSongName, false);

                        if (songNodes.Count() == 0) {
                            songNode = new TreeNode {
                                Name = fullSongName,
                                Text = fullSongName
                            };
                            diskNode.Nodes.Add(songNode);
                        } else {
                            songNode = songNodes.First();
                        }
                    }
                }
            }
        }
    }

}
