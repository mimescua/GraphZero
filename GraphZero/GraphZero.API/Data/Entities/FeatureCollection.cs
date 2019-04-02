using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.Data.Entities
{
    public class FeatureCollection
    {
        public int Id { get; set; }

        public string Type { get; set; }
        //public BlockObject Features { get; set; }
        public List<Features> Features { get; set; }
    }
}