using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    public class Units
    {
        [Key]
        public int UnitIDCode { get; set; }
        public string UnitName { get; set; }
        public int ParentTo { get; set; }
        public int ChildTo { get; set; }
        public int POBox { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public int Phone { get; set; }
    }
}
