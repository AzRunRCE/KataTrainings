
using Gestion_BU.Core.Entities;
using Gestion_BU.Core.Interfaces;

namespace Gestion_BU.Core.Services
{
    public class RegistreService
    {
        private readonly IEtudiantRepository etudiantRepository;
        private readonly IUniversiteRepository universiteRepository;
        private readonly ILogger _logger;
        public RegistreService(IEtudiantRepository edutiantRepository, IUniversiteRepository universiteRepository, ILogger logger)
        {
            etudiantRepository = edutiantRepository;
            this.universiteRepository = universiteRepository;
            _logger = logger;
        }
        public bool AjouterEtudiant(string emailAddress, int universityId)
        {

            _logger.Log(string.Format("Log: Debut Ajout d'un etudiant avec cet e-mail '{0}'", emailAddress));

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                return false;
            }


            if (etudiantRepository.Exists(emailAddress))
            {
                return false;
            }


            var universite = universiteRepository.GetById(universityId);

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


            _logger.Log(string.Format("Log: Fin Ajout d'un etudiant avec cet e-mail '{0}'", emailAddress));

            return true;
        }


    }
}
