using System;

namespace Ucenje.E17KlasaObjekt.edunova
{
    public class Mjesto
    {
        public string Naziv { get; set; } = "Nije postavljeno";
        public string? PostanskiBroj { get; set; }
        public Zupanija? Zupanija { get; set; }
    }
}