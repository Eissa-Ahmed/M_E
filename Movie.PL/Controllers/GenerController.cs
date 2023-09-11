using Microsoft.AspNetCore.Mvc;
using Movie.BL.Interfaces;
using Movie.BL.Model;

namespace Movie.PL.Controllers
{
    public class GenerController : Controller
    {
        private readonly IGeners genersServices;
        public GenerController(IGeners genersServices)
        {
            this.genersServices = genersServices;
        }
        public async Task<IActionResult> AddGeners()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddGeners(GenersVM model)
        {
            await genersServices.AddGener(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
