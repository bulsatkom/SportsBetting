using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Betting_Data.Interfaces
{
    public interface ISportsBettingDbContext
    {
        IDbSet<Event> Events { get; set; }

        int SaveChanges();
    }
}
