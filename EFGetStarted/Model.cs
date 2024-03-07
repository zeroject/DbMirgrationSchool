using EFGetStarted;
using EFGetStarted.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class MigrationContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<ProductRating> ProductRatings { get; set; }

    public MigrationContext()
    {

    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost;Database=migrationDb;User Id=sa;Password=SuperSecret69!;Trusted_Connection=False;TrustServerCertificate=True;");
}


//add the relevant new table here with its properties and ensure that a DbSet is created for it in the MigrationContext class.
//for futher help. dont ask Kasper. he is tired of your questions.

//after adding the new table, run the following commands in the terminal
//dotnet ef migrations add [migrationName]
//dotnet ef database update
//If the CLI is not installed, you can install it by running the following command: dotnet tool install --global dotnet-ef


