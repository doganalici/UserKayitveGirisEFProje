using UserKayitveGirisEFProje.DataAccess;
using UserKayitveGirisEFProje.Entity;
using UserKayitveGirisEFProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace UserKayitveGirisEFProje.Controllers
{
    public class IlanController : Controller
    {
        public readonly DatabaseContext _databaseContext;

        public IlanController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Advert> GetAdverts()
        {
            return _databaseContext.Adverts.ToList();
        }
        public IActionResult IlanEkle()
        {
            
            return View(_databaseContext.Categorys.ToList());
        }

        [HttpPost]
        public bool IlanKayit(AdvertViewModel advertVM)
        {


            if (advertVM.Marka != null && advertVM.Model != null && advertVM.Renk != null && advertVM.Yil != null && advertVM.Vites != null && advertVM.YakitTuru != null && advertVM.Kilometre != null)
            {
                Advert advert = new Advert();
                advert.Marka = advertVM.Marka;
                advert.Model = advertVM.Model;
                advert.Renk = advertVM.Renk;
                advert.Yil = advertVM.Yil;
                advert.Vites = advertVM.Vites;
                advert.YakitTuru = advertVM.YakitTuru;
                advert.Kilometre = advertVM.Kilometre;
                advert.Aciklama = advertVM.Aciklama;
                advert.CategoryId = advertVM.CategoryId;
                advert.ImagePath = "";

                _databaseContext.Adverts.Add(advert);
                _databaseContext.SaveChanges();

                return true;
            }
            return false;
        }

        [HttpPost]
        public List<Advert> GetAdvertsByCategoryId(int categoryId)
        {
            return _databaseContext.Adverts.Where(c=>c.CategoryId == categoryId).ToList();
        }

        public ActionResult FiltrelenmisIlanlarUrl(int categoryId)
        {
            return View();
        } 
        public ActionResult FiltrelenmisIlanlarForm(int categoryId)
        {
            return View();
        }
    }
}
