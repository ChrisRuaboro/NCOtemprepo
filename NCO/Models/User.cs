using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PayGradeType { get; set; }
        public string PayGradeRank { get; set; }
    }
}
