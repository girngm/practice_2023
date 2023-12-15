using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using reader;

public class MotorService
{
    [Key]
    public int MotorID { get; set; }
    [Column("Type")]
    public string TYPE { get; private set; }

    [Column("U")]
    public string U { get; private set; }

    [Column("N")]
    public string N { get; private set; }

    [Column("I")]
    public string I { get; private set; }

    [Column("nju")]
    public string nju { get; private set; }

    [Column("Cos")]
    public string Cos { get; private set; }

    [Column("Slide")]
    public string Slide { get; private set; }

    [Column("L")]
    public string L { get; private set; }

    [Column("Omega")]
    public string Omega { get; private set; }

    [Column("T")]
    public string T { get; private set; }

    [Column("Polus")]
    public string Polus { get; private set; }

    [Column("Freq")]
    public string Freq { get; private set; }

    [Column("d")]
    public string d { get; private set; }

    [Column("w")]
    public string w { get; private set; }

    [Column("Maker")]
    public string Maker { get; private set; }

    private readonly ApplicationDbContext _context;

    public MotorService(ApplicationDbContext context)

    {
        _context = context;
    }

    public List<Motor> GetAll()
    {
        return _context.Motors.ToList();
    }

    public Motor GetById(int id)
    {
        return _context.Motors.Find(id);
    }

    public void Add(Motor motor)
    {
        _context.Motors.Add(motor);
        _context.SaveChanges();
    }

    public void Update(Motor motor)
    {
        _context.Entry(motor).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var motor = _context.Motors.Find(id);
        if (motor != null)
        {
            _context.Motors.Remove(motor);
            _context.SaveChanges();
        }
    }
}
