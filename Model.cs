using Microsoft.EntityFrameworkCore;
using reader;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ApplicationDbContext : DbContext
{
    // Добавляем DbSet для ECN, Maker, Motor, SHVN_Nasos
    public DbSet<ECN> ECNs { get; set; }
    public DbSet<Maker> Makers { get; set; }
    public DbSet<Motor> Motors { get; set; }
    public DbSet<SHVN_Nasos> SHVN_NasosCollection { get; set; }

    public string DbPath { get; }

    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

// Добавляем классы для новых DbSet
public class ECN1
{
    [Key]
    public int ECNId { get; set; }
    // Добавьте свойства ECN
}

public class Motor1
{
    [Key]
    public int MotorId { get; set; }
    // Добавьте свойства Motor
}

public class SHVN_Nasos1
{
    [Key]
    public int SHVN_NasosId { get; set; }
    // Добавьте свойства SHVN_Nasos
}
