using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_BU.Entities;

namespace Gestion_BU.Repositories
{
    public class EtudiantRepository
    {
        private static List<Etudiant> _etudiants = new List<Etudiant>()
        {
            new Etudiant("quentin.martinez@cambridge.com", 1)
            {
                NbTelechargementMaximum = 10,
                NbLivreTelecharges = 5,
            },
            new Etudiant("john.wick@oxford.com", 3)
            {
                NbTelechargementMaximum = 5,
                NbLivreTelecharges = 2,
            },
            new Etudiant("harry.potter@poudlard.com", 2)
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
