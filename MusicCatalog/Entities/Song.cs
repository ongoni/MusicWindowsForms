using System;

namespace MusicCatalog.Entities {

    [Serializable]
    public class Song {

        public string Artist { get; set; }
        public string Name { get; set; }

        public Song() { }

        public Song(string artist, string name) {
            Artist = artist;
            Name = name;
        }

        public override string ToString() {
            return Artist + " - " + Name;
        }

        public int CompareTo(Song other) {
            if (String.Compare(Artist, other.Artist, StringComparison.Ordinal) > 0) return 1;
            if (String.Compare(Artist, other.Artist, StringComparison.Ordinal) < 0) return -1;
            if (String.Compare(Name, other.Name, StringComparison.Ordinal) > 0) return 1;
            if (String.Compare(Name, other.Name, StringComparison.Ordinal) < 0) return -1;

            return 0;
        }

    }

}
