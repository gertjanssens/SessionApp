using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SessionApp.Models.DAL
{
    public class SessionContext :DbContext
    {
        public DbSet<Session> Sessions { get; set; }

        public SessionContext()
        {
            Database.SetInitializer<SessionContext>(new SessionContextInitializer());
        }
    }
}