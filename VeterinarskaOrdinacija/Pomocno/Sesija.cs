using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Pomocno
{
    // Drži trenutno ulogovanog korisnika dok aplikacija radi.
    public static class Sesija
    {
        public static Korisnik UlogovaniKorisnik { get; set; }

        public static string KorisnickoIme
            => UlogovaniKorisnik != null ? UlogovaniKorisnik.KorisnickoIme : "—";

        public static void Odjavi() => UlogovaniKorisnik = null;
    }
}
