using System;
using System.Collections.Generic;
using MusicCatalog.Entities;

namespace MusicCatalog.Classes {

    [Serializable]
    public class Data {

        public Data() {
            Catalogs = new List<Catalog>();
        }

        public List<Catalog> Catalogs { get; set; }

    }
    
}
