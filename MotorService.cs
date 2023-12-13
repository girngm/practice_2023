using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class MotorService
{
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