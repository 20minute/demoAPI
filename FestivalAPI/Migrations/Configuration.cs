namespace FestivalAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FestivalAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FestivalAPI.Models.FestivalAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FestivalAPI.Models.FestivalAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Festivals.AddOrUpdate(x => x.Id,
                new Festival() { Id = 1, Nom = "ARMADA", Description = "des"},
                new Festival() { Id = 2, Nom = "Music", Description = "des2" }
                );

            context.Festivaliers.AddOrUpdate(x => x.Id,
                new Festivalier() { Id = 1, Nom = "ZHENG", Prenom = "Lijun", DateNaissance="1996/05/10", Genre = "M", Telephone = 785 }
                );
        }
    }
}
