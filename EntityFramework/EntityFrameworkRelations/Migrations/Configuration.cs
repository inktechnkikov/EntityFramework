namespace EntityFrameworkRelations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkRelations.WorldContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrameworkRelations.WorldContext";
        }

        protected override void Seed(EntityFrameworkRelations.WorldContext context)
        {
         
        }
    }
}
