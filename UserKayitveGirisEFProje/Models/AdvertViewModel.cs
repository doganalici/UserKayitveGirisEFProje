using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UserKayitveGirisEFProje.Models
{
    public class AdvertViewModel
    {
        
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Yil { get; set; }
        public string Vites { get; set; }
        public string YakitTuru { get; set; }
        public double Kilometre { get; set; }
        public string Aciklama { get; set; }
        public int CategoryId { get; set; }

    }
}
