using System;
using System.IO;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Podaci;

namespace VeterinarskaOrdinacija.Pomocno
{
    // Seed-uje početne (mock) podatke ako fajlovi u "data" folderu ne postoje.
    // Pokreće se jednom, pri startu aplikacije. Kasnije svako pisanje u skladišta
    // prepisuje ove fajlove novim sadržajem.
    public static class SeedPodaci
    {
        public static void PopuniAkoTreba()
        {
            // Korisnici se već seed-uju u SkladisteKorisnika (admin/admin123).

            bool imaIkakvihPodataka =
                File.Exists(Putanje.Vlasnici) ||
                File.Exists(Putanje.Psi) ||
                File.Exists(Putanje.Macke) ||
                File.Exists(Putanje.Papagaji) ||
                File.Exists(Putanje.Pregledi);

            if (imaIkakvihPodataka) return;

            // ---- Vlasnici ----
            var sklVlasnika = new SkladisteVlasnika();
            sklVlasnika.Ucitaj();

            var v1 = new Vlasnik
            {
                Ime = "Petar",
                Prezime = "Petrović",
                Telefon = "+381 641234567",
                Email = "petar.petrovic@example.com",
                Adresa = "Beogradska 12, Beograd"
            };
            var v2 = new Vlasnik
            {
                Ime = "Ana",
                Prezime = "Anić",
                Telefon = "+381 631122334",
                Email = "ana.anic@example.com",
                Adresa = "Cara Lazara 5, Novi Sad"
            };
            var v3 = new Vlasnik
            {
                Ime = "Marko",
                Prezime = "Marković",
                Telefon = "+381 652233445",
                Email = "marko.markovic@example.com",
                Adresa = "Bulevar Oslobođenja 88, Niš"
            };
            var v4 = new Vlasnik
            {
                Ime = "Jelena",
                Prezime = "Jelić",
                Telefon = "+381 603344556",
                Email = "jelena.jelic@example.com",
                Adresa = "Kralja Petra 22, Kragujevac"
            };
            sklVlasnika.Dodaj(v1);
            sklVlasnika.Dodaj(v2);
            sklVlasnika.Dodaj(v3);
            sklVlasnika.Dodaj(v4);

            // ---- Psi ----
            var sklPasa = new SkladistePasa();
            sklPasa.Ucitaj();

            var reks = new Pas
            {
                Ime = "Reks",
                DatumRodjenja = new DateTime(2019, 5, 12),
                Pol = Pol.Muski,
                Tezina = 28.5,
                VlasnikId = v1.Id,
                Rasa = "Zlatni retriver",
                DresiranZaCuvanje = true,
                Visina = 58
            };
            var bobi = new Pas
            {
                Ime = "Bobi",
                DatumRodjenja = new DateTime(2021, 8, 3),
                Pol = Pol.Muski,
                Tezina = 4.2,
                VlasnikId = v2.Id,
                Rasa = "Jorkširski terijer",
                DresiranZaCuvanje = false,
                Visina = 22
            };
            var maks = new Pas
            {
                Ime = "Maks",
                DatumRodjenja = new DateTime(2018, 3, 20),
                Pol = Pol.Muski,
                Tezina = 35.0,
                VlasnikId = v3.Id,
                Rasa = "Nemački ovčar",
                DresiranZaCuvanje = true,
                Visina = 62
            };
            sklPasa.Dodaj(reks);
            sklPasa.Dodaj(bobi);
            sklPasa.Dodaj(maks);

            // ---- Mačke ----
            var sklMacaka = new SkladisteMacaka();
            sklMacaka.Ucitaj();

            var seki = new Macka
            {
                Ime = "Šeki",
                DatumRodjenja = new DateTime(2020, 6, 1),
                Pol = Pol.Muski,
                Tezina = 4.8,
                VlasnikId = v2.Id,
                Rasa = "Persijska",
                KucnaMacka = true,
                BojaKrzna = "Bela"
            };
            var mica = new Macka
            {
                Ime = "Mica",
                DatumRodjenja = new DateTime(2022, 4, 15),
                Pol = Pol.Zenski,
                Tezina = 3.2,
                VlasnikId = v4.Id,
                Rasa = "Domaća",
                KucnaMacka = false,
                BojaKrzna = "Crno-bela"
            };
            sklMacaka.Dodaj(seki);
            sklMacaka.Dodaj(mica);

            // ---- Papagaji ----
            var sklPapagaja = new SkladistePapagaja();
            sklPapagaja.Ucitaj();

            var ziza = new Papagaj
            {
                Ime = "Žiža",
                DatumRodjenja = new DateTime(2017, 11, 9),
                Pol = Pol.Zenski,
                Tezina = 0.45,
                VlasnikId = v1.Id,
                Boja = "Siva",
                MozeDaPrica = true,
                BrojNaucenihReci = 42
            };
            var lola = new Papagaj
            {
                Ime = "Lola",
                DatumRodjenja = new DateTime(2022, 1, 25),
                Pol = Pol.Zenski,
                Tezina = 0.08,
                VlasnikId = v4.Id,
                Boja = "Plavo-žuta",
                MozeDaPrica = false,
                BrojNaucenihReci = 0
            };
            sklPapagaja.Dodaj(ziza);
            sklPapagaja.Dodaj(lola);

            // ---- Pregledi ----
            var sklPregleda = new SkladistePregleda();
            sklPregleda.Ucitaj();

            DateTime danas = DateTime.Today;

            sklPregleda.Dodaj(new Pregled
            {
                LjubimacId = reks.Id,
                DatumPregleda = danas.AddMonths(-6).AddHours(10),
                Dijagnoza = "Godišnja sistematska kontrola — sve uredno.",
                Terapija = "Bez terapije. Preporučena multivitaminska kombinacija.",
                Napomene = "Pas miran i kooperativan tokom pregleda.",
                Veterinar = "admin"
            });
            sklPregleda.Dodaj(new Pregled
            {
                LjubimacId = reks.Id,
                DatumPregleda = danas.AddMonths(-1).AddHours(11),
                Dijagnoza = "Lakša upala uha (otitis externa).",
                Terapija = "Kapi za uši 2x dnevno, 7 dana.",
                Napomene = "Kontrola za 10 dana.",
                Veterinar = "admin"
            });
            sklPregleda.Dodaj(new Pregled
            {
                LjubimacId = bobi.Id,
                DatumPregleda = danas.AddDays(-20).AddHours(14),
                Dijagnoza = "Vakcinacija (godišnja).",
                Terapija = "Nema.",
                Napomene = "Sledeća vakcina za godinu dana.",
                Veterinar = "admin"
            });
            sklPregleda.Dodaj(new Pregled
            {
                LjubimacId = seki.Id,
                DatumPregleda = danas.AddMonths(-2).AddHours(9),
                Dijagnoza = "Pregled radi sterilizacije.",
                Terapija = "Operacija zakazana sledeće nedelje.",
                Napomene = "Klijent obavešten o preoperativnoj pripremi.",
                Veterinar = "admin"
            });
            sklPregleda.Dodaj(new Pregled
            {
                LjubimacId = ziza.Id,
                DatumPregleda = danas.AddDays(-5).AddHours(12),
                Dijagnoza = "Promene na perju — moguć stres ili nedostatak vitamina.",
                Terapija = "Korekcija ishrane, dodatak vitamina A i E.",
                Napomene = "Kontrola za mesec dana.",
                Veterinar = "admin"
            });
        }
    }
}
