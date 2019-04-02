using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.Data.Entities
{
    public struct Coordinates
    {
        public Coordinates(string xyz)
        {
            XYZ = xyz;
        }
        public string XYZ { get; set; }
    }
}
