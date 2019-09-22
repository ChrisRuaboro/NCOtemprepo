using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    public class EFUnitsRepository : IUnitsRepository
    {
        private ApplicationDbContext context;
        public EFUnitsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Unit> Units => context.Units;
    }
}
