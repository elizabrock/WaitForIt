namespace WaitForIt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WaitForIt.EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WaitForIt.EventContext";
        }

        protected override void Seed(WaitForIt.EventContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Events.AddOrUpdate<Model.Event>(
                n => n.Name, // ANY LINQ expression
                new Model.Event { Name = "Jurnell's Birthday", Date = "10/05/2015"}
             );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
