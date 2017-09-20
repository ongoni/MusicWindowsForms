using System;

namespace Entities {

    [Serializable]
    class Song : IComparable<Song> {

        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string artist, string name) {
            Artist = artist;
            Name = name;
        }

        public override string ToString() {
            return Artist + " - " + Name;
        }

        public int CompareTo(Song other) {
            if (Artist.CompareTo(other.Artist) > 0) return 1;
            if (Artist.CompareTo(other.Artist) < 0) return -1;
            else {
                if (Name.CompareTo(other.Name) > 0) return 1;
                if (Name.CompareTo(other.Name) < 0) return -1;

                return 0;
            }
        }

    }

}
