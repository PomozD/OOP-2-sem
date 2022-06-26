using Lab09.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Lab09
{
    public class ActorRepository: IRepository<Actor>
    {
        DbContext _context;
        DbSet<Actor> _dbSet;

        public ActorRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<Actor>();
        }

        public void Create(Actor item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public Actor FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<Actor> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<Actor> Get(Func<Actor, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(Actor item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Update(Actor item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public DbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }

    public class UserRepository : IRepository<User>
    {
        DbContext _context;
        DbSet<User> _dbSet;

        public UserRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<User>();
        }

        public void Create(User item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public User FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<User> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<User> Get(Func<User, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public void Remove(User item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public void Update(User item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public DbContextTransaction Transaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
