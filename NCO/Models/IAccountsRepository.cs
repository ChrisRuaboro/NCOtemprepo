using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    public class IAccountsRepository
    {
        IQueryable<Account> Accounts { get; }
    }
}
