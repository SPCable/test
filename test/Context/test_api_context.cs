using System;
using System.Data.Entity;
using System.Linq;
using test.Models;

namespace test.Context
{
    public class test_api_context : DbContext
    {
        // Your context has been configured to use a 'test_api_context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'test.Context.test_api_context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'test_api_context' 
        // connection string in the application configuration file.
        public test_api_context()
            : base("name=test_api_context")
        {
        }

        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }


        public DbSet<Order> orders { get; set; }

        public DbSet<Cart> carts { get; set; }

        public DbSet<admin> admins  { get; set; }

        public DbSet<customer> customers { get; set; }





        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}