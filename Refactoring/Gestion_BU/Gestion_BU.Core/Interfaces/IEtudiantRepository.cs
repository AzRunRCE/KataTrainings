using Gestion_BU.Core.Entities;

namespace Gestion_BU.Core.Interfaces
{
    public interface IEtudiantRepository
    {
        public void Add(Etudiant student);
        public bool Exists(string adresseEmail);
        public List<Etudiant> GetEtudiants();    
    }
}
