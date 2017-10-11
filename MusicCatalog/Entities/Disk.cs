using System;
using System.Collections.Generic;

namespace Entities {

    [Serializable]
    public class Disk {

        public List<Song> Songs;

        public string Name { get; set; }

        public Disk() {
            Songs = new List<Song>();
        }

        public Disk(string name) {
            Name = name;
            Songs = new List<Song>();
        }

        public List<Song> enumerator {
            get { return Songs; }
        }

        public void Add(Song song) {
            Songs.Add(song);
        }

        public void Add(List<Song> other) {
            Songs.AddRange(other);
        }

        public void Remove(Song song) {
            Songs.Remove(song);
        }

        public List<Song> FindAll(string artist) {
            List<Song> found = Songs.FindAll(item => item.Artist == artist);
            return found;
        }

        public void Sort() {
            Songs.Sort();
        }

        public void Print() {
            foreach (Song song in Songs) {
                Console.WriteLine(song);
            }
        }

    }

}
