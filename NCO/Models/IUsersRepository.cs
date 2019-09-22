using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    interface IUsersRepository
    {
        IQueryable<User> Users { get; }
    }
}
