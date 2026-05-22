using System;
using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    // Apstraktna bazna klasa za sve ljubimce.
    // Pas, Macka i Papagaj nasleđuju ovu klasu i dodaju svoje specifičnosti.
    [DataContract]
    [KnownType(typeof(Pas))]
    [KnownType(typeof(Macka))]
    [KnownType(typeof(Papagaj))]
    public abstract class Ljubimac
    {
        [DataMember] public Guid Id { get; set; }
        [DataMember] public string Ime { get; set; }
        [DataMember] public DateTime DatumRodjenja { get; set; }
        [DataMember] public Pol Pol { get; set; }
        [DataMember] public double Tezina { get; set; }
        [DataMember] public Guid VlasnikId { get; set; }

        protected Ljubimac()
        {
            Id = Guid.NewGuid();
        }

        // Svaka podklasa daje svoj kratak opis (polimorfizam).
        public abstract string Opis();

        // Naziv vrste za prikaz. Default uzima ime klase; podklase mogu da prepišu.
        public virtual string Vrsta
        {
            get { return GetType().Name; }
        }

        public int Starost
        {
            get
            {
                var danas = DateTime.Today;
                var godina = danas.Year - DatumRodjenja.Year;
                if (DatumRodjenja.Date > danas.AddYears(-godina)) godina--;
                return godina < 0 ? 0 : godina;
            }
        }

        // Bez override-a, default ToString() bi vratio puno ime klase
        // ("VeterinarskaOrdinacija.Modeli.Pas") što je ono što ComboBox prikazuje
        // kad mu daš objekat direktno u Items.
        public override string ToString()
        {
            return Ime + " (" + Vrsta + ")";
        }
    }
}
