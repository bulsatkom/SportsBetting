using Sports_Betting_Data;
using Sports_Betting_Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sports_Betting_MVC.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SportsBettingDbContext, Configuration>());
        }
    }
}