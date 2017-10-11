using System;
using System.Collections.Generic;
using Entities;

namespace Classes {

    [Serializable]
    public class Data {

        public Data() {
            Catalogs = new List<Catalog>();
        }

        public List<Catalog> Catalogs { get; set; }

    }
    
}
