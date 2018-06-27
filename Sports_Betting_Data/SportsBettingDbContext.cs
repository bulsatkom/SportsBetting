using Microsoft.AspNet.Identity.EntityFramework;
using Sports_Betting_Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Betting_Data
{
    public class SportsBettingDbContext : IdentityDbContext<ApplicationUser>, ISportsBettingDbContext
    {
        public SportsBettingDbContext()
            :base("DefaultConnection")
        {

        }

        public IDbSet<Event> Events { get; set; }

        public static SportsBettingDbContext Create()
        {
            return new SportsBettingDbContext();
        }
    }
}
