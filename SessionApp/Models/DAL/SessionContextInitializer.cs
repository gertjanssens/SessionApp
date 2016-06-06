using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SessionApp.Models.DAL
{
    class SessionContextInitializer :DropCreateDatabaseIfModelChanges<SessionContext> 
    {
        protected override void Seed(SessionContext context)
        {
            base.Seed(context);

        }
    }
}
