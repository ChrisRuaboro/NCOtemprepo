using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    public class EFUsersRepository : IUsersRepository
    {
        private ApplicationDbContext context;
        public EFUnitsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;
    }
}
