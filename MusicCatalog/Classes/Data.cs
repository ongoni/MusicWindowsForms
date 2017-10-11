using System.Collections.Generic;
using Entities;
using System.Xml.Serialization;

namespace Classes {

    public class Data {

        public Data() {
            Catalogs = new List<Catalog>();
        }

        public List<Catalog> Catalogs { get; set; }

    }
    
}
