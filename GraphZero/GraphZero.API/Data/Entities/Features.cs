using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.Data.Entities
{
    public class Features
    {
        public int Id { get; set; }
        public int _fkey { get; set; }

        public string Type { get; set; }
        //public FeatureGeometry FeatureGeometry { get; set; }
        //public FeatureProperty FeatureProperty { get; set; }
        public Block BlockGeometry { get; set; }
        public Block BlockProperty { get; set; }

        public Lot LotGeometry { get; set; }
        public Lot LotProperty { get; set; }
    }
}
