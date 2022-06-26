using System;
using System.Data.Entity;
using System.Linq;
namespace Lab09.Model
{

    public class ActorContext : DbContext
    {
        public ActorContext()
            : base("name=MyConnection")
        { }
        public DbSet<Actor> actors { get; set; }
        public DbSet<User> users { get; set; }
    }
}
