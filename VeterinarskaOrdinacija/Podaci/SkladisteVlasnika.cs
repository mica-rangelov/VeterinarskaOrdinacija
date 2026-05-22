using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladisteVlasnika
    {
        public List<Vlasnik> Lista { get; private set; }

        public SkladisteVlasnika()
        {
            Lista = new List<Vlasnik>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Vlasnici)) return;

            using (var fs = File.OpenRead(Putanje.Vlasnici))
            {
                if (fs.Length == 0) return;
                var ser = new DataContractJsonSerializer(typeof(List<Vlasnik>), Serijalizator.Podesavanja());
                var loaded = (List<Vlasnik>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Vlasnik>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Vlasnici, ms.ToArray());
            }
        }

        public void Dodaj(Vlasnik v)
        {
            Lista.Add(v);
            Sacuvaj();
        }

        public void Azuriraj(Vlasnik v)
        {
            var postojeci = Lista.FirstOrDefault(x => x.Id == v.Id);
            if (postojeci == null) return;
            postojeci.Ime = v.Ime;
            postojeci.Prezime = v.Prezime;
            postojeci.Telefon = v.Telefon;
            postojeci.Email = v.Email;
            postojeci.Adresa = v.Adresa;
            Sacuvaj();
        }

        public void Obrisi(Guid id)
        {
            var v = Lista.FirstOrDefault(x => x.Id == id);
            if (v == null) return;
            Lista.Remove(v);
            Sacuvaj();
        }

        public Vlasnik Pronadji(Guid id) => Lista.FirstOrDefault(x => x.Id == id);
    }
}
