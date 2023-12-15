using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using reader;

public class SHVN_NasosService
{
    [Key]
    public int SHVN_NasosId { get; set; }

    [Column("Name ")]
    public string Name { get; set; }
    [Column("q100")]
    public string q100 { get; set; }
    [Column("H")]
    public string H { get; set; }
    [Column("Dgabarit")]
    public string Dgabarit { get; set; }
    [Column("d")]
    public string d { get; set; }
    [Column("L")]
    public string L { get; set; }
    [Column("Nju")]
    public string Nju { get; set; }
    [Column("Hopt")]
    public string Hopt { get; set; }
    [Column("Freq")]
    public string Freq { get; set; }
    [Column("Maker")]
    public string Maker { get; set; }

    private readonly ApplicationDbContext _context;

    public SHVN_NasosService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<SHVN_Nasos> GetAll()
    {
        return _context.SHVN_NasosCollection.ToList();
    }

    public SHVN_Nasos GetById(int id)
    {
        return _context.SHVN_NasosCollection.Find(id);
    }

    public void Add(SHVN_Nasos SHVN_Nasos)
    {
        _context.SHVN_NasosCollection.Add(SHVN_Nasos);
        _context.SaveChanges();
    }

    public void Update(SHVN_Nasos SHVN_Nasos)
    {
        _context.Entry(SHVN_Nasos).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var SHVN_Nasos = _context.SHVN_NasosCollection.Find(id);
        if (SHVN_Nasos != null)
        {
            _context.SHVN_NasosCollection.Remove(SHVN_Nasos);
            _context.SaveChanges();
        }
    }
}