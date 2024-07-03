using Gestion_BU.Core.Entities;


namespace Gestion_BU.Core.Interfaces
{
    public interface IUniversiteRepository
    {
        public Universite GetById(int universityId);

        public List<Universite> GetAll();
    }
}
