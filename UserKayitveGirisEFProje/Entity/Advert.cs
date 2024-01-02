namespace UserKayitveGirisEFProje.Entity
{
    public class Advert
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int Yil { get; set; }
        public string Vites { get; set; }
        public string YakitTuru { get; set; }
        public double Kilometre { get; set; }
        public string ImagePath { get; set; }
        public string? Aciklama { get; set; }
        public int Fiyat { get; set; }
        public int CategoryId { get; set; }
    }
}
