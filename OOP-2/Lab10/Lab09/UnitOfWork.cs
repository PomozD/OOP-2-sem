using Lab09.Model;
using System;

namespace Lab09
{
    public class UnitOfWork : IDisposable
    {
        private ActorContext db = new ActorContext();
        private UserRepository userRepository;
        private ActorRepository actorRepository;

        public ActorRepository Actors
        {
            get
            {
                if (actorRepository == null)
                    actorRepository = new ActorRepository(db);
                return actorRepository;
            }
        }

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
