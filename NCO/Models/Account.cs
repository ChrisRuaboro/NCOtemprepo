using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    enum subscriptionType { free, premium }
    public class Account
    {
        public int AccountID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string UserID { get; set; }
        public subscriptionType subType { get; set; }
    }
}
