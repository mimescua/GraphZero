using System;
using System.Collections.Generic;
using System.Text;

namespace GraphZero.API.Data.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AreaCode { get; set; }
        public double Area { get; set; }
        public string UseType { get; set; }
        public int LotsQty { get; set; }
        public List<Lot> LotIds { get; set; }
    }
}
