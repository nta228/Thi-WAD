using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Thi_WAD.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<Thi_WAD.Data.Thi_WADContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Thi_WAD.Data.Thi_WADContext";
        }

        protected override void Seed(Thi_WAD.Data.Thi_WADContext context)
        {
       
        }
    }
}