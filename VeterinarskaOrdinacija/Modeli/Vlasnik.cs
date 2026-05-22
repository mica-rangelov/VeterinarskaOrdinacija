using System;
using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Vlasnik
    {
        [DataMember] public Guid Id { get; set; }
        [DataMember] public string Ime { get; set; }
        [DataMember] public string Prezime { get; set; }
        [DataMember] public string Telefon { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Adresa { get; set; }

        public Vlasnik()
        {
            Id = Guid.NewGuid();
        }

        public string PunoIme => $"{Ime} {Prezime}";

        public override string ToString() => PunoIme;
    }
}
