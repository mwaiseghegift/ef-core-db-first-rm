using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ef_core_dbfirst.Models;

public partial class EfCoreDatabaseFirstContext : DbContext
{
    public EfCoreDatabaseFirstContext()
    {
    }

    public EfCoreDatabaseFirstContext(DbContextOptions<EfCoreDatabaseFirstContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EfCoreDatabaseFirst;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
