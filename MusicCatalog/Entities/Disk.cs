using System;
using System.Collections.Generic;

namespace Entities {

    [Serializable]
    class Disk {

        private List<Song> disk;

        public string Name { get; set; }

        public Disk() {
            disk = new List<Song>();
        }

        public Disk(string name) {
            Name = name;
            disk = new List<Song>();
        }

        public List<Song> enumerator {
            get { return disk; }
        }

        public void Add(Song song) {
            disk.Add(song);
        }

        public void Add(List<Song> other) {
            disk.AddRange(other);
        }

        public void Remove(Song song) {
            disk.Remove(song);
        }

        public List<Song> FindAll(string artist) {
            List<Song> found = disk.FindAll(item => item.Artist == artist);
            return found;
        }

        public void Sort() {
            disk.Sort();
        }

        public void Print() {
            foreach (Song song in disk) {
                Console.WriteLine(song);
            }
        }

    }

}
