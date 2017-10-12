using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using MusicCatalog.Classes;
using MusicCatalog.Entities;

namespace MusicCatalog {

    public partial class MainForm : Form {

        public Data Data = new Data();

        public MainForm() {
            InitializeComponent();
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
            using (FileStream fileStream = new FileStream("../../data.xml", FileMode.Create)) {
                XmlSerializer serializer = new XmlSerializer(typeof(Data));
                serializer.Serialize(fileStream, Data);
                fileStream.Close();
            }

            using (FileStream fileStream = new FileStream("../../data.dat", FileMode.Create)) {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                try {
                    binaryFormatter.Serialize(fileStream, Data);
                } catch (SerializationException ex) {
                    Console.WriteLine(ex.Message);
                } finally {
                    fileStream.Close();
                }
            }
        }

        private void LoadFromBinaryButton_Click(object sender, EventArgs e) {
            CatalogTree.Nodes.Clear();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("../../data.dat", FileMode.Open)) {
                Data deserializedData = (Data) binaryFormatter.Deserialize(fileStream);
                Data = deserializedData;
            }
            MainForm_Activated(sender, e);
        }

        private void LoadFromXmlButton_Click(object sender, EventArgs e) {
            CatalogTree.Nodes.Clear();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));
            using (FileStream fileStream = new FileStream("../../data.xml", FileMode.Open)) {
                XmlReader reader = XmlReader.Create(fileStream);
                Data deserializedData = (Data) xmlSerializer.Deserialize(reader);
                Data = deserializedData;
            }
            MainForm_Activated(sender, e);
        }

        private void MainForm_Activated(object sender, EventArgs e) {
            foreach (Catalog catalog in Data.Catalogs) {
                TreeNode catalogNode;
                var catalogNodes = CatalogTree.Nodes.Find(catalog.Name, false);

                if (!catalogNodes.Any()) {
                    catalogNode = new TreeNode {
                        Name = catalog.Name,
                        Text = catalog.Name
                    };
                    CatalogTree.Nodes.Add(catalogNode);
                } else {
                    catalogNode = catalogNodes.First();
                }

                foreach (Disk disk in catalog.Disks) {
                    TreeNode diskNode;
                    var diskNodes = catalogNode.Nodes.Find(disk.Name, false);

                    if (!diskNodes.Any()) {
                        diskNode = new TreeNode {
                            Name = disk.Name,
                            Text = disk.Name
                        };
                        catalogNode.Nodes.Add(diskNode);
                    } else {
                        diskNode = diskNodes.First();
                    }

                    foreach (Song song in disk.Songs) {
                        string fullSongName = song.Artist + " - " + song.Name;
                        var songNodes = diskNode.Nodes.Find(fullSongName, false);

                        if (!songNodes.Any()) {
                            diskNode.Nodes.Add(new TreeNode {
                                Name = fullSongName,
                                Text = fullSongName
                            });
                        }
                    }
                }
            }
        }
    }

}
