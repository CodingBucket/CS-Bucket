using System;

// Dependency Inversion:
// Abstraction should not depend on the details whereas the details should depend on astractions.
// High level modules should not depend on low level modules.

namespace Demo.SOLID.DependencyInversion
{
    public class ServiceLayer
    {
        private readonly IRepositoryLayer DAL;

        public ServiceLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Object details)
        {
            // Perform save
        }
    }
}
