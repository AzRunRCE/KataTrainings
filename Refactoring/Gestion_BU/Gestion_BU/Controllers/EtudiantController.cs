using Gestion_BU.Core.Interfaces;
using Gestion_BU.Core.Services;
using Gestion_BU.Infrastructure.Repositories;
using Gestion_BU.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_BU.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly RegistreService _registreService;
        private readonly IUniversiteRepository _universiteRepository;

        private readonly IEtudiantRepository _etudiantRepository;

        public EtudiantController(RegistreService registreService, IUniversiteRepository universityRepository, IEtudiantRepository edutiantRepository)
        {
            _registreService = registreService;
            _universiteRepository = universityRepository;
            _etudiantRepository = edutiantRepository;
        }

        public IActionResult Index()
        {
            var etudiants = _etudiantRepository.GetEtudiants();
            var etudiantsVm = new List<EtudiantViewModel>();
            foreach (var item in etudiants)
            {
                etudiantsVm.Add(new EtudiantViewModel()
                {
                    Email = item.AdresseEmail,
                    UniversiteId = item.UniversiteId,
                });
            }
            return View(etudiantsVm);
        }


        public IActionResult Add()
        {
            var vm = new EtudiantViewModel(_universiteRepository.GetAll());
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(EtudiantViewModel viewModel)
        {
            _registreService.AjouterEtudiant(viewModel.Email, viewModel.UniversiteId);
            return RedirectToAction("Index");
        }
    }
}
