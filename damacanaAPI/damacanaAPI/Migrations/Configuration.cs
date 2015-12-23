namespace damacanaAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using damacanaAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<damacanaAPI.Models.damacanaAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "damacanaAPI.Models.damacanaAPIContext";
        }

        protected override void Seed(damacanaAPI.Models.damacanaAPIContext context)
        {

            context.Products.AddOrUpdate(x => x.Id,
                new Product()
                {
                    Id = 1,
                    Name ="Erikli",
                    Price=3
                },
                new  Product()
                {
                    Id = 2,
                    Name ="Nestle",
                    Price=5
                },
                new Product()
                {
                    Id = 3,
                    Name ="Hayat",
                    Price=6
                },
                new Product()
                {
                    Id = 4,
                    Name ="Nestle",
                    Price=7
                }
                );
        }
    }
}
