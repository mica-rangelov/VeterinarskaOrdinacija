using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladisteMacaka
    {
        public List<Macka> Lista { get; private set; }

        public SkladisteMacaka()
        {
            Lista = new List<Macka>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Macke)) return;

            using (var fs = File.OpenRead(Putanje.Macke))
            {
                if (fs.Length == 0) return;
                var ser = new DataContractJsonSerializer(typeof(List<Macka>), Serijalizator.Podesavanja());
                var loaded = (List<Macka>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Macka>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Macke, ms.ToArray());
            }
        }

        public void Dodaj(Macka m)
        {
            Lista.Add(m);
            Sacuvaj();
        }

        public void Azuriraj(Macka m)
        {
            var postojeci = Lista.FirstOrDefault(x => x.Id == m.Id);
            if (postojeci == null) return;
            postojeci.Ime = m.Ime;
            postojeci.DatumRodjenja = m.DatumRodjenja;
            postojeci.Pol = m.Pol;
            postojeci.Tezina = m.Tezina;
            postojeci.VlasnikId = m.VlasnikId;
            postojeci.Rasa = m.Rasa;
            postojeci.KucnaMacka = m.KucnaMacka;
            postojeci.BojaKrzna = m.BojaKrzna;
            Sacuvaj();
        }

        public void Obrisi(Guid id)
        {
            var m = Lista.FirstOrDefault(x => x.Id == id);
            if (m == null) return;
            Lista.Remove(m);
            Sacuvaj();
        }

        public Macka Pronadji(Guid id) => Lista.FirstOrDefault(x => x.Id == id);
    }
}
