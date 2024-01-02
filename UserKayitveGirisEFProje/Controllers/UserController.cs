using Microsoft.AspNetCore.Mvc;
using UserKayitveGirisEFProje.DataAccess;
using UserKayitveGirisEFProje.Entity;
using UserKayitveGirisEFProje.Models;

namespace UserKayitveGirisEFProje.Controllers
{
    public class UserController : Controller
    {

        public readonly DatabaseContext _databaseContext;
        public UserController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IActionResult GirisYap()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        public bool KayitYap(UserViewModel userVM)
        {

            if (userVM.Sifre == userVM.SifreTekrar)
            {
                User user = new User();
                user.Adi = userVM.Adi;
                user.Soyadi = userVM.Soyadi;
                user.Email = userVM.Email;
                user.Sifre = userVM.Sifre;

                _databaseContext.Users.Add(user);
                _databaseContext.SaveChanges();

                return true;
            }
            return false;
        }

        [HttpPost]
        public bool GirisYap(GirisViewModel girisVM)
        {

            var user = _databaseContext.Users.FirstOrDefault(u => u.Email == girisVM.Email);
            if (user != null && girisVM.Sifre == user.Sifre)
            {
                return true;
            }
            return false;

            //databaseContext.Users.ToList();
            //if (girisVM.Sifre == girisVM.SifreTekrar)
            //{
            //    User user = new User();
            //    user.Email = userVM.Email;
            //    user.Sifre = userVM.Sifre;

            //    databaseContext.Users.Add(user);
            //    databaseContext.SaveChanges();

            //    return true;
            //}
            return false;
        }
    }
}
