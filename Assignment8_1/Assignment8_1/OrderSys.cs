namespace Assignment8_1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrderSys : DbContext
    {

        public OrderSys()
            : base("name=OrderSys")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderSys>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
 
    }

}