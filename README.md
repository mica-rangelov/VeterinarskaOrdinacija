# Veterinarska Ordinacija

Desktop aplikacija za upravljanje veterinarskom ordinacijom, razvijena kao zavrsni projekat u Windows Forms tehnologiji.

## Opis

Aplikacija omogucava veterinarima evidenciju vlasnika, njihovih ljubimaca (pasa, macaka i papagaja) i veterinarskih pregleda. Podaci se cuvaju lokalno u JSON fajlovima.

## Tehnologije

- **Jezik:** C# (.NET Framework 4.7.2)
- **UI:** Windows Forms (WinForms)
- **Serijalizacija:** DataContractJsonSerializer (JSON format, ISO 8601 datumi)
- **Hesiranje lozinki:** SHA-256

## Funkcionalnosti

- **Prijava korisnika** — autentifikacija sa hesiranim lozinkama (podrazumevani nalog: `admin` / `admin123`)
- **Upravljanje vlasnicima** — dodavanje, izmena, brisanje i pretraga vlasnika
- **Upravljanje ljubimcima** — evidencija pasa, macaka i papagaja sa specificnim atributima po vrsti
- **Upravljanje pregledima** — unos dijagnoze, terapije, napomena i imena veterinara
- **Istorija pregleda** — pregled kompletne medicinske istorije po ljubimcu
- **Filtriranje** — filtriranje ljubimaca po vrsti i vlasniku, pregleda po ljubimcu
- **Pretraga** — tekstualna pretraga vlasnika po imenu, prezimenu ili telefonu
- **TreeView navigacija** — hijerarhijski prikaz: Vlasnici > Ljubimci > Pregledi
- **Seed podaci** — automatsko popunjavanje test podataka pri prvom pokretanju
- **Sesija i odjava** — mogucnost odjave i ponovne prijave bez restartovanja aplikacije

## Struktura projekta

```
VeterinarskaOrdinacija.sln
VeterinarskaOrdinacija/
├── Modeli/             # Domenski modeli (entiteti)
│   ├── Ljubimac.cs     # Apstraktna bazna klasa za ljubimce
│   ├── Pas.cs          # Pas — rasa, visina, dresiran za cuvanje
│   ├── Macka.cs        # Macka — rasa, boja krzna, kucna/spoljna
│   ├── Papagaj.cs      # Papagaj — boja, moze da prica, broj reci
│   ├── Vlasnik.cs      # Vlasnik — ime, prezime, kontakt, adresa
│   ├── Pregled.cs      # Pregled — dijagnoza, terapija, napomene
│   ├── Korisnik.cs     # Korisnik sistema (korisnicko ime + hes lozinke)
│   └── Pol.cs          # Enum: Muski / Zenski
├── Podaci/             # Sloj za pristup podacima (skladista)
│   ├── Putanje.cs      # Centralne putanje do JSON fajlova
│   ├── Serijalizator.cs# Podesavanja JSON serijalizacije
│   ├── SkladisteVlasnika.cs
│   ├── SkladistePasa.cs
│   ├── SkladisteMacaka.cs
│   ├── SkladistePapagaja.cs
│   ├── SkladistePregleda.cs
│   └── SkladisteKorisnika.cs
├── Forme/              # Windows Forms (korisnicki interfejs)
│   ├── FormaPrijava.cs # Ekran za prijavu
│   ├── FormaGlavna.cs  # Glavni prozor sa tabovima i TreeView-om
│   ├── FormaVlasnik.cs # Dijalog za dodavanje/izmenu vlasnika
│   ├── FormaLjubimac.cs# Dijalog za dodavanje/izmenu ljubimca
│   ├── FormaPregled.cs # Dijalog za dodavanje/izmenu pregleda
│   └── FormaIstorija.cs# Prikaz istorije pregleda ljubimca
├── Pomocno/            # Pomocne klase
│   ├── HashLozinke.cs  # SHA-256 hesiranje lozinki
│   ├── Validator.cs    # Validacija unosa (email, telefon, ime, datum...)
│   ├── Sesija.cs       # Trenutno ulogovani korisnik
│   └── SeedPodaci.cs   # Generisanje pocetnih test podataka
├── data/               # JSON fajlovi sa podacima
├── Resources/          # Ikonica i logo
└── Program.cs          # Ulazna tacka aplikacije
```

## OOP koncepti

- **Apstrakcija i nasledjivanje** — `Ljubimac` je apstraktna klasa, `Pas`, `Macka` i `Papagaj` je nasledjuju
- **Polimorfizam** — metoda `Opis()` je apstraktna i svaka podklasa pruza svoju implementaciju
- **Enkapsulacija** — podaci su enkapsuliraoni kroz properties, a skladista kontrolisu pristup
- **Kompozicija** — vlasnik ima listu ljubimaca, ljubimac ima listu pregleda (povezano preko ID-jeva)

## Pokretanje

1. Otvoriti `VeterinarskaOrdinacija.sln` u Visual Studio-u (2017 ili noviji)
2. Build-ovati projekat (Ctrl+Shift+B)
3. Pokrenuti aplikaciju (F5)
4. Prijaviti se sa podrazumevanim nalogom:
   - **Korisnicko ime:** `admin`
   - **Lozinka:** `admin123`

## Skladistenje podataka

Podaci se cuvaju u `data/` folderu kao JSON fajlovi:
- `vlasnici.json` — spisak vlasnika
- `psi.json` — spisak pasa
- `macke.json` — spisak macaka
- `papagaji.json` — spisak papagaja
- `pregledi.json` — spisak pregleda
- `korisnici.json` — spisak korisnika sistema

Pri prvom pokretanju, aplikacija automatski generise test podatke sa 4 vlasnika, 7 ljubimaca i 5 pregleda.
