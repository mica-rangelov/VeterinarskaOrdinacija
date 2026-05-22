using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladisteKorisnika
    {
        public List<Korisnik> Lista { get; private set; }

        public SkladisteKorisnika()
        {
            Lista = new List<Korisnik>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Korisnici))
            {
                KreirajDefaultAdmina();
                return;
            }

            using (var fs = File.OpenRead(Putanje.Korisnici))
            {
                if (fs.Length == 0)
                {
                    KreirajDefaultAdmina();
                    return;
                }
                var ser = new DataContractJsonSerializer(typeof(List<Korisnik>), Serijalizator.Podesavanja());
                var loaded = (List<Korisnik>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }

            if (Lista.Count == 0) KreirajDefaultAdmina();
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Korisnik>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Korisnici, ms.ToArray());
            }
        }

        public Korisnik Prijavi(string korisnickoIme, string lozinka)
        {
            var hes = HashLozinke.Hes(lozinka);
            return Lista.FirstOrDefault(k =>
                k.KorisnickoIme == korisnickoIme && k.LozinkaHash == hes);
        }

        private void KreirajDefaultAdmina()
        {
            Lista.Add(new Korisnik
            {
                KorisnickoIme = "admin",
                LozinkaHash = HashLozinke.Hes("admin123")
            });
            Sacuvaj();
        }
    }
}
