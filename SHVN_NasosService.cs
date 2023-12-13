using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using reader;

public class SHVN_NasosService
{
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