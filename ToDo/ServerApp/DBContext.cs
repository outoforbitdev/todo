using System;
using Microsoft.EntityFrameworkCore;
using ToDo.Model;

namespace ToDo
{
    public class DBContext: DbContext
    {
        public DbSet<ToDoList> Lists { get; set; }


        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>().HasKey(b => new { b.Name, b.Environment });
        }

        public DBContext(): base()
        {

        }


    }
}
