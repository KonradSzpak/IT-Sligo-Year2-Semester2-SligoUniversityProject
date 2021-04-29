namespace sligoUniversityProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sligoUniversityProject.PeopleData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "sligoUniversityProject.PeopleData";
        }

        protected override void Seed(sligoUniversityProject.PeopleData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
