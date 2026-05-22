using System;
using System.Runtime.Serialization;

namespace VeterinarskaOrdinacija.Modeli
{
    [DataContract]
    public class Pregled
    {
        [DataMember] public Guid Id { get; set; }
        [DataMember] public Guid LjubimacId { get; set; }
        [DataMember] public DateTime DatumPregleda { get; set; }
        [DataMember] public string Dijagnoza { get; set; }
        [DataMember] public string Terapija { get; set; }
        [DataMember] public string Napomene { get; set; }
        [DataMember] public string Veterinar { get; set; }

        public Pregled()
        {
            Id = Guid.NewGuid();
            DatumPregleda = DateTime.Now;
        }
    }
}
