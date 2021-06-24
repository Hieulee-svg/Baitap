using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookManager3.Models
{
    public partial class BookModelContext : DbContext
    {
        public BookModelContext()
            : base("name=BookModelContext")
        {
        }

        public virtual DbSet<books> books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
