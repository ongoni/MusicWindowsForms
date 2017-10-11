﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Entities {

    [XmlRoot("Data")]
    public class Catalog {

        public List<Disk> Disks;

        public string Name { get; set; }

        public Catalog() {
            Disks = new List<Disk>();
        }

        public Catalog(string name) {
            Name = name;
            Disks = new List<Disk>();
        }

        public List<Disk> enumerator {
            get { return Disks; }
        }

        public void Add(Disk disk) {
            Disks.Add(disk);
        }

        public void Remove(Disk disk) {
            Disks.Remove(disk);
        }

        public Disk Find(string name) {
            return Disks.Find(x => x.Name == name);
        }

        public Disk FindAll(string artist) {
            Disk found = new Disk();
            foreach (Disk disk in Disks) {
                found.Add(disk.FindAll(artist));
            }

            return found;
        }

        public void Sort() {
            foreach (Disk disk in Disks) {
                disk.Sort();
            }
        }

        public void Print() {
            foreach (Disk disk in Disks) {
                disk.Print();
            }
        }
    }
}
