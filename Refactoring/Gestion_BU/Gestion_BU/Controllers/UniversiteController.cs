using Gestion_BU.Core.Interfaces;
using Gestion_BU.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_BU.Controllers
{
    public class UniversiteController : Controller
    {
        private readonly IUniversiteRepository _universityRepository;

 

        public UniversiteController(IUniversiteRepository universityRepository )
        {
            _universityRepository = universityRepository;
        }

        public IActionResult Index()
        {
            var universities = _universityRepository.GetAll();
            var universitesVm = new List<UniversiteViewModel>();
            foreach (var item in universities)
            {
                universitesVm.Add(new UniversiteViewModel()
                {
                    Id = item.Id,
                    Nom = item.Name,
                    NomForfait = item.Forfait.ToString()
                });
            }
            return View(universitesVm);
        }


    }
}
