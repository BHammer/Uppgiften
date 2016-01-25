using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MessageDbContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }


    }
}
