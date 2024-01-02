using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserKayitveGirisEFProje.Models;
using UserKayitveGirisEFProje.DataAccess;
using UserKayitveGirisEFProje.Entity;
using UserKayitveGirisEFProje.Utils;

namespace UserKayitveGirisEFProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _databaseContext;

        public HomeController(ILogger<HomeController> logger, DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            GirisPageModel girisPageModel = new();
            girisPageModel.Adverts = _databaseContext.Adverts.ToList();
            girisPageModel.Categories = _databaseContext.Categorys.ToList();
            return View(girisPageModel);
        }

        public IActionResult FiltrelenmisIlanlarUrl(int categoryId)
        {
            GirisPageModel girisPageModel = new();
            //girisPageModel.Adverts = _databaseContext.Adverts.ToList();
            girisPageModel.Adverts = _databaseContext.Adverts.Where(c=>c.CategoryId == categoryId).ToList();
            girisPageModel.Categories = _databaseContext.Categorys.ToList();
            return View(girisPageModel);
        }
        [HttpPost]
        public IActionResult FiltrelenmisIlanlarForm(int categoryId)
        {
            GirisPageModel girisPageModel = new();
            //girisPageModel.Adverts = _databaseContext.Adverts.ToList();
            girisPageModel.Adverts = _databaseContext.Adverts.Where(c=>c.CategoryId == categoryId).ToList();
            girisPageModel.Categories = _databaseContext.Categorys.ToList();
            return View(girisPageModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
