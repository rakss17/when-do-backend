using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace when_do_backend.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
        }

        public DbSet<Models.Rule> Rule { get; set; }
        public DbSet<Models.Condition> Condition { get; set; }
        public DbSet<Models.Action> Action { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Action>()
                .Property(a => a.Parameters)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<JsonElement>(v, (JsonSerializerOptions)null)
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}