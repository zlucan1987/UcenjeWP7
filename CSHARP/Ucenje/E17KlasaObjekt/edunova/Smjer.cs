using System;

namespace Ucenje.E17KlasaObjekt.edunova
{
    public class Smjer
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public int Trajanje { get; set; }
        public decimal Cijena { get; set; }
        public bool Vaucer { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
    }
}
