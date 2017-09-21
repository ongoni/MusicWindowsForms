using System;
using System.Collections.Generic;

namespace Entities {

    [Serializable]
    class Catalog {

        private List<Disk> catalog;

        public string Name { get; set; }

        public Catalog() {
            catalog = new List<Disk>();
        }

        public Catalog(string name) {
            Name = name;
            catalog = new List<Disk>();
        }

        public List<Disk> enumerator {
            get { return catalog; }
        }

        public void Add(Disk disk) {
            catalog.Add(disk);
        }

        public void Remove(Disk disk) {
            catalog.Remove(disk);
        }

        public Disk FindAll(string artist) {
            Disk found = new Disk();
            foreach (Disk disk in catalog) {
                found.Add(disk.FindAll(artist));
            }

            return found;
        }

        public void Sort() {
            foreach (Disk disk in catalog) {
                disk.Sort();
            }
        }

        public void Print() {
            foreach (Disk disk in catalog) {
                disk.Print();
            }
        }
    }
}
