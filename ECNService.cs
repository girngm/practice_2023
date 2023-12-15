using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using reader;

public class ECNService
{
    [Key]
    public int ECNId { get; set; }

    [Column("N")]
    public string N { get; set; }
    [Column("H")]
    public string H { get; set; }
    [Column("L")]
    public string L { get; set; }

    private readonly ApplicationDbContext _context;

    public ECNService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<ECN> GetAll()
    {
        return _context.ECNs.ToList();
    }

    public ECN GetById(int id)
    {
        return _context.ECNs.Find(id);
    }

    public void Add(ECN ecn)
    {
        _context.ECNs.Add(ecn);
        _context.SaveChanges();
    }

    public void Update(ECN ecn)
    {
        _context.Entry(ecn).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var ecn = _context.ECNs.Find(id);
        if (ecn != null)
        {
            _context.ECNs.Remove(ecn);
            _context.SaveChanges();
        }
    }
}