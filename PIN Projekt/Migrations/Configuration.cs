namespace PIN_Projekt.Migrations
{
    using Models;
    using System.Collections.Generic;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PIN_Projekt.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PIN_Projekt.DAL.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.
            var categories = new List<Category>
            {
                new Category { Name = "Odjeća" },
                new Category { Name = "Igračke" },
                new Category { Name = "Kućanstvo" },
                new Category { Name = "Prehrana" },
                new Category { Name = "Tehnologija" },
                new Category { Name = "Sport" }
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Proizvod>
            {
                new Proizvod { Name = "Usisavač", Description="Kućni usisavač, 2 godine garancija",
                    Price=699, CategoryID=categories.Single( c => c.Name == "Kućanstvo").ID},
                new Proizvod { Name = "Samsung Galaxy S9", Description="Mobilni telefon Samsung, garancija 2 godine",
                    Price=6999, CategoryID=categories.Single( c => c.Name == "Tehnologija").ID },
                new Proizvod { Name = "Lego Star Wars", Description="Lego Star Wars Set za izradu, 50 komada",
                    Price=80, CategoryID=categories.Single( c => c.Name == "Igračke").ID },
                new Proizvod { Name = "Kukuruzni kruh", Description="",
                    Price=6, CategoryID=categories.Single( c => c.Name == "Prehrana").ID },
                new Proizvod { Name = "Mountain Bike Fiji", Description="Mountain bicikli, sav teren, 3 godine servis",
                    Price=7999, CategoryID=categories.Single( c => c.Name == "Sport").ID },
                new Proizvod { Name = "SMOG Majica L", Description="",
                    Price=89, CategoryID=categories.Single( c => c.Name == "Odjeća").ID },
                new Proizvod { Name = "XYZ Jeans hlače", Description="",
                    Price=200, CategoryID=categories.Single( c => c.Name == "Odjeća").ID },
                new Proizvod { Name = "Monitor Lenovo", Description="Monitor Lenovo za računalo",
                    Price=300, CategoryID=categories.Single( c => c.Name == "Tehnologija").ID },
                new Proizvod { Name = "Dukat Mlijeko 2.8%", Description="",
                    Price=8, CategoryID=categories.Single( c => c.Name == "Prehrana").ID },
                new Proizvod { Name = "Stolice za dnevni boravak, 4 komada", Description="",
                    Price=500, CategoryID=categories.Single( c => c.Name == "Kućanstvo").ID }
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
