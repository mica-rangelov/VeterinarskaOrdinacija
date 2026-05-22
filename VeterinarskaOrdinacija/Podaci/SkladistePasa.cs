using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladistePasa
    {
        public List<Pas> Lista { get; private set; }

        public SkladistePasa()
        {
            Lista = new List<Pas>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Psi)) return;

            using (var fs = File.OpenRead(Putanje.Psi))
            {
                if (fs.Length == 0) return;
                var ser = new DataContractJsonSerializer(typeof(List<Pas>), Serijalizator.Podesavanja());
                var loaded = (List<Pas>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Pas>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Psi, ms.ToArray());
            }
        }

        public void Dodaj(Pas p)
        {
            Lista.Add(p);
            Sacuvaj();
        }

        public void Azuriraj(Pas p)
        {
            var postojeci = Lista.FirstOrDefault(x => x.Id == p.Id);
            if (postojeci == null) return;
            postojeci.Ime = p.Ime;
            postojeci.DatumRodjenja = p.DatumRodjenja;
            postojeci.Pol = p.Pol;
            postojeci.Tezina = p.Tezina;
            postojeci.VlasnikId = p.VlasnikId;
            postojeci.Rasa = p.Rasa;
            postojeci.DresiranZaCuvanje = p.DresiranZaCuvanje;
            postojeci.Visina = p.Visina;
            Sacuvaj();
        }

        public void Obrisi(Guid id)
        {
            var p = Lista.FirstOrDefault(x => x.Id == id);
            if (p == null) return;
            Lista.Remove(p);
            Sacuvaj();
        }

        public Pas Pronadji(Guid id) => Lista.FirstOrDefault(x => x.Id == id);
    }
}
