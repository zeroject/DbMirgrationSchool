using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class MigrationContext : DbContext
{
    public DbSet<Products> Products { get; set; }

    public MigrationContext()
    {

    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=migrationDb;User Id=sa;Password=Hyy89xjw!;Trusted_Connection=False;TrustServerCertificate=True;");
}

//add the relevant new table here with its properties and ensure that a DbSet is created for it in the MigrationContext class.
//for futher help. dont ask Kasper. he is tired of your questions.
public class Products
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
}

//after adding the new table, run the following commands in the terminal
//dotnet ef migrations add [migrationName]
//dotnet ef database update


