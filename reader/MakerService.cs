using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using reader;
using System.Reflection.Metadata.Ecma335;

public class MakerService
{
    [Key]
    public int MakerId { get; set; }
    [Column("Code")]
    public string Code { get; set; }
    [Column("Name")]
    public string Name { get; set; }
    [Column("Adress")]
    public string Adress { get; set; }

    

    private readonly ApplicationDbContext _context;

    public MakerService(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Maker> GetAll()
    {
        return _context.Makers.ToList();
    }

    public Maker GetById(int id)
    {
        return _context.Makers.Find(id);
    }

    public void Add(Maker maker)
    {
        _context.Makers.Add(maker);
        _context.SaveChanges();
    }

    public void Update(Maker maker)
    {
        _context.Entry(maker).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var maker = _context.Makers.Find(id);
        if (maker != null)
        {
            _context.Makers.Remove(maker);
            _context.SaveChanges();
        }
    }
}
