using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using VeterinarskaOrdinacija.Modeli;

namespace VeterinarskaOrdinacija.Podaci
{
    public class SkladistePregleda
    {
        public List<Pregled> Lista { get; private set; }

        public SkladistePregleda()
        {
            Lista = new List<Pregled>();
        }

        public void Ucitaj()
        {
            Lista.Clear();
            if (!File.Exists(Putanje.Pregledi)) return;

            using (var fs = File.OpenRead(Putanje.Pregledi))
            {
                if (fs.Length == 0) return;
                var ser = new DataContractJsonSerializer(typeof(List<Pregled>), Serijalizator.Podesavanja());
                var loaded = (List<Pregled>)ser.ReadObject(fs);
                if (loaded != null) Lista.AddRange(loaded);
            }
        }

        public void Sacuvaj()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Pregled>), Serijalizator.Podesavanja());
            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, Lista);
                File.WriteAllBytes(Putanje.Pregledi, ms.ToArray());
            }
        }

        public void Dodaj(Pregled p)
        {
            Lista.Add(p);
            Sacuvaj();
        }

        public void Azuriraj(Pregled p)
        {
            var postojeci = Lista.FirstOrDefault(x => x.Id == p.Id);
            if (postojeci == null) return;
            postojeci.LjubimacId = p.LjubimacId;
            postojeci.DatumPregleda = p.DatumPregleda;
            postojeci.Dijagnoza = p.Dijagnoza;
            postojeci.Terapija = p.Terapija;
            postojeci.Napomene = p.Napomene;
            postojeci.Veterinar = p.Veterinar;
            Sacuvaj();
        }

        public void Obrisi(Guid id)
        {
            var p = Lista.FirstOrDefault(x => x.Id == id);
            if (p == null) return;
            Lista.Remove(p);
            Sacuvaj();
        }

        public List<Pregled> ZaLjubimca(Guid ljubimacId)
            => Lista.Where(x => x.LjubimacId == ljubimacId)
                    .OrderByDescending(x => x.DatumPregleda)
                    .ToList();

        public void ObrisiZaLjubimca(Guid ljubimacId)
        {
            Lista.RemoveAll(x => x.LjubimacId == ljubimacId);
            Sacuvaj();
        }
    }
}
