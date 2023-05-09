using Gestion_BU.Entities;
using Gestion_BU.Repositories;

namespace Gestion_BU.Services
{
    public class RegistreService
    {
        public bool AjouterEtudiant(string emailAddress, int universityId)
        {
           
            Console.WriteLine(string.Format("Log: Debut Ajout d'un etudiant avec cet e-mail '{0}'", emailAddress));

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                return false;
            }

            var etudiantRepository = new EtudiantRepository();

            if (etudiantRepository.Exists(emailAddress))
            {
                return false;
            }

            var UniversiteRepository = new UniversiteRepository();

            var universite = UniversiteRepository.GetById(universityId);

            var currEtudiant = new Etudiant(emailAddress, universityId);

           
            if (universite.Forfait == Forfait.Standard)
            {
                currEtudiant.NbTelechargementMaximum = 10;
            }
            else if (universite.Forfait == Forfait.Premium)
            {
                currEtudiant.NbTelechargementMaximum = 10 * 2;
            }

            etudiantRepository.Add(currEtudiant);

            
            Console.WriteLine(string.Format("Log: Fin Ajout d'un etudiant avec cet e-mail '{0}'", emailAddress));

            return true;
        }

      
    }
}
