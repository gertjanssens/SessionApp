using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SessionApp.Models.DAL
{
    public class SessionContextInitializer :DropCreateDatabaseIfModelChanges<SessionContext> 
    {
        protected override void Seed(SessionContext context)
        {
            base.Seed(context);

            Session session1 = new Session();
            session1.Id = 1;
            session1.Name = "Asp.net core";//angular2 typescript

            Session session2 = new Session();
            session2.Id = 2;
            session2.Name = "Anjular 2";//angular2 typescript

            Session session3 = new Session();
            session3.Id = 3;
            session3.Name = "Typescript";//angular2 typescript

            context.SaveChanges();

        }
    }
}
