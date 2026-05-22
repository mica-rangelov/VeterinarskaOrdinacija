using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladistePapagaja
    {
        public List<Papagaj> Lista { get; private set; }

        public SkladistePapagaja()
        {
            Lista = new List<Papagaj>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Papagaji)) return;

            using (var fs = File.OpenRead(Putanje.Papagaji))
            {
                if (fs.Length == 0) return;
                var ser = new DataContractJsonSerializer(typeof(List<Papagaj>), Serijalizator.Podesavanja());
                var loaded = (List<Papagaj>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Papagaj>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Papagaji, ms.ToArray());
            }
        }

        public void Dodaj(Papagaj p)
        {
            Lista.Add(p);
            Sacuvaj();
        }

        public void Azuriraj(Papagaj p)
        {
            var postojeci = Lista.FirstOrDefault(x => x.Id == p.Id);
            if (postojeci == null) return;
            postojeci.Ime = p.Ime;
            postojeci.DatumRodjenja = p.DatumRodjenja;
            postojeci.Pol = p.Pol;
            postojeci.Tezina = p.Tezina;
            postojeci.VlasnikId = p.VlasnikId;
            postojeci.Boja = p.Boja;
            postojeci.MozeDaPrica = p.MozeDaPrica;
            postojeci.BrojNaucenihReci = p.BrojNaucenihReci;
            Sacuvaj();
        }

        public void Obrisi(Guid id)
        {
            var p = Lista.FirstOrDefault(x => x.Id == id);
            if (p == null) return;
            Lista.Remove(p);
            Sacuvaj();
        }

        public Papagaj Pronadji(Guid id) => Lista.FirstOrDefault(x => x.Id == id);
    }
}
