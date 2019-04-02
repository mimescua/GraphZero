using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//
using System.Text;

namespace GraphZero.API.Data.Entities
{
    public class Lot
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        //public Block Block { get; set; }

        [Required]
        public string Name { get; set; }
        public int AreaCode { get; set; }
        public double Area { get; set; }
        public string UseType { get; set; }
        public double FrontMeasure { get; set; }
        public double LeftMeasure { get; set; }
        public double BackMeasure { get; set; }
        public double RightMeasure { get; set; }

        public string Type { get; set; }
        public string Coordinates { get; set; }
    }
}
