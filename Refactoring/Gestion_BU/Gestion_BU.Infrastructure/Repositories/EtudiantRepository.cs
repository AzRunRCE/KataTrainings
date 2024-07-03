

using Gestion_BU.Core.Entities;
using Gestion_BU.Core.Interfaces;

namespace Gestion_BU.Infrastructure.Repositories
{
    public class EtudiantRepository : IEtudiantRepository
    {
        private static List<Etudiant> _etudiants = new List<Etudiant>()
        {
            new Etudiant("quentin.martinez@cambridge.com", 1, Forfait.Standard)
            {
                NbTelechargementMaximum = 10,
                NbLivreTelecharges = 5,
            },
            new Etudiant("john.wick@oxford.com", 3,  Forfait.Premium)
            {
                NbTelechargementMaximum = 5,
                NbLivreTelecharges = 2,
            },
            new Etudiant("harry.potter@poudlard.com", 2, Forfait.Premium)
            {
                NbTelechargementMaximum = 5,
                NbLivreTelecharges = 0,
            }
        };


        public void Add(Etudiant student)
        {
            _etudiants.Add(student);
        }
        public bool Exists(string adresseEmail)
        {
           return _etudiants.Any(etudiant => etudiant.AdresseEmail == adresseEmail);
        }

        public List<Etudiant> GetEtudiants()
        {
            return _etudiants.ToList();
        }
    }
}
