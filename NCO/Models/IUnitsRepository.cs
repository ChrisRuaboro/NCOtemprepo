using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NCO.Models
{
    interface IUnitsRepository
    {
        IQueryable<Unit> Units { get; }
    }
}
